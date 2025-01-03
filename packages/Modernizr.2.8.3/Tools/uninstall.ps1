<<<<<<< HEAD
param($installPath, $toolsPath, $package, $project)

. (Join-Path $toolsPath common.ps1)

# Update the _references.js file
=======
param($installPath, $toolsPath, $package, $project)

. (Join-Path $toolsPath common.ps1)

# Update the _references.js file
>>>>>>> a6e55f2 (buoi3)
Remove-Reference $scriptsFolderProjectItem $modernizrFileNameRegEx