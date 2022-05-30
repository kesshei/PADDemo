@echo off

echo ====================================================================================================
set signpath=custom-modules

for /r %signpath% %%i in (*) do (signtool sign /f 蓝创精英团队.pfx /p 123456 %%i
signtool timestamp /t http://time.certum.pl %%i)
echo ====================================================================================================


echo.
echo 文件目录 "%signpath%" 下都已被签名过了，请注意查看!
pause>nul