S/W Version Information
Model: TM1
Tizen-Version: 2.4.0b
Build-Number: Tizen-2.4.0_Mobile-TM1_20150818.1608
Build-Date: 2015.08.18 16:08:58

Crash Information
Process Name: ex17
PID: 8591
Date: 2016-02-25 20:19:53+0900
Executable File Path: /opt/usr/apps/org.example.ex17/bin/ex17
Signal: 6
      (SIGABRT)
      si_code: 0
      signal sent by kill (sent by pid 988, uid 0)

Register Information
r0   = 0xbeaf1f3c, r1   = 0xbeaf3ee8
r2   = 0x00001f40, r3   = 0xbeaf3ed0
r4   = 0xbeaf3ed0, r5   = 0xbeaf6db0
r6   = 0xbeaf1f08, r7   = 0xbeaf3eb4
r8   = 0xb6c35560, r9   = 0xb62c3bd4
r10  = 0xb82dc978, fp   = 0x80052293
ip   = 0xffffffff, sp   = 0xbeaf1f08
lr   = 0xb474e6bf, pc   = 0xb474e5c0
cpsr = 0x20030030

Memory Information
MemTotal:   727828 KB
MemFree:    297644 KB
Buffers:     40836 KB
Cached:     146048 KB
VmPeak:      94640 KB
VmSize:      94636 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       17824 KB
VmRSS:       17824 KB
VmData:      40888 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       22384 KB
VmPTE:          74 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 8591 TID = 8591
8591 8592 8643 8644 8649 

Maps Information
b1781000 b1f80000 rwxp [stack:8649]
b314f000 b394e000 rwxp [stack:8644]
b394e000 b3953000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b3999000 b39aa000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b39ba000 b39bf000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b39cf000 b39d3000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39e4000 b39ec000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b39fd000 b3a02000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b3a12000 b3a1a000 r-xp /usr/lib/libcallmgr_client.so.0.0.0
b3a2a000 b3a2b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a3b000 b3a42000 r-xp /usr/lib/libfeedback.so.0.1.4
b3a65000 b3a7a000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b3a8e000 b3a93000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3aa3000 b3aa4000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b3ab4000 b3ab7000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b3ac8000 b3ac9000 r-xp /usr/lib/libxshmfence.so.1.0.0
b3ad9000 b3adb000 r-xp /usr/lib/libxcb-present.so.0.0.0
b3aeb000 b3aec000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b3afd000 b3b04000 r-xp /usr/lib/libdrm.so.2.4.0
b3b15000 b3b18000 r-xp /usr/lib/libdri2.so.0.0.0
b3b28000 b3b2f000 r-xp /usr/lib/libtbm.so.1.0.0
b3b40000 b3b41000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3b53000 b3b54000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3b64000 b3b6f000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3b81000 b4380000 rwxp [stack:8643]
b44b2000 b44b9000 r-xp /usr/lib/libeventsystem.so.0.0.1
b44c9000 b44cf000 r-xp /usr/lib/libefl-extension.so.0.1.0
b44df000 b44ec000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b44fe000 b450e000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b4644000 b4727000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b474c000 b474f000 r-xp /opt/usr/apps/org.example.ex17/bin/ex17
b4758000 b4781000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4794000 b4f93000 rwxp [stack:8592]
b4f93000 b4f95000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b52d6000 b52e0000 r-xp /lib/libnss_files-2.20-2014.11.so
b52f1000 b52fa000 r-xp /lib/libnss_nis-2.20-2014.11.so
b530b000 b531c000 r-xp /lib/libnsl-2.20-2014.11.so
b532f000 b5335000 r-xp /lib/libnss_compat-2.20-2014.11.so
b5346000 b534f000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.4
b5360000 b5363000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b5374000 b5376000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b5387000 b538c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b539c000 b53a2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b53b2000 b53b9000 r-xp /usr/lib/libsensord-share.so
b53c9000 b53db000 r-xp /usr/lib/libsensor.so.1.1.0
b53ec000 b53f2000 r-xp /usr/lib/libappcore-common.so.1.1
b5416000 b541b000 r-xp /usr/lib/libappcore-efl.so.1.1
b5431000 b5434000 r-xp /usr/lib/libuuid.so.1.3.0
b5444000 b545b000 r-xp /usr/lib/libblkid.so.1.1.0
b546c000 b546e000 r-xp /usr/lib/libXau.so.6.0.0
b547f000 b54c6000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b54d7000 b54de000 r-xp /usr/lib/libjson-c.so.2.0.1
b54ee000 b54f2000 r-xp /usr/lib/libogg.so.0.7.1
b5502000 b5523000 r-xp /usr/lib/libvorbis.so.0.4.3
b5534000 b5618000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b5635000 b564d000 r-xp /usr/lib/libmount.so.1.1.0
b565e000 b5671000 r-xp /usr/lib/libxcb.so.1.1.0
b5681000 b5688000 r-xp /lib/libcrypt-2.20-2014.11.so
b56c0000 b56c2000 r-xp /usr/lib/libiri.so
b56d3000 b57a2000 r-xp /usr/lib/libxml2.so.2.7.8
b57b8000 b57ed000 r-xp /usr/lib/libpulse.so.0.16.2
b57fe000 b5841000 r-xp /usr/lib/libsndfile.so.1.0.25
b5857000 b586c000 r-xp /lib/libexpat.so.1.5.2
b587f000 b58cd000 r-xp /usr/lib/libssl.so.1.0.0
b58e1000 b58ec000 r-xp /usr/lib/libeeze.so.1.13.0
b58fd000 b5906000 r-xp /usr/lib/libethumb.so.1.13.0
b5916000 b5919000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b5929000 b5adc000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b05000 b5b0e000 r-xp /usr/lib/libXi.so.6.1.0
b5b1e000 b5b20000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b30000 b5b34000 r-xp /usr/lib/libXtst.so.6.1.0
b5b44000 b5b4a000 r-xp /usr/lib/libXrender.so.1.3.0
b5b5a000 b5b5f000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b70000 b5b72000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b83000 b5b86000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b96000 b5ba0000 r-xp /usr/lib/libXext.so.6.4.0
b5bb1000 b5bb3000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bc3000 b5bc5000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bd5000 b5cb8000 r-xp /usr/lib/libX11.so.6.3.0
b5ccc000 b5cd2000 r-xp /usr/lib/libXcursor.so.1.0.2
b5ce3000 b5cfb000 r-xp /usr/lib/libudev.so.1.6.0
b5cfd000 b5d00000 r-xp /lib/libattr.so.1.1.0
b5d10000 b5d2e000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d3f000 b5d44000 r-xp /usr/lib/libffi.so.6.0.2
b5d54000 b5d6c000 r-xp /lib/libz.so.1.2.8
b5d7c000 b5d7e000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d8e000 b5e2a000 r-xp /usr/lib/libstdc++.so.6.0.20
b5e45000 b5e48000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5e58000 b5e63000 r-xp /usr/lib/libvconf.so.0.2.45
b5e73000 b5e8f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5e9f000 b5eb0000 r-xp /lib/libresolv-2.20-2014.11.so
b5ec4000 b5edb000 r-xp /usr/lib/liblzma.so.5.0.3
b5eeb000 b5eed000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5efd000 b5f04000 r-xp /usr/lib/libembryo.so.1.13.0
b5f14000 b5f1e000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5f2e000 b5f46000 r-xp /usr/lib/libpng12.so.0.50.0
b5f56000 b5f79000 r-xp /usr/lib/libjpeg.so.8.0.2
b5f99000 b5f9f000 r-xp /lib/librt-2.20-2014.11.so
b5fb0000 b5fc4000 r-xp /usr/lib/libector.so.1.13.0
b5fd5000 b5fed000 r-xp /usr/lib/liblua-5.1.so
b5ffe000 b6056000 r-xp /usr/lib/libfreetype.so.6.11.3
b6069000 b6091000 r-xp /usr/lib/libfontconfig.so.1.8.0
b60a2000 b60b5000 r-xp /usr/lib/libfribidi.so.0.3.1
b60c5000 b60fe000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b610e000 b6179000 r-xp /lib/libm-2.20-2014.11.so
b618a000 b6197000 r-xp /usr/lib/libeio.so.1.13.0
b61a7000 b61a9000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b61b9000 b61bd000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b61ce000 b61e5000 r-xp /usr/lib/libefreet.so.1.13.0
b61f6000 b6215000 r-xp /usr/lib/libeldbus.so.1.13.0
b6226000 b6246000 r-xp /usr/lib/libecore_con.so.1.13.0
b6257000 b625d000 r-xp /usr/lib/libecore_imf.so.1.13.0
b626d000 b627e000 r-xp /usr/lib/libemotion.so.1.13.0
b628f000 b6296000 r-xp /usr/lib/libethumb_client.so.1.13.0
b62a6000 b62b4000 r-xp /usr/lib/libeo.so.1.13.0
b62c4000 b62d6000 r-xp /usr/lib/libecore_input.so.1.13.0
b62e6000 b62eb000 r-xp /usr/lib/libecore_file.so.1.13.0
b62fb000 b6312000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6323000 b6340000 r-xp /usr/lib/libeet.so.1.13.0
b6358000 b639f000 r-xp /usr/lib/libeina.so.1.13.0
b63b0000 b63bf000 r-xp /usr/lib/libefl.so.1.13.0
b63d0000 b6408000 r-xp /usr/lib/libecore_x.so.1.13.0
b641a000 b641d000 r-xp /lib/libcap.so.2.21
b642d000 b6455000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6465000 b646c000 r-xp /usr/lib/libcapi-base-common.so.0.2.1
b647e000 b64b4000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b64c5000 b65af000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b65c3000 b662c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b663e000 b6640000 r-xp /usr/lib/libvasum.so.0.3.1
b6650000 b6652000 r-xp /usr/lib/libttrace.so.1.1
b6662000 b6665000 r-xp /usr/lib/libiniparser.so.0
b6675000 b6697000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b66a8000 b66ad000 r-xp /usr/lib/libxdgmime.so.1.1.0
b66be000 b66d5000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b66e6000 b66f4000 r-xp /usr/lib/libunwind.so.8.0.1
b6729000 b684f000 r-xp /lib/libc-2.20-2014.11.so
b6865000 b687e000 r-xp /lib/libgcc_s-4.9.so.1
b688e000 b6970000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6981000 b69b5000 r-xp /usr/lib/libdbus-1.so.3.8.11
b69c5000 b69ff000 r-xp /usr/lib/libsystemd.so.0.4.0
b6a02000 b6a82000 r-xp /usr/lib/libedje.so.1.13.0
b6a85000 b6aa3000 r-xp /usr/lib/libecore.so.1.13.0
b6ac2000 b6c25000 r-xp /usr/lib/libevas.so.1.13.0
b6c5c000 b6c70000 r-xp /lib/libpthread-2.20-2014.11.so
b6c84000 b6ea6000 r-xp /usr/lib/libelementary.so.1.13.0
b6ed4000 b6ed8000 r-xp /usr/lib/libsmack.so.1.0.0
b6ee8000 b6eef000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eff000 b6f01000 r-xp /usr/lib/libdlog.so.0.0.0
b6f11000 b6f14000 r-xp /usr/lib/libbundle.so.0.1.22
b6f24000 b6f26000 r-xp /lib/libdl-2.20-2014.11.so
b6f37000 b6f4d000 r-xp /usr/lib/libaul.so.0.1.0
b6f5f000 b6f61000 r-xp /usr/lib/libappsvc.so.0.1.0
b6f72000 b6f76000 r-xp /usr/lib/libsys-assert.so
b6f87000 b6fa7000 r-xp /lib/ld-2.20-2014.11.so
b6fb8000 b6fbf000 r-xp /usr/bin/launchpad-loader
b80e7000 b8358000 rw-p [heap]
bead7000 beaf8000 rwxp [stack]
b80e7000 b8358000 rw-p [heap]
bead7000 beaf8000 rwxp [stack]
End of Maps Information

