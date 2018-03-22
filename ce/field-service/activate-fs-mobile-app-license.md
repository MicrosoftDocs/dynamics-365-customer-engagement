---
title: "Field Service Mobile App User’s Guide (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "activate-fs-mobile-app-license"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "mduelae"
ms.assetid: 49207db9-d1f0-46e0-ae2c-f4acf4593da9
caps.latest.revision: 24
ms.author: "krbjoran"
manager: "shellyha"
---
# Activate Field Service mobile app license

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

This information is intended for customers who have a license for Microsoft Dynamics 365 for Field Service and need to activate the licenses for the Field Service mobile app. Customers who do not have Field Service installed will need to follow a different process to obtain Field Service mobile app trial licenses.

When a customer purchases a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] licenses that include access to Field Service, receive corresponding licenses to the Field Service mobile app, at a one-to-one ratio, at no extra charge.
The Field Service mobile app license is a restricted license that is primarily intended for Field Service functionality. See the EULA for details.

The available Field Service mobile app licenses needs to be applied to, or activated for, the customer’s Dynamics 365 instances, separately from assigning [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] licenses to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] users.
The Field Service mobile app can be configured and modified using the Woodford solution. More information:  [See instructions for installing the Woodford solution](https://go.microsoft.com/fwlink/?LinkId=789382).

Once the Woodford solution is installed into a [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] org, there is a 30-day trial period that begins. When that trial period expires, you will not be able to access the Woodford configuration tool for that org, until your paid licenses are allocated to it. So, it is recommended that you begin this activation process at least a few weeks before the trial period ends.

It is important to note that the Field Service mobile app licenses, that a customer is entitled to, are intended to be allocated, and spread out between, the various production and sandbox [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] instances that the customer wants them in. Unlike Dynamics 365 web client licenses, a Field Service mobile app license can only be allocated to one [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] org at a time, based on the Org ID of the instance. For example, if a customer is entitled to 100 Field Service mobile app licenses, they may choose to assign 85 to their production org, and divide the remaining 15 between their dev and test orgs. 

Additionally, if an Org is restored or rebuilt, the Org ID may change, and the Field Service mobile licenses will need to be re-allocated to the new Org ID.

## Allocate Field Service mobile licenses to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] organizations
1. Go to the [Microsoft support page](https://go.microsoft.com/fwlink/?linkid=854120).
2. For Problem Type choose, FieldOne Licensing and for Category choose License Request, then click Start Request.
3. Enter your contact information and click Continue.
4. For Incident Title, enter Field Service App Mobile License Activation Request.
In the Tell us more about your issue box, enter the following information:
	- Customer company name
	- Customer's public facing website
	- Requesting person's full name
	- Requesting Person's Email Address
	- Requesting Person's phone Number
	- Office 365 Admin Center License screenshot showing the number of Field Service licenses in your tenant. Here's how to get this info:
		- As a Global Office 365 Administrator, open your Office 365 portal and navigate to the Admin Center.
		- Expand the Billing tab, and click on Licenses.
		- Take a screenshot showing the number of field service licenses in your tenant. 
		![Write some descriptive alt text here](../field-service/name_of_file_in_github_DO_NOT_USE_SPACES_EVER_K_THX.jpeg "Title of image")  
	- Enter your unique org ID. Here's how to find your org ID:
		- As a system Administrator, open your Dynamics 365 instance. 
		- Navigate to Settings > Customizations >Developer Resources.
		- In the Instance Reference Information section of the page, locate the Org ID.
		![Write some descriptive alt text here](../field-service/name_of_file_in_github_DO_NOT_USE_SPACES_EVER_K_THX.jpeg "Title of image")  

> [!NOTE]
>  You can enter the below information in the space provided, or in the space below enter “see attached” and save the information to an Excel document and upload it with the service request. For example, create a table in Excel as shown in the screenshot below.
> ![Screenshot of the Excel table with the information below prepopulated](../field-service/name_of_file_in_github_DO_NOT_USE_SPACES_EVER_K_THX.jpeg "Excel spreadhseet example")
> If you have more than one instance that you need Resco mobile licenses for, make sure to include the org ID for each instance, including the number of mobile licenses needed for each instance. 
 

