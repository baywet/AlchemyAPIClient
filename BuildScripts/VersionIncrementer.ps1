param([String]$versionName="AssemblyFileVersion",[String]$matchingPattern="*AssemblyInfo.cs",[String]$excludePattern="")
function getCleanBuildNumber()
{
	$regex = [Regex]"(?<buildnumber>\d{1,4}\.\d{1,4}\.\d{1,4}\.\d{1,4})";
	$match = $regex.Match($Env:BUILD_BUILDNUMBER);
	return $match.Groups["buildnumber"].Value;
}
$buildNumber = getCleanBuildNumber;
$regexPattern = '\[assembly:\s+' + $versionName + '\(\"(?<buildnumber>\d{1,4}\.\d{1,4}\.\d{1,4}\.\d{1,4})\"\)\]';
$assemblyFiles = get-childitem -Filter $matchingPattern -Recurse;
$targetVersionInfo = '[assembly: ' + $versionName + ' ("'+$buildNumber+'")]';
foreach($assemblyFile in $assemblyFiles)
{
	if(!$excludePattern -or ($excludePattern -and $assemblyFile.Directory -notmatch $excludePattern))
	{
		$content = get-content $assemblyFile.FullName;
		if($content -match $regexPattern)
		{
			($content -replace $regexPattern, $targetVersionInfo) | Out-File -FilePath $assemblyFile.FullName -Verbose -Encoding utf8;
		}
	}
}