################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
C_SRCS += \
../src/click_event.c \
../src/ex17.c \
../src/progress.c 

OBJS += \
./src/click_event.o \
./src/ex17.o \
./src/progress.o 

C_DEPS += \
./src/click_event.d \
./src/ex17.d \
./src/progress.d 


# Each subdirectory must supply rules for building sources it contributes
src/%.o: ../src/%.c
	@echo 'Building file: $<'
	@echo 'Invoking: C Compiler'
	$(CC) -I"pch" -D_DEBUG -I"$(PROJ_PATH)\inc" -O0 -g3 -Wall -c -fmessage-length=0 $(TC_COMPILER_MISC) $(RS_COMPILER_MISC) -fPIE --sysroot="$(SBI_SYSROOT)" -mthumb -I@system_includes -Werror-implicit-function-declaration -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


