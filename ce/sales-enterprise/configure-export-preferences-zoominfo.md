---
title: "Configure export preferences for ZoomInfo app (Dynamics 365 Sales) | MicrosoftDocs"
description: "Use the export preference to choose which record types to export and limit the number of records to export in each record type."
ms.date: 07/05/2021
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Configure export preferences

As an administrator, you can configure the export preference to choose which record types (accounts, contacts, and leads) to export and limit the number of records that you can export in each record type. Also, you can configure to create new record, allow record duplicate creation, and update existing records for each record type.   

## Prerequisites
Before you start, be sure you have met the following prerequisites:
-	You must have the system administrator role. More information: [Assign a security role to a user](/power-platform/admin/create-users-assign-online-security-roles#assign-a-security-role-to-a-user).   
-	The ZoomInfo app is installed on your Dynamics 365 Sales organization. More information: [Install ZoomInfo app](install-zoominfo-app.md).   
-	A license to use the ZoomInfo app.

## Configure the preferences   
1.	Sign in to Dynamics 365 environment and open the ZoomInfo app.    
2.	On the left navigation pane, select **ZoomInfo** > **ZoomInfo**.   
    >[!NOTE]
    >The app might prompt you to enter credentials. Select either Google, Office, or enter your ZoomInfo credentials if you have an account with ZoomInfo.  

    > [!div class="mx-imgBorder"]
    > ![ZoonInfo sign in page](media/zoominfo-login-page.png "ZoonInfo sign in page")
     
3.	On the top right corner of the page, select **More** > **Admin Portal**.
4.	On the **Admin Portal** page, select **Dynamics Settings**.

    > [!div class="mx-imgBorder"]
    > ![Select dynamics settings from admin portal in ZoonInfo](media/zoominfo-select-dynamics-settings.png "Select dynamics settings from admin portal in ZoonInfo")

5.	From the **Export** tab, select each record type (accounts, contacts, and leads) that you want your sales teams to be able to export to Dynamics 365 Sales organization.     
    -	Enter the maximum number of records (up to 25) that a seller can export to Dynamics 365 Sales organization.
    -	Enable the following options as required:
        >[!NOTE]
        >In this example, we are using the **Accounts** record type.
        
        -	**Create new Accounts**: To create an account in Dynamics 365 Sales organization from ZoomInfo. 
        -	**Allow Account duplicate creation**: To create a duplicate account even if the same account exists in your Dynamics 365 Sales organization.
        -	**Update existing Accounts**: To update an existing account with the latest information from the ZoomInfo app.   

6.	Select **Save**.   

    The changes are applied and saved to ZoomInfo app for your Dynamics 365 Sales organization.

### See also

[Install ZoomInfo app](install-zoominfo-app.md)   

[!INCLUDE[footer-include](../includes/footer-banner.md)]
