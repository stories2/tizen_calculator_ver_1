#include "ex17.h"

char sentence[buffer_limit],stack[buffer_limit];
int top,failure;
//bool pass = false;

static void output_ver_1(char buffer[])
{

	if(failure== 0)
	{
		sprintf(sentence,"%s = %s",sentence,buffer);
	}
	else
	{
		sprintf(sentence,"%s = Fail",sentence);
	}
	//printf("total : %f\n",atof(buffer));
	dlog_print(DLOG_INFO,"ex17",buffer);
}

static void process()
{
	char buffer[buffer_limit] = {'\0',};
	int math_sentence[3][buffer_limit] = {0,};//1 : 실제 값 , 2 : 기호
	postfix_operators(buffer);
	translation(buffer,math_sentence);
	calculate(math_sentence , strlen(buffer) , buffer);
}

static void program(int left_point,int left_size , int right_point , int right_size , int operator_point , int math[][buffer_limit] , char buffer[])
{
	int i , t = 0 , str_length;
	char str_buffer[buffer_limit];
	sprintf(str_buffer,"program start info %d > %d : %d > %d : %d result : ",left_point,left_size,right_point,right_size,operator_point);
	dlog_print(DLOG_INFO,"ex17",str_buffer);
	if(ver == 1)
	{
		char target_a[buffer_limit] = {'\0',},target_b[buffer_limit] = {'\0',};
		double a , b ,result;
		char op ;
		t = 0;
		op = buffer[operator_point];

		for(i=left_point ; i<=left_point + left_size - 1;i+=1)
		{
			target_a[t] = buffer[i];
			t+=1;
		}
		t=0;
		a = atof(target_a);
		if(right_point != -1)
		{
			for(i=right_point ; i<=right_point + right_size - 1 ;i+=1)
			{
				target_b[t] = buffer[i];
				t+=1;
			}
			b = atof(target_b);
			result = get_result(a,b,op);
		}
		else
		{
			if(op == '+')
			{
				result = get_result(a,1.0,'*');
			}
			else if(op == '-')
			{
				result = get_result(a,-1.0,'*');
			}
			else
			{
				result = 0;
				failure = 1;
			}
		}


		printf("%f ",result);

		char temp[buffer_limit] = {'\0',};
		sprintf(temp,"%f",result);

		str_length = strlen(temp);
		t = 0;
		for(i=left_point ; i<=operator_point;i+=1)
		{
			if(t<str_length)
			{
				buffer[i] = temp[t];
				t+=1;
			}
			else
			{
				buffer[i] = '0';
			}
			math[2][i] = 0;
		}
		dlog_print(DLOG_INFO,"ex17",buffer);//printf("math : %s\n",buffer);
		translation(buffer,math);
	}
}

static double get_result(double a,double b, char op)
{
	double result = 0;
	if(op == '+')
	{
		result = a+b;
	}
	else if(op == '-')
	{
		result = a-b;
	}
	else if(op == '/')
	{
		result = a/b;
	}
	else if(op == '*')
	{
		result = a*b;
	}
	return result;
}

static bool check_finish(int math[][buffer_limit], int length)
{
	int i;
	bool run = false;
	for(i=0;i<length;i+=1)
	{
		if(math[2][i] == 5)
		{
			run = true;
		}
	}
	return run;
}

static void calculate(int math[][buffer_limit] , int length , char buffer[])
{
	int left[buffer_limit] = {'\0',} , right[buffer_limit] = {'\0',};
	int left_point , right_point , operator_point,i,t,str_length = length , left_gap , right_gap,cal_cnt = 0;
	bool oper = false,running = true;
	while(running)//메인 루프
	{
		if(cal_cnt > calculate_fail)
		{
			failure = 1;
			break;
		}
		cal_cnt+=1;
		left_point = -1;
		right_point = -1;
		operator_point = -1;
		oper = true;
		for(i=0;i<=str_length;i+=1)
		{
			if(math[2][i] == 5 || i == str_length )
			{
				if(oper == false)//해당 파트는 연산자가 아님
				{
					if(left_point == -1)
					{
						left_gap = 0;
						for(t=i-1;t>=0;t-=1)
						{
							if(math[2][t] == 5)
							{
								left_point = t+1;
								break;
							}
							else
							{
								left_gap += 1;
							}
						}
						if(t <= 0)
						{
							left_point = 0;
						}

					}
					else if(right_point == -1)
					{
						right_gap = 0;
						for(t=i-1;t>=0;t-=1)
						{
							if(math[2][t] == 5)
							{
								right_point = t+1;
								break;
							}
							else
							{
								right_gap += 1;
							}
						}
						if(t <= 0)
						{
							right_point = 0;
						}
					}
					else
					{
						left_point = right_point;
						left_gap = right_gap;
						right_gap = 0;
						for(t=i-1;t>=0;t-=1)
						{
							if(math[2][t] == 5)
							{
								right_point = t+1;
								break;
							}
							else
							{
								right_gap += 1;
							}
						}
						if(t <= 0)
						{
							right_point = 0;
						}
					}
				}
				else
				{
					if(left_point != -1 && right_point != -1)
					{
						operator_point = i-1;
						program(left_point,left_gap,right_point,right_gap,operator_point,math,buffer);
						running = check_finish(math , strlen(buffer));
						left_point = -1;
						right_point = -1;
						operator_point = -1;
						break;
					}
					if(i>=str_length-1 && left_point != -1 && right_point == -1)
					{
						operator_point = i-1;
						program(left_point,left_gap,right_point,right_gap,operator_point,math,buffer);
						running = false;
						break;
					}
				}
				oper = true;
			}
			if(math[2][i] == 0)
			{
				oper = false;
			}
		}
	}
	if(ver == 1)
	{
		output_ver_1(buffer);
	}
}

