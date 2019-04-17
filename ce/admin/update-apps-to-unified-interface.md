---
title: "Update your apps to Unified Interface | MicrosoftDocs"
ms.custom: 
ms.date: 03/21/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 8c34ccb0-333f-4e03-8faa-e241dbadbbba
caps.latest.revision: 1
author: prsi-msft
ms.author: prsi
manager: jimholtz
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
  - PowerApps
---
# Update your apps to Unified Interface

When you enable Unified Interface Only, all your apps, including those designed for the legacy web client, run in Unified Interface all the time. Environments with legacy web client apps will show a notification on the Apps home page, prompting System Administrators to update those apps to Unified Interface, as shown below:

"You are using apps designed for the legacy web client. For best results, update your apps to Unified Interface."

> [!div class="mx-imgBorder"] 
> ![Message: using apps designed for legacy web client](media/message-using-app-legacy-web-client.png "Message: using apps designed for legacy web client")

A similar notification will be visible to System Administrators whenever they use an app designed for the legacy web client, as shown below:

"This app is designed for the legacy web client and might have features or customizations that aren't supported in Unified Interface. For best results, update it to Unified Interface."

> [!div class="mx-imgBorder"] 
> ![Message: using apps designed for legacy web client](media/message-app-designed-legacy-web-client.png "Message: using apps designed for legacy web client")

The following are recommended ways to update to Unified Interface based on how the apps were installed in the environment.

## Apps created in your Sandbox environment

- Be sure to import the changes in your target environment via a managed solution only. See [Import, update, and export solutions](https://docs.microsoft.com/en-us/powerapps/maker/common-data-service/import-update-export-solutions) for guidance on installing an update to an existing managed solution.
- Modify the app properties by following the steps detailed in [Manage app properties](https://docs.microsoft.com/en-us/powerapps/maker/model-driven-apps/manage-app-properties), and set the **Client** type to **Unified Interface**
- Import the changes to your target environment via a managed solution update.

## Apps installed from AppSource

- Contact the app publisher and get a new version that updates the apps to Unified Interface.

## Apps obtained from an ISV or any other third party publisher

- Contact the ISV (Independent Software Vendor) or the third party app publisher and get a new version that updates the apps to Unified Interface.