Callstack Information (PID:8591)
Call Stack Count: 1
 0: calculate + 0x15b (0xb474e5c0) [/opt/usr/apps/org.example.ex17/bin/ex17] + 0x25c0
End of Call Stack

Package Information
Package Name: org.example.ex17
Package ID : org.example.ex17
Version: 1.0.0
Package Type: tpk
App Name: ex17
App ID: org.example.ex17
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
0 I/APP_CORE( 8591): appcore-efl.c: __do_app(472) > [APP 8591] Event: RESET State: CREATED
02-25 20:19:03.368+0900 D/APP_CORE( 8591): appcore-efl.c: __do_app(504) > [APP 8591] RESET
02-25 20:19:03.368+0900 D/LAUNCH  ( 8591): appcore-efl.c: __do_app(506) > [ex17:Application:reset:start]
02-25 20:19:03.368+0900 D/APP_CORE( 8591): appcore-efl.c: __do_app(509) > [__SUSPEND__] reset case
02-25 20:19:03.368+0900 D/APP_CORE( 8591): appcore-efl.c: __appcore_efl_exit_from_suspend(373) > [__SUSPEND__]
02-25 20:19:03.368+0900 I/CAPI_APPFW_APPLICATION( 8591): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
02-25 20:19:03.368+0900 D/AUL     ( 8591): service.c: __set_bundle(187) > __set_bundle
02-25 20:19:03.368+0900 D/LAUNCH  ( 8591): appcore-efl.c: __do_app(519) > [ex17:Application:reset:done]
02-25 20:19:03.368+0900 D/APP_CORE( 8591): appcore.c: __aul_handler(598) > [SECURE_LOG] caller_appid : org.tizen.menu-screen
02-25 20:19:03.378+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
02-25 20:19:03.378+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:03.378+0900 E/E17     (  563): e_border.c: e_border_show(2090) > BD_SHOW(0x03a00002)
02-25 20:19:03.378+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
02-25 20:19:03.378+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:03.378+0900 D/STARTER (  838): lock_mgr.c: _lock_show_cb(321) > [_lock_show_cb:321] lockw(0xb8cc36a8), lock_pid(-1)
02-25 20:19:03.378+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
02-25 20:19:03.378+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:03.378+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
02-25 20:19:03.378+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:03.378+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
02-25 20:19:03.378+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:03.438+0900 D/STARTER (  838): window_mgr.c: window_mgr_set_prop(206) > [window_mgr_set_prop:206] Check PID(8591) window. (lock_app_pid : -1)
02-25 20:19:03.448+0900 W/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(596) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=8591
02-25 20:19:03.458+0900 E/EFL     (  563): eo<563> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (413) could not be resolved for class 'Evas_Object_Smart'.
02-25 20:19:03.458+0900 E/EFL     (  563): eo<563> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (413) could not be resolved for class 'Evas_Object_Smart'.
02-25 20:19:03.478+0900 W/AUL_AMD (  738): amd_request.c: __request_handler(835) > __request_handler: 15
02-25 20:19:03.478+0900 D/PKGMGR_INFO(  738): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3633) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.ex17/bin/ex17' and package_app_info.app_disable IN ('false','False')
02-25 20:19:03.478+0900 D/PKGMGR_INFO(  738): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3639) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'ko-kr') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.ex17/bin/ex17' and package_app_info.app_disable IN ('false','False')
02-25 20:19:03.478+0900 D/AUL_AMD (  738): amd_status.c: _status_get_appid_bypid(774) > [SECURE_LOG] appid for 8591 is org.example.ex17
02-25 20:19:03.478+0900 D/AUL_AMD (  738): amd_request.c: __request_handler(1044) > APP_GET_APPID_BYPID : 8591 : 0
02-25 20:19:03.478+0900 D/AUL     (  901): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 25
02-25 20:19:03.518+0900 D/AUL_PAD (  871): launchpad.c: __launchpad_main_loop(475) > Prepare another candidate process
02-25 20:19:03.518+0900 D/AUL_PAD ( 8645): sigchild.h: __signal_unblock_sigchld(223) > SIGCHLD unblocked
02-25 20:19:03.518+0900 D/APP_CORE( 8591): appcore.c: __prt_ltime(233) > [APP 8591] first idle after reset: 621 msec
02-25 20:19:03.528+0900 I/MALI    (  563): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x14112a0), gem(21), surface(0x143e800)
02-25 20:19:03.538+0900 I/MALI    (  563): egl_platform_x11_tizen.c: __egl_platform_map_pixmap_tizen(738) > [EGL-X11] eglimage target 0 imported bo(0x1365ba0), gem(20), surface(0x14637e0)
02-25 20:19:03.538+0900 E/E17     (  563): e_border.c: e_border_hide(2250) > BD_HIDE(0x01800003), visible:1
02-25 20:19:03.538+0900 D/AUL_PAD (  871): sigchild.h: __send_app_launch_signal(130) > send launch signal done
02-25 20:19:03.548+0900 D/APP_CORE(  845): appcore-efl.c: __update_win(770) > [EVENT_TEST][EVENT] __update_win WIN:1800003 fully_obscured 1
02-25 20:19:03.548+0900 D/APP_CORE(  845): appcore-efl.c: __visibility_cb(941) > bvisibility 0, b_active 1
02-25 20:19:03.548+0900 D/APP_CORE(  845): appcore-efl.c: __visibility_cb(955) >  Go to Pasue state 
02-25 20:19:03.548+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(472) > [APP 845] Event: PAUSE State: RUNNING
02-25 20:19:03.548+0900 D/APP_CORE(  845): appcore-efl.c: __do_app(540) > [APP 845] PAUSE
02-25 20:19:03.548+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
02-25 20:19:03.548+0900 D/MENU_SCREEN(  845): menu_screen.c: _pause_cb(503) > Pause start
02-25 20:19:03.548+0900 D/APP_CORE(  845): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
02-25 20:19:03.548+0900 E/APP_CORE(  845): appcore-efl.c: __trm_app_info_send_socket(242) > access
02-25 20:19:03.558+0900 D/INDICATOR(  805): main.c: _property_changed_cb(432) > UNSNIFF API 1800003
02-25 20:19:03.558+0900 W/APP_CORE( 8591): appcore-efl.c: __show_cb(882) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:3a00002
02-25 20:19:03.558+0900 D/APP_CORE( 8591): appcore-efl.c: __add_win(724) > [EVENT_TEST][EVENT] __add_win WIN:3a00002
02-25 20:19:03.558+0900 D/APP_CORE( 8591): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
02-25 20:19:03.558+0900 D/AUL     ( 8591): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(35)
02-25 20:19:03.558+0900 W/AUL_AMD (  738): amd_request.c: __request_handler(835) > __request_handler: 35
02-25 20:19:03.558+0900 D/INDICATOR(  805): util.c: util_signal_emit_by_win(116) > emission bg.opaque
02-25 20:19:03.558+0900 E/RESOURCED(  988): edbus-handler.c: dbus_method_sync(173) > [dbus_method_sync,173] dbus_connection_send error(No reply)
02-25 20:19:03.558+0900 E/RESOURCED(  988): edbus-handler.c: dbus_method_sync(177) > [dbus_method_sync,177] dbus_connection_send error(org.freedesktop.DBus.Error.NameHasNoOwner:Could not get PID of name ':1.290': no such name)
02-25 20:19:03.558+0900 E/RESOURCED(  988): resourced-dbus.c: resourced_dbus_get_busname_pid(426) > [resourced_dbus_get_busname_pid,426] Failed to sync call 'GetConnectionUnixProcessID' of ':1.290'
02-25 20:19:03.558+0900 E/RESOURCED(  988): resourced-dbus.c: resourced_dbus_name_owner_changed_callback(636) > [resourced_dbus_name_owner_changed_callback,636] Failed to get connection unix process id of :1.290
02-25 20:19:03.558+0900 E/RESOURCED(  988): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(323) > [resourced_dbus_system_hash_drop_busname,323] Does not exist in busname hash: :1.290
02-25 20:19:03.568+0900 D/AUL_AMD (  738): amd_launch.c: __e17_status_handler(2217) > pid(8591) status(3)
02-25 20:19:03.568+0900 D/AUL_AMD (  738): amd_key.c: _key_ungrab(253) > _key_ungrab, win : 1200002
02-25 20:19:03.578+0900 D/INDICATOR(  805): main.c: _rotate_window(229) > Indicator angle is 0 degree
02-25 20:19:03.578+0900 D/INDICATOR(  805): box.c: box_get_right_item_count(242) > system cnt : 1, minictrl cnt : 0, noti cnt : 1
02-25 20:19:03.578+0900 D/INDICATOR(  805): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 2
02-25 20:19:03.578+0900 D/INDICATOR(  805): main.c: _rotate_window(252) > port :: hide more icon
02-25 20:19:03.578+0900 D/AUL_AMD (  738): amd_launch.c: __e17_status_handler(2223) > back key ungrab
02-25 20:19:03.578+0900 D/AUL_AMD (  738): amd_status.c: _status_update_app_info_list(325) > pid(8591) status(3)
02-25 20:19:03.578+0900 D/AUL_AMD (  738): amd_status.c: _status_update_app_info_list(337) > pid(8591) appid(org.example.ex17) pkgid(org.example.ex17) status(3)
02-25 20:19:03.578+0900 D/AUL     (  738): amd_app_group.c: __set_fg_flag(167) > send_signal FG org.example.ex17
02-25 20:19:03.578+0900 D/AUL_AMD (  738): amd_status.c: _status_update_app_info_list(325) > pid(845) status(4)
02-25 20:19:03.578+0900 E/MALI    (  563): tizen_buffer.c: tizen_buffer_swap(1197) > SPICY DRI2SwapBuffersWithRegion [1] (0 0 720 1280)
02-25 20:19:03.578+0900 D/AUL_AMD (  738): amd_status.c: _status_update_app_info_list(337) > pid(845) appid(org.tizen.menu-screen) pkgid(org.tizen.menu-screen) status(4)
02-25 20:19:03.578+0900 D/AUL     (  738): amd_app_group.c: __set_fg_flag(175) > send_signal BG org.tizen.menu-screen
02-25 20:19:03.588+0900 D/RESOURCED(  988): proc-main.c: resourced_proc_status_change(846) > [SECURE_LOG] [resourced_proc_status_change,846] set foreground : 8591
02-25 20:19:03.588+0900 D/RESOURCED(  988): logging-cpu.c: logging_cpu_foreground_state(167) > [logging_cpu_foreground_state,167] logging_cpu_foreground_state : pid = 8591, appname = org.example.ex17, pkgname = org.example.ex17
02-25 20:19:03.588+0900 D/RESOURCED(  988): cpu.c: cpu_foreground_state(218) > [cpu_foreground_state,218] cpu_foreground_state : pid = 8591, appname = org.example.ex17
02-25 20:19:03.588+0900 D/RESOURCED(  988): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] [cgroup_write_node,134] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 8591
02-25 20:19:03.588+0900 D/RESOURCED(  988): freezer-process.c: freezer_process_pid_set(392) > [freezer_process_pid_set,392] freezer_process_pid_set 8591
02-25 20:19:03.608+0900 D/APP_CORE( 8591): appcore-efl.c: __update_win(770) > [EVENT_TEST][EVENT] __update_win WIN:3a00002 fully_obscured 0
02-25 20:19:03.608+0900 D/APP_CORE( 8591): appcore-efl.c: __visibility_cb(941) > bvisibility 1, b_active -1
02-25 20:19:03.608+0900 D/APP_CORE( 8591): appcore-efl.c: __visibility_cb(944) >  Go to Resume state
02-25 20:19:03.608+0900 I/APP_CORE( 8591): appcore-efl.c: __do_app(472) > [APP 8591] Event: RESUME State: CREATED
02-25 20:19:03.608+0900 D/LAUNCH  ( 8591): appcore-efl.c: __do_app(570) > [ex17:Application:resume:start]
02-25 20:19:03.608+0900 D/APP_CORE( 8591): appcore-efl.c: __do_app(573) > [__SUSPEND__] resume case
02-25 20:19:03.608+0900 D/APP_CORE( 8591): appcore-efl.c: __appcore_efl_exit_from_suspend(373) > [__SUSPEND__]
02-25 20:19:03.608+0900 D/APP_CORE( 8591): appcore-efl.c: __do_app(578) > [APP 8591] RESUME
02-25 20:19:03.628+0900 I/APP_CORE( 8591): appcore-efl.c: __do_app(583) > Legacy lifecycle: 0
02-25 20:19:03.628+0900 I/APP_CORE( 8591): appcore-efl.c: __do_app(585) > [APP 8591] Initial Launching, call the resume_cb
02-25 20:19:03.628+0900 I/CAPI_APPFW_APPLICATION( 8591): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
02-25 20:19:03.628+0900 D/LAUNCH  ( 8591): appcore-efl.c: __do_app(607) > [ex17:Application:resume:done]
02-25 20:19:03.628+0900 D/LAUNCH  ( 8591): appcore-efl.c: __do_app(609) > [ex17:Application:Launching:done]
02-25 20:19:03.628+0900 D/APP_CORE( 8591): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
02-25 20:19:03.628+0900 E/APP_CORE( 8591): appcore-efl.c: __trm_app_info_send_socket(242) > access
02-25 20:19:03.648+0900 I/MALI    (  563): egl_platform_x11_tizen.c: __egl_platform_update_image_change_buffer(646) > [EGL-X11] eglimage target 30b0 imported bo(0x1448bc0), gem(22), surface(0x146c220)
02-25 20:19:03.648+0900 E/MALI    (  563): tizen_buffer.c: tizen_buffer_swap(1197) > SPICY DRI2SwapBuffersWithRegion [1] (0 0 720 1280)
02-25 20:19:03.798+0900 E/MALI    (  563): tizen_buffer.c: tizen_buffer_swap(1197) > SPICY DRI2SwapBuffersWithRegion [1] (0 0 720 1280)
02-25 20:19:04.149+0900 D/MENU_SCREEN(  845): layout.c: layout_disable_block(124) > Disable layout blocker
02-25 20:19:04.519+0900 D/AUL_AMD (  738): amd_request.c: __add_history_handler(333) > [SECURE_LOG] add rua history org.example.ex17 /opt/usr/apps/org.example.ex17/bin/ex17
02-25 20:19:04.519+0900 D/RUA     (  738): rua.c: rua_add_history(179) > rua_add_history start
02-25 20:19:04.529+0900 D/RUA     (  738): rua.c: rua_add_history(247) > rua_add_history ok
02-25 20:19:04.709+0900 D/AUL_PAD ( 8645): launchpad_loader.c: main(556) > sleeping 1 sec...
02-25 20:19:04.709+0900 D/AUL_PAD ( 8645): preload.h: __preload_init(52) > max_cmdline_size = 1053
02-25 20:19:04.729+0900 D/AUL_PAD ( 8645): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8dc6768
02-25 20:19:04.729+0900 D/AUL_PAD ( 8645): preload.h: __preload_init(69) > get pre-initialization function
02-25 20:19:04.729+0900 D/AUL_PAD ( 8645): preload.h: __preload_init(73) > get shutdown function
02-25 20:19:04.729+0900 D/AUL_PAD ( 8645): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8dc6a48
02-25 20:19:04.749+0900 D/AUL_PAD ( 8645): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8dc8538
02-25 20:19:04.749+0900 D/AUL_PAD ( 8645): preload.h: __preload_init(69) > get pre-initialization function
02-25 20:19:04.749+0900 D/AUL_PAD ( 8645): preload.h: __preload_init(73) > get shutdown function
02-25 20:19:04.749+0900 D/AUL_PAD ( 8645): preexec.h: __preexec_init(76) > preexec start
02-25 20:19:04.749+0900 D/AUL_PAD ( 8645): launchpad_loader.c: main(567) > [candidate] Another candidate process was forked.
02-25 20:19:04.749+0900 D/AUL     ( 8645): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
02-25 20:19:04.749+0900 D/AUL     ( 8645): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
02-25 20:19:04.749+0900 D/AUL     ( 8645): process_pool.c: __connect_to_launchpad(132) > send(8645) : 4
02-25 20:19:04.749+0900 D/AUL_PAD (  871): launchpad.c: main(619) > pfds[LAUNCH_PAD].revent  : 0x0
02-25 20:19:04.749+0900 D/AUL_PAD (  871): launchpad.c: main(621) > pfds[POOL_TYPE + 0].revents : 0x1
02-25 20:19:04.749+0900 D/AUL_PAD (  871): launchpad.c: main(622) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-25 20:19:04.749+0900 D/AUL_PAD (  871): launchpad.c: main(621) > pfds[POOL_TYPE + 1].revents : 0x0
02-25 20:19:04.749+0900 D/AUL_PAD (  871): launchpad.c: main(622) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-25 20:19:04.749+0900 D/AUL_PAD (  871): launchpad.c: main(621) > pfds[POOL_TYPE + 2].revents : 0x0
02-25 20:19:04.749+0900 D/AUL_PAD (  871): launchpad.c: main(622) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
02-25 20:19:04.749+0900 D/AUL_PAD (  871): launchpad.c: main(661) > pfds[POOL_TYPE + 0].revents & POLLIN
02-25 20:19:04.749+0900 D/AUL_PAD (  871): launchpad.c: main(673) > [SECURE_LOG] Type 0 candidate process was connected, pid: 8645
02-25 20:19:04.749+0900 D/AUL     ( 8645): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
02-25 20:19:04.939+0900 D/STARTER (  838): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb8cc36a8), lock_pid(-1)
02-25 20:19:04.939+0900 E/STARTER (  838): window_mgr.c: window_mgr_set_effect(239) > [window_mgr_set_effect:239] (ret != 1) -> window_mgr_set_effect() return
02-25 20:19:05.020+0900 D/AUL_PAD ( 8645): launchpad_loader.c: main(607) > [candidate] elm init, returned: 1
02-25 20:19:05.050+0900 D/AUL_PAD ( 8645): launchpad_loader.c: main(654) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
02-25 20:19:05.050+0900 D/AUL_PAD ( 8645): launchpad_loader.c: main(669) > [candidate] ecore handler add
02-25 20:19:05.050+0900 D/AUL_PAD ( 8645): launchpad_loader.c: main(683) > [candidate] ecore main loop begin
02-25 20:19:08.673+0900 D/APP_CORE(  845): appcore-efl.c: __appcore_memory_flush_cb(379) > [__SUSPEND__]
02-25 20:19:08.673+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(472) > [APP 845] Event: MEM_FLUSH State: PAUSED
02-25 20:19:08.673+0900 D/APP_CORE(  845): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__] flush case
02-25 20:19:08.673+0900 D/APP_CORE(  845): appcore.c: _appcore_request_to_suspend(528) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 845
02-25 20:19:08.673+0900 D/APP_CORE(  845): appcore-efl.c: __appcore_efl_prepare_to_suspend(357) > [__SUSPEND__]
02-25 20:19:08.673+0900 D/RESOURCED(  988): proc-monitor.c: proc_dbus_suspend_hint(1064) > [proc_dbus_suspend_hint,1064] received susnepd hint : pid 845
02-25 20:19:10.715+0900 D/eventsystem(  705): eventsystem.c: eventsystem_send_system_event(1032) > event_name(tizen.system.event.battery_level_status)
02-25 20:19:10.715+0900 D/eventsystem(  705): eventsystem.c: __get_member_name_from_eventname(269) > member_name(battery_level_status)
02-25 20:19:10.715+0900 D/eventsystem(  705): eventsystem.c: eventsystem_send_event(861) > interface_name(tizen.system.event)
02-25 20:19:10.715+0900 D/eventsystem(  705): eventsystem.c: eventsystem_send_event(862) > object_path(/tizen/system/event)
02-25 20:19:10.715+0900 D/eventsystem(  705): eventsystem.c: eventsystem_send_event(863) > member_name(battery_level_status)
02-25 20:19:10.725+0900 I/RESOURCED(  988): logging-battery.c: logging_battery_add_capacity(1087) > [logging_battery_add_capacity,1087] 68 -> 69 1456399150 340 340149
02-25 20:19:10.725+0900 I/RESOURCED(  988): logging-battery.c: logging_battery_calculate_prediction(1057) > [logging_battery_calculate_prediction,1057] TimeToFull: 69 244 334 126
02-25 20:19:10.725+0900 I/RESOURCED(  988): logging-battery.c: logging_battery_calculate_prediction(1057) > [logging_battery_calculate_prediction,1057] TimeToFull: 69 0 0 120
02-25 20:19:10.725+0900 I/RESOURCED(  988): logging-battery.c: logging_battery_calculate_prediction(1057) > [logging_battery_calculate_prediction,1057] TimeToFull: 69 213 657 110
02-25 20:19:10.725+0900 I/RESOURCED(  988): logging-battery.c: logging_battery_calculate_prediction(1057) > [logging_battery_calculate_prediction,1057] TimeToFull: 69 288 5 149
02-25 20:19:10.725+0900 I/RESOURCED(  988): logging-battery.c: logging_battery_calculate_prediction(1057) > [logging_battery_calculate_prediction,1057] TimeToFull: 69 344 20 178
02-25 20:19:10.725+0900 D/RESOURCED(  988): logging-battery.c: logging_battery_add_capacity(1173) > [logging_battery_add_capacity,1173] battery_logging_capacity_write 69 diff_capacity 1, used time 0, charging time 340149, charger status 1, reset_mark 1
02-25 20:19:10.725+0900 D/INDICATOR(  805): battery.c: indicator_battery_update_display(606) > indicator_battery_update_display[606]	 "Battery Capacity: 69"
02-25 20:19:10.725+0900 D/INDICATOR(  805): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.battery.percentage.two.digits.show"
02-25 20:19:10.725+0900 D/INDICATOR(  805): battery.c: hide_digits(487) > hide_digits[487]	 "Hide digits"
02-25 20:19:10.725+0900 E/INDICATOR(  805): list.c: list_try_to_find_icon_to_remove(335) > (!icon) -> list_try_to_find_icon_to_remove() return
02-25 20:19:10.725+0900 D/INDICATOR(  805): box.c: box_get_enabled_system_count(654) > Noti count : 1 , MiniCtrl count : 0
02-25 20:19:10.725+0900 D/INDICATOR(  805): box.c: box_get_enabled_system_count(654) > Noti count : 1 , MiniCtrl count : 0
02-25 20:19:10.725+0900 E/INDICATOR(  805): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
02-25 20:19:10.725+0900 D/INDICATOR(  805): box.c: box_get_minictrl_list(693) > Noti count : 1, System count : 1, Minictrl count : 3
02-25 20:19:10.725+0900 D/INDICATOR(  805): box.c: box_get_minictrl_list(693) > Noti count : 1, System count : 1, Minictrl count : 3
02-25 20:19:10.725+0900 E/INDICATOR(  805): list.c: list_try_to_find_icon_to_show(269) > default
02-25 20:19:10.725+0900 E/INDICATOR(  805): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
02-25 20:19:10.725+0900 D/INDICATOR(  805): box.c: box_get_enabled_noti_count(634) > box_get_enabled_noti_count[634]	 "System Count : 1, Minictrl Count : 0"
02-25 20:19:10.725+0900 D/INDICATOR(  805): box.c: box_get_enabled_noti_count(641) > box_get_enabled_noti_count[641]	 "Notification icon enabled_noti_cnt 4"
02-25 20:19:10.725+0900 D/INDICATOR(  805): box.c: box_get_enabled_noti_count(634) > box_get_enabled_noti_count[634]	 "System Count : 1, Minictrl Count : 0"
02-25 20:19:10.725+0900 D/INDICATOR(  805): box.c: box_get_enabled_noti_count(641) > box_get_enabled_noti_count[641]	 "Notification icon enabled_noti_cnt 4"
02-25 20:19:10.725+0900 E/INDICATOR(  805): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
02-25 20:19:10.725+0900 D/INDICATOR(  805): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.system.show"
02-25 20:19:10.725+0900 D/INDICATOR(  805): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.minictrl.hide"
02-25 20:19:10.725+0900 D/INDICATOR(  805): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.noti.show"
02-25 20:19:10.725+0900 E/INDICATOR(  805): box.c: _update_icon(172) > (!list) -> _update_icon() return
02-25 20:19:10.725+0900 E/INDICATOR(  805): box.c: _update_icon(172) > (!list) -> _update_icon() return
02-25 20:19:10.725+0900 D/INDICATOR(  805): box.c: box_get_right_item_count(242) > system cnt : 1, minictrl cnt : 0, noti cnt : 1
02-25 20:19:10.725+0900 D/INDICATOR(  805): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 2
02-25 20:19:10.725+0900 D/INDICATOR(  805): icon.c: _hide_more_noti(779) > port :: hide more icon
02-25 20:19:11.115+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:11.135+0900 D/CALL_MGR_CLIENT( 8591): <LIB:cm_init:339> cm_init
02-25 20:19:11.156+0900 D/CALL_MGR_CLIENT( 8591): <LIB:cm_get_call_status:1404> cm_get_call_status()
02-25 20:19:11.156+0900 D/CALL_MGR(  994): <__get_call_status_handler:674> __get_call_status_handler() is called
02-25 20:19:11.166+0900 D/CALL_MGR(  994): <_callmgr_util_check_access_control:104> sender: :1.294 pid = 8591
02-25 20:19:11.166+0900 W/CALL_MGR(  994): <_callmgr_util_check_access_control:108> pid(8591) access (callmgr::api_call - r) denied(-11)
02-25 20:19:11.166+0900 E/CALL_MGR_CLIENT( 8591): <LIB:cm_get_call_status:1422> g_dbus_conn failed. error (GDBus.Error:org.freedesktop.DBus.Error.AccessDenied: No access rights)
02-25 20:19:11.166+0900 E/CALL_MGR_CLIENT( 8591): <LIB:cm_get_call_status:1424> PERMISSION_DENIED
02-25 20:19:11.166+0900 D/CALL_MGR_CLIENT( 8591): <LIB:__cm_set_cb:272> noti_id: '/org/tizen/callmgr:org.tizen.callmgr:CallStatus'
02-25 20:19:11.166+0900 D/CALL_MGR_CLIENT( 8591): <LIB:__cm_set_cb:287> id = 1
02-25 20:19:11.296+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:11.446+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:11.686+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:11.686+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:12.457+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(423) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x3a00002
02-25 20:19:14.319+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:14.549+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:14.549+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:14.719+0900 D/RESOURCED(  988): logging.c: logging_send_signal_to_data(1060) > [logging_send_signal_to_data,1060] logging timer callback function start
02-25 20:19:14.719+0900 I/RESOURCED(  988): logging.c: logging_send_signal_to_data(1069) > [logging_send_signal_to_data,1069] send signal to logging data thread
02-25 20:19:14.719+0900 D/RESOURCED(  988): logging.c: logging_send_signal_to_update(1140) > [logging_send_signal_to_update,1140] logging timer callback function start
02-25 20:19:14.719+0900 I/RESOURCED(  988): logging.c: logging_send_signal_to_update(1149) > [logging_send_signal_to_update,1149] send signal to logging update thread
02-25 20:19:14.729+0900 I/RESOURCED(  988): logging.c: logging_save_to_storage(944) > [logging_save_to_storage,944] storage cache is empty
02-25 20:19:15.009+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:15.239+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:15.239+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:15.470+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:15.700+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:15.700+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:17.462+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(353) > [PROCESSMGR] last_pointed_win=0x6002c2 bd->visible=1
02-25 20:19:17.882+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:18.122+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:18.122+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:18.523+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:18.753+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:18.753+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:20.555+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:20.725+0900 D/eventsystem(  705): eventsystem.c: eventsystem_send_system_event(1032) > event_name(tizen.system.event.battery_level_status)
02-25 20:19:20.725+0900 D/eventsystem(  705): eventsystem.c: __get_member_name_from_eventname(269) > member_name(battery_level_status)
02-25 20:19:20.725+0900 D/eventsystem(  705): eventsystem.c: eventsystem_send_event(861) > interface_name(tizen.system.event)
02-25 20:19:20.725+0900 D/eventsystem(  705): eventsystem.c: eventsystem_send_event(862) > object_path(/tizen/system/event)
02-25 20:19:20.725+0900 D/eventsystem(  705): eventsystem.c: eventsystem_send_event(863) > member_name(battery_level_status)
02-25 20:19:20.775+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:20.775+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:20.875+0900 I/USS_FS  ( 1055): update_manager.c: update(1327) > [34m[1117]Starting update: iteration 1141[0m
02-25 20:19:20.875+0900 D/USS_FS  ( 1055): adaptor_client.c: unified_storage_refresh_internal_plugin_account_list(110) > [36m[1117]Refreshing internal account list[0m
02-25 20:19:20.875+0900 D/USS_FS  ( 1055): adaptor_client_account.c: unified_storage_service_adaptor_client_get_active_account_ids_list(640) > [32m[1117]Getting active account ids list[0m
02-25 20:19:20.875+0900 D/USS_FS  ( 1055): adaptor_client_account.c: unified_storage_service_adaptor_client_refresh_accounts_list(517) > [36m[1117]Refreshing accounts list[0m
02-25 20:19:20.875+0900 D/USS_FS  ( 1055): adaptor_client_account.c: _get_imsi_array(367) > [36m[1117]Get IMSI from usim[0m
02-25 20:19:20.875+0900 D/SERVICE_ADAPTOR_CLIENT( 1055): service_adaptor_client.c: service_adaptor_foreach_plugin(540) > [36m[1117][1m[30m>>>>>>>> Start
02-25 20:19:20.875+0900 D/SERVICE_ADAPTOR_CLIENT( 1055): service_adaptor_foreach_plugin[0m[0m
02-25 20:19:20.875+0900 D/SERVICE_ADAPTOR_CLIENT( 1055): dbus_client.c: _dbus_get_plugin_list(636) > [36m[1117][1m[30m>>>>>>>> Start
02-25 20:19:20.875+0900 D/SERVICE_ADAPTOR_CLIENT( 1055): _dbus_get_plugin_list[0m[0m
02-25 20:19:20.885+0900 D/SERVICE_ADAPTOR( 1078): dbus-server.c: method_call_async_func(612) > [32m[8651]Received dbus_01_get_auth_plugin_list() call[0m
02-25 20:19:20.885+0900 D/SERVICE_ADAPTOR( 1078): dbus-auth-adaptor.c: auth_adaptor_method_call(59) > [36m[8651][1m[32mStart >>auth_adaptor_method_call>>
02-25 20:19:20.885+0900 D/SERVICE_ADAPTOR( 1078): [0m[0m
02-25 20:19:20.885+0900 D/SERVICE_ADAPTOR( 1078): dbus-auth-adaptor.c: auth_adaptor_method_call(361) > [32m[8651][START] Get Auth Plugin List[0m
02-25 20:19:20.885+0900 D/SERVICE_ADAPTOR( 1078): dbus-auth-adaptor.c: auth_adaptor_method_call(366) > [36m[8651]hash table init (for sorting plugin list)[0m
02-25 20:19:20.885+0900 D/SERVICE_ADAPTOR( 1078): service-adaptor.c: service_adaptor_get_handle(83) > [32m[8651]Get adaptor handle[0m
02-25 20:19:20.885+0900 D/SERVICE_ADAPTOR( 1078): service-adaptor-auth.c: service_adaptor_get_auth_adaptor(32) > [32m[8651]Get auth adaptor[0m
02-25 20:19:20.885+0900 D/SERVICE_ADAPTOR( 1078): service-adaptor-storage.c: service_adaptor_get_storage_adaptor(170) > [32m[8651]Get storage adaptor[0m
02-25 20:19:20.885+0900 D/SERVICE_ADAPTOR( 1078): dbus-auth-adaptor.c: auth_adaptor_method_call(375) > [36m[8651]adaptors get. service_adaptor(0xb8b0cb68) auth_adaptor(0xb8b0c8d0) storage_adaptor(0xb8b0c9a8)[0m
02-25 20:19:20.885+0900 D/SERVICE_ADAPTOR( 1078): dbus-auth-adaptor.c: auth_adaptor_method_call(441) > [36m[8651]total plugin count (0)[0m
02-25 20:19:20.885+0900 D/SERVICE_ADAPTOR( 1078): dbus-auth-adaptor.c: auth_adaptor_method_call(450) > [32m[8651][End] Get Auth Plugin List[0m
02-25 20:19:20.885+0900 D/SERVICE_ADAPTOR( 1078): dbus-auth-adaptor.c: auth_adaptor_method_call(594) > [36m[8651][1m[36mEnd <<auth_adaptor_method_call<<
02-25 20:19:20.885+0900 D/SERVICE_ADAPTOR( 1078): [0m[0m
02-25 20:19:20.885+0900 D/SERVICE_ADAPTOR_CLIENT( 1055): dbus_client.c: _dbus_get_plugin_list(724) > [36m[1117][1m[30m<<<<<<<< End
02-25 20:19:20.885+0900 D/SERVICE_ADAPTOR_CLIENT( 1055): _dbus_get_plugin_list[0m[0m
02-25 20:19:20.885+0900 D/SERVICE_ADAPTOR_CLIENT( 1055): service_adaptor_client.c: service_adaptor_foreach_plugin(573) > [36m[1117][1m[30m<<<<<<<< End
02-25 20:19:20.885+0900 D/SERVICE_ADAPTOR_CLIENT( 1055): service_adaptor_foreach_plugin[0m[0m
02-25 20:19:20.885+0900 E/USS_FS  ( 1055): adaptor_client_account.c: unified_storage_service_adaptor_client_refresh_accounts_list(555) > [31m[1117]Plugin doesn't exist! error = -61[0m
02-25 20:19:20.885+0900 D/USS_FS  ( 1055): adaptor_client_account.c: unified_storage_service_adaptor_client_refresh_accounts_list(590) > [32m[1117]Account list refreshed[0m
02-25 20:19:20.885+0900 E/USS_FS  ( 1055): adaptor_client.c: unified_storage_refresh_internal_plugin_account_list(117) > [31m[1117]Could not refresh active accounts list[0m
02-25 20:19:20.885+0900 D/USS_FS  ( 1055): adaptor_client.c: unified_storage_refresh_internal_plugin_account_list(178) > [36m[1117]Internal account list refreshed successfully[0m
02-25 20:19:20.885+0900 D/USS_FS  ( 1055): update_manager.c: _unified_storage_adapter_update_account_handles(1057) > [36m[1117]Updating account handles ...[0m
02-25 20:19:20.885+0900 D/USS_FS  ( 1055): update_manager.c: _unified_storage_adapter_get_account_handles(932) > [36m[1117]Get account handles ..[0m
02-25 20:19:20.885+0900 D/USS_FS  ( 1055): update_manager.c: _unified_storage_adapter_get_account_handles(941) > [32m[1117]Get active accounts list.[0m
02-25 20:19:20.885+0900 D/USS_FS  ( 1055): adaptor_client.c: unified_storage_plugin_get_active_accounts_list(194) > [36m[1117]Let's get active accounts list ...[0m
02-25 20:19:20.885+0900 D/USS_FS  ( 1055): adaptor_client_account.c: unified_storage_service_adaptor_client_get_active_accounts_list(596) > [36m[1117]Getting active accounts list[0m
02-25 20:19:20.885+0900 D/USS_FS  ( 1055): adaptor_client_account.c: unified_storage_service_adaptor_client_get_active_accounts_list(634) > [36m[1117]Active account list retrieved[0m
02-25 20:19:20.885+0900 D/USS_FS  ( 1055): adaptor_client.c: unified_storage_plugin_get_active_accounts_list(200) > [36m[1117]Active account list successfully retrieved[0m
02-25 20:19:20.885+0900 D/USS_FS  ( 1055): update_manager.c: _unified_storage_adapter_get_account_handles(945) > [32m[1117]Empty accounts list.[0m
02-25 20:19:20.885+0900 D/USS_FS  ( 1055): update_manager.c: _unified_storage_adapter_get_account_handles(995) > [36m[1117]Account handles successfully retrieved[0m
02-25 20:19:20.885+0900 D/USS_FS  ( 1055): update_manager.c: unified_storage_adapter_clean_fs_for_deleted_accounts(1038) > [36m[1117]Clean FS for deleted accounts ...[0m
02-25 20:19:20.885+0900 D/USS_FS  ( 1055): update_manager.c: unified_storage_adapter_clean_fs_for_deleted_accounts(1051) > [36m[1117]Cleanup is finished[0m
02-25 20:19:20.885+0900 D/USS_FS  ( 1055): update_manager.c: _unified_storage_adapter_update_account_handles(1116) > [36m[1117]Account handles updated successfully[0m
02-25 20:19:20.885+0900 W/USS_FS  ( 1055): update_manager.c: update(1365) > [33m[1117]Empty account handles list. There is nothing to update.[0m
02-25 20:19:20.885+0900 I/USS_FS  ( 1055): update_manager.c: update(1368) > [34m[1117]Ending update: iteration 1141[0m
02-25 20:19:20.885+0900 I/USS_FS  ( 1055): update_manager.c: update(1370) > [1m[33m[PERFORMANCE] [1117] - elapsed time: 7 msec for Update total[0m
02-25 20:19:20.885+0900 I/USS_FS  ( 1055): update_manager.c: update(1377) > [34m[1117]Next update check after 60s[0m
02-25 20:19:21.205+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:21.466+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:21.466+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:21.666+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:21.896+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:21.896+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:24.408+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:24.649+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:24.649+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:25.830+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:26.080+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:26.080+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:26.350+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:26.581+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:26.581+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:29.624+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:29.874+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:29.874+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:30.625+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(423) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x3a00002
02-25 20:19:30.725+0900 D/eventsystem(  705): eventsystem.c: eventsystem_send_system_event(1032) > event_name(tizen.system.event.battery_level_status)
02-25 20:19:30.725+0900 D/eventsystem(  705): eventsystem.c: __get_member_name_from_eventname(269) > member_name(battery_level_status)
02-25 20:19:30.725+0900 D/eventsystem(  705): eventsystem.c: eventsystem_send_event(861) > interface_name(tizen.system.event)
02-25 20:19:30.725+0900 D/eventsystem(  705): eventsystem.c: eventsystem_send_event(862) > object_path(/tizen/system/event)
02-25 20:19:30.725+0900 D/eventsystem(  705): eventsystem.c: eventsystem_send_event(863) > member_name(battery_level_status)
02-25 20:19:31.736+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:31.956+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:31.956+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:32.616+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:32.867+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:32.867+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:34.779+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:34.999+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:34.999+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:35.349+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:35.569+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:35.569+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:35.629+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(353) > [PROCESSMGR] last_pointed_win=0x6002c2 bd->visible=1
02-25 20:19:36.881+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:37.101+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:37.101+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:38.002+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:38.242+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:38.242+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:39.914+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:40.164+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:40.164+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:40.664+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:40.734+0900 D/eventsystem(  705): eventsystem.c: eventsystem_send_system_event(1032) > event_name(tizen.system.event.battery_level_status)
02-25 20:19:40.734+0900 D/eventsystem(  705): eventsystem.c: __get_member_name_from_eventname(269) > member_name(battery_level_status)
02-25 20:19:40.734+0900 D/eventsystem(  705): eventsystem.c: eventsystem_send_event(861) > interface_name(tizen.system.event)
02-25 20:19:40.734+0900 D/eventsystem(  705): eventsystem.c: eventsystem_send_event(862) > object_path(/tizen/system/event)
02-25 20:19:40.734+0900 D/eventsystem(  705): eventsystem.c: eventsystem_send_event(863) > member_name(battery_level_status)
02-25 20:19:40.895+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:40.895+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:41.235+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:41.465+0900 E/EFL     ( 8591): edje<8591> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p18';
02-25 20:19:41.465+0900 E/EFL     ( 8591): By the power of Grayskull, your previous Embryo stack is now broken!
02-25 20:19:47.341+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(483) > [PROCESSMGR] ev_win=0x600035  register trigger_timer!  pointed_win=0x6002c2 
02-25 20:19:47.341+0900 I/ex17    ( 8591): start calculate
02-25 20:19:47.341+0900 I/ex17    ( 8591):  (  (  ( 2 -3 )  *4 +5 - (  -1 +2 )  )  *6 )  /2
02-25 20:19:47.351+0900 I/ex17    ( 8591): 2-3|*4+5|-1+2|-|*6|/2|
02-25 20:19:47.351+0900 I/ex17    ( 8591): program start info 4 > 4 : 9 > 4 : 14 result : 
02-25 20:19:47.351+0900 I/ex17    ( 8591): 2-3|1.000000000|*6|/2|
02-25 20:19:47.351+0900 I/ex17    ( 8591): program start info 16 > 2 : 19 > 2 : 21 result : 
02-25 20:19:47.351+0900 I/ex17    ( 8591): 2-3|1.000000000|0.0000
02-25 20:19:48.342+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(423) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x3a00002
02-25 20:19:50.734+0900 D/eventsystem(  705): eventsystem.c: eventsystem_send_system_event(1032) > event_name(tizen.system.event.battery_level_status)
02-25 20:19:50.734+0900 D/eventsystem(  705): eventsystem.c: __get_member_name_from_eventname(269) > member_name(battery_level_status)
02-25 20:19:50.734+0900 D/eventsystem(  705): eventsystem.c: eventsystem_send_event(861) > interface_name(tizen.system.event)
02-25 20:19:50.734+0900 D/eventsystem(  705): eventsystem.c: eventsystem_send_event(862) > object_path(/tizen/system/event)
02-25 20:19:50.734+0900 D/eventsystem(  705): eventsystem.c: eventsystem_send_event(863) > member_name(battery_level_status)
02-25 20:19:51.895+0900 E/E17     (  563): e_border.c: _e_border_cb_ping_poller(15522) > [ANR] - 1 time no response, org.example.ex17(8591,0x3a00002)
02-25 20:19:51.895+0900 E/E17_EXTRA_MODULES(  563): e_mod_anr.c: _e_anr_dbus_msg_send(97) > [ANR][_e_anr_dbus_msg_send] send dbus msg to resourced for 8591
02-25 20:19:51.905+0900 E/RESOURCED(  988): proc-monitor.c: edbus_signal_trigger(751) > [edbus_signal_trigger,751] Receive watchdog signal to pid: 8591(ex17)
02-25 20:19:53.337+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(353) > [PROCESSMGR] last_pointed_win=0x6002c2 bd->visible=1
02-25 20:19:53.337+0900 D/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(358) > [PROCESSMGR] pointed_win=0x6002c2 is not response!
02-25 20:19:53.337+0900 E/PROCESSMGR(  563): e_mod_processmgr.c: _e_mod_processmgr_dbus_msg_send(306) > [PROCESSMGR] pointed_win=0x3a00002 Send kill command to the ResourceD! PID=8591
02-25 20:19:53.347+0900 E/RESOURCED(  988): proc-monitor.c: proc_dbus_watchdog_handler(652) > [proc_dbus_watchdog_handler,652] Receive watchdog signal to pid: 8591(ex17)
02-25 20:19:53.347+0900 E/RESOURCED(  988): proc-monitor.c: proc_dbus_watchdog_handler(660) > [proc_dbus_watchdog_handler,660] just kill watchdog process when debug enabled pid: 8591(ex17)
02-25 20:19:53.347+0900 D/RESOURCED(  988): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] [cgroup_write_node,134] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 8591
02-25 20:19:53.347+0900 D/RESOURCED(  988): freezer-process.c: freezer_process_pid_set(392) > [freezer_process_pid_set,392] freezer_process_pid_set 8591
02-25 20:19:53.467+0900 E/EFL     (  563): eo<563> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (413) could not be resolved for class 'Evas_Object_Smart'.
02-25 20:19:53.477+0900 D/AUL_PAD (  871): launchpad.c: main(619) > pfds[LAUNCH_PAD].revent  : 0x0
02-25 20:19:53.477+0900 D/AUL_PAD (  871): launchpad.c: main(621) > pfds[POOL_TYPE + 0].revents : 0x0
02-25 20:19:53.477+0900 D/AUL_PAD (  871): launchpad.c: main(622) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
02-25 20:19:53.477+0900 D/AUL_PAD (  871): launchpad.c: main(621) > pfds[POOL_TYPE + 1].revents : 0x0
02-25 20:19:53.477+0900 D/AUL_PAD (  871): launchpad.c: main(622) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
02-25 20:19:53.477+0900 D/AUL_PAD (  871): launchpad.c: main(621) > pfds[POOL_TYPE + 2].revents : 0x0
02-25 20:19:53.477+0900 D/AUL_PAD (  871): launchpad.c: main(622) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
02-25 20:19:53.477+0900 I/AUL_PAD (  871): sigchild.h: __launchpad_process_sigchld(160) > dead_pid = 8591 pgid = 8591
02-25 20:19:53.477+0900 I/AUL_PAD (  871): sigchild.h: __sigchild_action(141) > dead_pid(8591)
02-25 20:19:53.487+0900 W/CRASH_MANAGER( 8655): worker.c: worker_job(1204) > 0608591657831145639919
