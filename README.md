# DependAppInstaller
 Automatically installs all the files that you deem important

<p>This is a project made for lazy people, who reinstall their OS every once in a while. Could be because of hack development, security testing, or any other thing.</p>

## What is this for?
<p>This tool will automatically install all kinds of files automatically (except any compressed files <b>.rar, .zip, ...</b>)</p>

## Includes
- Bad code (30 minute project)
- Somewhat sufficient exception handling
- Some comments

## How to use?
### Compiling
#### Prerequisites
Microsoft Visual Studio 2022 alongside with Windows SDK

#### Compiling from source
Open 'DependAppInstaller.sln' in Visual Studio 2022, set build configuration to Debug/Release | Any CPU, Build->Build Solution and DependAppInstaller.exe will be created.


### Add packages
<p>To add packages, you will need to create new CheckBoxes. You do not need to change the <b>(Name)</b>, the only thing you need to change is the <b>"Text" associated with the control</b> and set the <b>"CheckedChanged" event to "selectionCheckBox"</b>.</p>
<p>Once you have your control set up, go to the "<b>installPackages()</b>" function in Form1.cs, and add your package in the switch statement</p>

<p>e.g.</p>

```cpp
switch (check.Text)
{
// This is what we had
 case "Visual Studio 2022":
  installPackage("https://c2rsetup.officeapps.live.com/c2r/downloadVS.aspx?sku=community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030:8bf9b352f8cf44d285d2dd7cc9287733", check.Text, "exe");
  break;
 case "IDA Pro":
  installPackage("link", check.Text, "zip");
  break;
//

// This is what we added
 case "Google Chrome":
  installPackage("Direct link to Google Chrome", check.Text, "exe");
  break;
//
}
```

## To-do (maybe):
- Improve the readability of the code
- Make easier to use
- Add compressed file support
