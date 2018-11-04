@echo off


set BUILD_TYPE=%1

if not "%BUILD_TYPE%" == "Debug" (
	echo Building in Release mode.
	set BUILD_TYPE=Release
) else (
	echo Building in Debug mode.
)

WHERE msbuild
if %ERRORLEVEL% NEQ 0 (
	echo ### ERROR: Run Developer Command Prompt for VS and try again. ###
) else (
	cd /d %~dp0
	cd src
	msbuild /t:Rebuild /m /p:Configuration=%BUILD_TYPE% /p:BuildInParallel=true /p:Platform="Any CPU"
	cd ..
)