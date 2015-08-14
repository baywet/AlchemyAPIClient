param([String]$ApiKey)

$configPath = Resolve-Path "..\AlchemyAPIClient.UnitTest\App.config";
$regexPattern = '<add\s?key="AlchemyEndPointKey"\s?value=".*"\s?/>';
$targetSetting = '<add key="AlchemyEndPointKey" value="'+$ApiKey+'" />';
((get-content $configPath) -replace $regexPattern, $targetSetting) | set-content $configPath -Verbose;