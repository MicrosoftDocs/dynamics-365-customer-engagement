---
title: "Security enhancements: User session and access management with Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 11/27/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 599f849d-c4cb-4b1c-84a0-9fde48a1601a
caps.latest.revision: 59
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Security enhancements: User session and access management 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

New for Customer Engagement in [!INCLUDE [pn-crm-9-0-0-online](../includes/pn-crm-9-0-0-online.md)], you can use new security enhancements to better secure the [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] application. 

> [!IMPORTANT]
> These security enhancements are also available for:
>
> - Microsoft Dynamics CRM 2016 (on-premises, version 8.2) <br />
>   The feature is available by [contacting support](https://mbs.microsoft.com/customersource/northamerica/CRM/support/support-lifecycle/CRMSupport).
> - Microsoft Dynamics CRM 2016 (on-premises, version 8.1) <br />
>   The feature is available by [contacting support](https://mbs.microsoft.com/customersource/northamerica/CRM/support/support-lifecycle/CRMSupport).
> - Microsoft Dynamics CRM 2015 (on-premises) <br />
>   The feature is available by [contacting support](https://mbs.microsoft.com/customersource/northamerica/CRM/support/support-lifecycle/CRMSupport).
> 
> For more information on these versions, see [Security enhancements: User session and access management](https://technet.microsoft.com/library/mt825191.aspx)

> [!TIP]
> ![Video symbol](../admin/media/video-thumbnail-4.png "Video symbol") Check out the following video: [Security Enhancements: User session management](https://youtu.be/9eR8hP6S-YM).  

## User session timeout
By default, [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] sets a user session timeout of 24 hours. A user is not required to log in with their credentials for up to 24 hours regardless of whether the user was active or inactive. 

You can change this behavior.

- To enforce users to re-authenticate after a pre-determined period of time, admins can set a session timeout for their individual [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] instances.  Users can only remain signed in the application for the duration of session.  The application signs out the user when the session expires.  Users need to sign-in with their credentials to return to [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].

## Configure session timeout

1. In [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)], choose **Settings** > **Administration** > **System Settings** > **General** tab.
2. Under **Set session timeout**, set the values to apply to all your users.

> [!NOTE]
> Default values are:
> - Maximum Session Length: 1440 minutes
> - Minimum Session Length: 60 minutes
> - How long before session expires before showing timeout warning: 20 minutes

## Inactivity timeout

By default, [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] does not enforce an inactivity session timeout.  A user can remain logged in the application until the session timeout expires.  You can change this behavior.

- To enforce users to automatically signed out after a pre-determined period of inactivity, admins can set an inactivity timeout period for each of their [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] instances. The application signs out the user when the inactivity session expires.

> [!NOTE]
> Inactivity session timeout is not enforced in the following:
> 1. [!INCLUDE [pn-oc-online-short](../includes/pn-oc-online-short.md)]
> 2. [!INCLUDE [pn-dyn-365-phones](../includes/pn-dyn-365-phones.md)] and [!INCLUDE [pn-dyn-365-tablets](../includes/pn-dyn-365-tablets.md)]
> 3. [!INCLUDE [pn-unified-service-desk](../includes/pn-unified-service-desk.md)] client using [WPF](https://docs.microsoft.com/dotnet/framework/wpf/) browser (Internet Explorer is supported)
> 4. Live Assist (Chat)

To enforce the inactivity session timeout for Web Resources, Web Resources need to include the ClientGlobalContext.js.aspx file in their solution.

The [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] portal has its own settings to manage its session timeout and inactivity session timeout independent of these system settings.

## Configure inactivity timeout

1. In [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)], choose **Settings** > **Administration** > **System Settings** > **General tab**.
2. Under **Set inactivity timeout**, set the values to apply to all your users.

> [!NOTE]
> Default values are:
> - Minimum Duration of Inactivity: 5 minutes
> - Maximum Duration of Inactivity: less than Maximum Session length or 1440 minutes

## Access management

[!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] uses Azure Active Directory as the identity provider.  To secure the user’s access to [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)], the following were implemented:

- To enforce users to re-authenticate, users are required to sign in with their credentials after they signed out within the application. 
- To prevent users from sharing credentials to access [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)], the user access token is validated to ensure that the user who was given access by the identity provider is the same user who is accessing [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)].

<!--
## Steps for enabling security enhancements for Dynamics 365 (on-premises) deployments

These security enhancements are shipped disabled by default.  Administrators can enable these enhancements when using one of the supported Dynamics 365 (on-premises) builds listed below.

> [!NOTE]
> This applies to customers with the following versions of Dynamics 365:
> - Microsoft Dynamics CRM 2016 (on-premises, version 8.2) <br />
>   The feature is included in [this update](https://support.microsoft.com/help/4046795/microsoft-dynamics-365-online-and-on-premises-update-2-2).
> - Microsoft Dynamics CRM 2016 (on-premises, version 8.1) <br />
>   The feature is available by [contacting support](https://mbs.microsoft.com/customersource/northamerica/CRM/support/support-lifecycle/CRMSupport).
> - Microsoft Dynamics CRM 2015 (on-premises) <br />
>   The feature is available by [contacting support](https://mbs.microsoft.com/customersource/northamerica/CRM/support/support-lifecycle/CRMSupport).
> 
> **Requirement**
> These security enhancement features require claims-based authentication for user authentication. You can configure claims-based authentication in one of two ways:
> - With an Internet-facing deployment (IFD). See [Configure IFD for Microsoft Dynamics 365](https://technet.microsoft.com/library/dn609803.aspx).
> - With claims-based authentication alone if Microsoft Dynamics 365 is deployed in the same domain where all Microsoft Dynamics 365 users are located, or users are in a trusted domain. See [Configure claims-based authentication](https://technet.microsoft.com/library/dn920270.aspx).

To obtain SDK sample code (for reference, not required to configure and enable session timeout):

1. Access your Dynamics 365 server using your administrator account.
2. Open a browser session and download the [Dynamics 365 Software Development Kit (SDK)](https://www.microsoft.com/download/details.aspx?id=50032).
3. Select and run **MicrosoftDynamics365SDK.exe**. This will extract the download and create an SDK folder on your Dynamics 365 server.
4. Open a PowerShell command prompt.
5. Navigate to the downloaded SDK folder.
6. Open the SampleCode\PS folder.

After updating to a supported on-premises version, follow the steps below to enable security enhancements.

### User session timeout

System admins can now force users to re-authenticate after a set period.  You can set an active session timeout for each of your Dynamics 365 instances.  Users can only remain signed in to the application for the duration of the session.  Once the session expires, they’ll need to sign in again with their credentials.  System admins can also require sign in for users after a period of inactivity.  You can set an inactivity timeout for each of your instances.  The helps prevent unauthorized access by a malicious user from an unattended device. 

**Enable user session timeout**

  1. Enable session timeout:
     ```    
     SetAdvancedSettings.ps1 -ConfigurationEntityName ServerSettings -SettingName AllowCustomSessionDuration -SettingValue true
     ```

  2. Enable inactivity timeout:
     ``` 
     SetAdvancedSettings.ps1 -ConfigurationEntityName ServerSettings -SettingName AllowCustomInactivityDuration -SettingValue true
     ```

### Access token management

To better protect user access and data privacy in Dynamics 365, when a user signs out in the web client and needs to return to the application, they will need to enter their credentials again in all open browser sessions. Dynamics 365 ensures that the sign-in token was originally generated for the current browser and computer.

**Enable access token management**

  To enable for all organizations by default, copy and run this command in PowerShell:

    ```
    SetAdvancedSettings.ps1 -ConfigurationEntityName ServerSettings -SettingName WSFedNonceCookieEnabled -SettingValue true
    ```  

    Sample:

    ![SetAdvancedSettings.ps1](../media/ps_setadvancedsettings.png)

  -OR-

  To enable for a single organization, copy and run this command in PowerShell:

     SetAdvancedSettings.ps1 -ConfigurationEntityName Organization -SettingName WSFedNonceCookieEnabled -SettingValue true -Id <Your organization ID GUID>

      To get <Your organization ID GUID>, open PowerShell, and run the following:

        ```
        Add-PSSnapin Microsoft.Crm.PowerShell 
        Get-CrmOrganization
        ```  
        
        Sample:

        ![Example Organization ID](../media/ps_orgid.png)

      For more information, see [Get-CrmOrganization](https://technet.microsoft.com/library/dn833066.aspx) for details.
-->