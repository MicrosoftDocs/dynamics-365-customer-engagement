---
title: "Dynamics 365 Manually overwrting sample website | MicrosoftDocs"
description: "Provides information about how you can manually overwrite event management sample website."
ms.custom:
  - dyn365-developer
  - dyn365-marketing
ms.date: 13/05/2019
ms.service: dynamics-365-marketing
ms.technology: 
  - "marketing"
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
author: tohomanms
ms.author: tohomanms
manager: dariosap
---

# Manually overwriting sample website 

The standard process of updating Event Management website is to download a fresh version of the website and then use the provided script to push the changes to the CRM instance, as described [here](portal-hosted.md). Usually that is enough, but there are situations when it is not possible to simply push the new website definition because of some changes to the underlying portal web pages. Namely if you are using Dynamics 365 Portals hosted version of the Event Management website then portal web pages, web templates and web files are actually used to host the compiled website. If we make the changes to those infrastructural entities you need to manually update them. We don't update them automatically from version to version because of possible customer customizations made on them that we don't want to break. 

The set of web pages, web templates and web files that is needed for the Event Management website to work is packed in a CRM sample data format inside of the zip archive. It's a standard format that can be imported to the CRM instance using [The Configuration Migration tool](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/admin/import-configuration-data). 

As those entities differ from version to version, we provide a separate zip for every Event Management release. To get an archive that corresponds to your current Event Management version you need to find out what Event Management solution do you currently have installed on your CRM instance. In order to do that, please open your CRM instance and go to the settings > solutions section. Note which **MicrosoftDynamics_EventManagement** solution version you have. If the version is 1.12.1006 then you need to do one extra step and that is to search for **MicrosoftDynamics_EventManagement_patch** solution and if it exists note that version and use it to download corresponding archive. Refer to the following table to download appropriate zip file containing data. If the build number differs from the one in the table, for example 1.12.2326 instead of 1.12.2327, you can still use the the archive having corresponding major and minor version, so for this case you can still use 1.12.2327 archive.

Note that manually overwriting Event Management website will overwrite possible customizations you made on the website, so be careful to have those customizations in a repository outside of CRM instance. After overwriting the website files, you can use standard `DeployToDynamics365Instance.ps1` script to bring your customizations back to the CRM instance.

| Release ||
|--|--|
| 1.12.2327 (April 2019 Release) | [Download](http://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/PortalData-Apr19-1.12.2327.zip) |
| 1.12.1006 (March 2019 Release) | [Download](http://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/PortalData-Mar19-1.12.1006.zip) |
| 1.11.1005 (February 2019 Release) | [Download](http://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/PortalData-Feb19-1.11.1005.zip) |
| 1.10.1008 (December 2018 Release) | [Download](http://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/PortalData-Dec18-1.10.1008.zip) |
| 1.9.1014 (November 2018 Release) | [Download](http://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/PortalData-Nov18-1.9.1014.zip) |
| 1.8.1010 (October 2018 Release) | [Download](http://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/PortalData-Oct18-1.8.1010.zip) |
| 1.7.1007 (September 2018 Release) | [Download](http://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/PortalData-Sep18-1.7.1007.zip) |
| 1.6.1002 (August 2018 Release) | [Download](http://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/PortalData-Aug18-1.6.1002.zip) |
| 1.5.1006 (July 2018 Release) | [Download](http://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/PortalData-Jul18-1.5.1006.zip) |
| 1.4.1006 (May 2018 Release) | [Download](http://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/PortalData-May18-1.4.1006.zip) |
| 1.3.1021 (April 2018 Release) | [Download](http://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/PortalData-Apr18-1.3.1021.zip) |
| 1.2.1016 (March 2018 Release) | [Download](http://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/PortalData-Mar18-1.2.1016.zip) |
| 1.1.1006 (February 2018 Release) | [Download](http://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/PortalData-Feb18-1.1.1006.zip) |
| 1.0.1005 (Public Preview) | [Download](http://download.microsoft.com/download/1/5/0/150757D0-2600-493B-8C9A-3213AD873A73/PortalData-PublicPreview-1.0.1005.zip) |
