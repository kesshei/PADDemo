@echo off

echo ====================================================================================================
set signpath=custom-modules

for /r %signpath% %%i in (*) do (signtool sign /f ������Ӣ�Ŷ�.pfx /p 123456 %%i
signtool timestamp /t http://time.certum.pl %%i)
echo ====================================================================================================


echo.
echo �ļ�Ŀ¼ "%signpath%" �¶��ѱ�ǩ�����ˣ���ע��鿴!
pause>nul