static void translation(char buffer[],int math[][buffer_limit])
{
	int i,t,str_length ;
	str_length = strlen(buffer);
	for(i=0;i<str_length;i+=1)
	{
		if(('0' <= buffer[i] && buffer[i] <= '9') || buffer[i] == '.')
		{
			if(buffer[i] != '.')
			{
				math[1][i] = buffer[i] - 48;
			}
			else
			{
				math[1][i] = -1;
			}
		}
		else
		{
			math[2][i] = operator_rank(buffer[i]);
		}
	}
	/*
	for(t=0;t<str_length;t+=1)
	{
		printf("%2d ",t);
	}
	printf("\n");
	for(i=1;i<=2;i+=1)
	{
		for(t=0;t<str_length;t+=1)
		{
			printf("%2d ",math[i][t]);
		}
		printf("\n");
	}*/
}

static int operator_rank(char operators)
{
	if(operators == '+' || operators == '-')
	{
		return 2;
	}
	else if(operators == '*' || operators == '/')
	{
		return 3;
	}
	else if(operators == '(')
	{
		return 4;
	}
	else if(operators == ')')
	{
		return 1;
	}
	else
	{
		return 5;
	}
}

static char pop()
{
	char result = stack[top];
	stack[top] = 0;
	top -= 1;
	return result;
}

static void push(char operators)
{
	top+=1;
	stack[top] = operators;
}

static char get_top()
{
	return stack[top];
}

static void postfix_operators(char buffer[])
{
	int i,t=0,str_length;
	str_length = strlen(sentence);
	bool write_line = false;
	for(i=0;i<=str_length;i+=1)
	{
		if(str_length == i)
		{
			if(write_line == true)
			{
				buffer[t] = '|';
				t+=1;
				write_line = false;
			}
			while(top>0)
			{
				if(operator_rank(get_top())==4 || operator_rank(get_top())==1)
				{
					pop();
				}
				buffer[t] = pop();
				t+=1;

				buffer[t] = '|';
				t+=1;
			}
		}
		else if(sentence[i] != ' ')
		{
			if(('0' <= sentence[i] && sentence[i] <= '9' ) || sentence[i] == '.')
			{
				buffer[t] = sentence[i];
				t+=1;
				write_line = true;
			}
			else
			{
				if('0' <= sentence[i+1] && sentence[i+1] <= '9')
				{
					buffer[t] = sentence[i];
					t+=1;
				}
				else
				{
					if(write_line == true)
					{
						buffer[t] = '|';
						t+=1;
						write_line = false;
					}
					while(top>0)
					{
						if(operator_rank(sentence[i]) == 1)
						{
							if(operator_rank(get_top()) == 4)
							{
								pop();
								break;
							}
							buffer[t] = pop();
							t+=1;

							buffer[t] = '|';
							t+=1;
						}
						else if(operator_rank(get_top()) >= operator_rank(sentence[i]))
						{
							if(operator_rank(get_top()) < 4) // '(' 는 사칙연산이 뺄수 없음
							{
								buffer[t] = pop();
								t+=1;

								buffer[t] = '|';
								t+=1;
							}
							else
							{
								break;
							}
						}
						else
						{
							break;
						}
					}
					if(operator_rank(sentence[i])!=1)
					{
						push(sentence[i]);
					}
				}
			}
		}
	}
	if(buffer[strlen(buffer)-1] == '|')
	{
		buffer[strlen(buffer)-1] = '\0';
	}
	sprintf(sentence,"%s = %s ",sentence,buffer);
	//printf("postfix_operators : %s\n",buffer);
	dlog_print(DLOG_INFO,"ex17",buffer);
}

static void input()
{
	//freopen("input.txt","r",stdin);
	//scanf("%[^\n]s",sentence);
	//printf("origin : %s\n",sentence);
	top = 0;
	failure = 0;
	sentence[strlen(sentence)-1] = '\0';
	make_sentence(sentence);
	dlog_print(DLOG_INFO,"ex17",sentence);
}

static void main_process(char target[])
{
	//dlog_print(DLOG_INFO,"ex17",target);
	strcpy(sentence,target);
	input();
	process();
	strcpy(target,sentence);
	int i,str_length = strlen(sentence);
	for(i=0;i<str_length;i+=1)
	{
		sentence[i] = '\0';
	}
}

static void make_sentence(char target[])
{
	int i,t,cnt = -1, str_length = strlen(target);
	bool jump = false;
	for(i=0;i<str_length;i+=1)
	{
		if(operator_rank(target[i]) == 2 )
		{
			cnt +=1;
			if(cnt == 1)
			{
				str_length = str_length + 1;
				for(t=str_length - 1; t>i+1;t-=1)
				{
					target[t] = target[t-1];
					target[t-1] = ' ';
				}
				i = i + 1;
			}
		}
		if(target[i] != ' ' && operator_rank(target[i]) == 5)
		{
			cnt = 0;// + +1
		}
		if(operator_rank(target[i]) == 1 || operator_rank(target[i]) == 4 || operator_rank(target[i]) == 3)
		{
			cnt = -1;
		}
	}
}
