---
title: "Step 3: Create an AppSource package for your app (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "App builders must be memebers of Microsoft Partner Network (MPN) to publish apps on AppSource."
ms.custom: ""
ms.date: 12/15/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 64ca3ef3-0bfe-4c92-8f28-fb8b61ecb6c0
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Step 3: Create an AppSource package for your app

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

You must create an AppSource package, a compressed .zip file, to bundle your solution and demo data files along with other required files. An app source package consists of the following files:

|File|Description|
|--|--|
|Package file|A package file used by Package Deployer tool to deploy your solutions and demo configuration data into multiple languages.|
|[Content_Types].xml|File that provides MIME type information of the file type extensions of the files included in the AppSource package. Typically, these are .dll, .xml, .exe, and .config file types, but you can add almost any file type that iss supported by Windows.|
|input.xml|Files that describes the assets in your AppSource package.|
|32x32 logo png file|An image file for the solution icon; size should be 32x32 pixels.|
|html file|HTML file containing your License terms.|


## Create a Package file

Create a Dynamics 365 package for the Package to include the solution and configuration data files that you created in [Step 2: Create a managed solution for your app](create-solution-app-appsource.md). A package can also contain custom code that can run before, while, or after the package is deployed to the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instance. For more information about creating a package file, see [Create packages for the Dynamics 365 Package Deployer](create-packages-package-deployer.md).

After you have created a package, your package will consist of the following things:

- **\<PackageName> folder**: This folder contains  all solutions,  configuration data, flat files, and the contents for your package. For example: *PkgFolder*.  
  
- **\<PackageName>.dll**: The assembly contains the custom code for your package. For example: *SamplePackage.dll*.

Next, create a **[Content_Types].xml** file that provides MIME type information of the file type extensions that are included in your package. This is separate from the one that will be included again in the AppSource package. Here is the sample contents of a Content_Types].xml file with file types listed:

```xml
<?xml version="1.0" encoding="utf-8"?>
<Types xmlns="http://schemas.openxmlformats.org/package/2006/content-types">
  <Default Extension="xml" ContentType="application/octet-stream" />
  <Default Extension="xaml" ContentType="application/octet-stream" />
  <Default Extension="dll" ContentType="application/octet-stream" />
  <Default Extension="zip" ContentType="application/octet-stream" />
  <Default Extension="jpg" ContentType="application/octet-stream" />
  <Default Extension="gif" ContentType="application/octet-stream" />
  <Default Extension="png" ContentType="application/octet-stream" />
  <Default Extension="htm" ContentType="application/octet-stream" />
  <Default Extension="html" ContentType="application/octet-stream" />
  <Default Extension="db" ContentType="application/octet-stream" />
  <Default Extension="css" ContentType="application/octet-stream" />
</Types>
```

Finally, compress (zip) the following files into a file called *package.zip*:
- package folder (*PkgFolder*)
- package dll (*SamplePackage.dll*)
- *[Content_Types].xml*

To compress these files, browse to the folder where these files are present, select them all, right-click and select **Send to** > **Compressed (zipped) folder**.

![Zip the files for a package](media/appsource-zip-package.png) 

Rename the .zip file to *package.zip*.

## Create [Content_Types].xml

You can reuse the *[Content_Types].xml* that you created in the previous step.

## Create input.xml file

Create an *input.xml* file that provides information your package as explained below. Each element in the XML file is explained later in the table:

```xml
<?xml version="1.0" encoding="utf-8"?>
<PvsPackageData>
  <ProviderName>Microsoft</ProviderName>
  <PackageFile>package.zip</PackageFile>
  <SolutionAnchorName>SampleSolution.zip</SolutionAnchorName>
  <StartDate>12/01/2017</StartDate>
  <EndDate>01/01/2021</EndDate>
  <SupportedCountries>US,CA</SupportedCountries>
  <LearnMoreLink>http://www.microsoft.com</LearnMoreLink>
  <Locales>
    <PackageLocale Code="1033" IsDefault="true">
      <Logo>logo32x32.png</Logo>
      <Terms>
        <PackageTerm File="TermsOfUse.html" />
      </Terms>
    </PackageLocale>
  </Locales>
</PvsPackageData>
```

|Element|Description|
|--|--|

> [!div class="nextstepaction"]
> [Create and manage VM disks](https://docs.microsoft.com/en-us/azure/virtual-machines/linux/tutorial-manage-disks) 
  

