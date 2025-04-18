---
title: Connect Exchange Online to Dynamics 365 Customer Engagement (on-premises)
description: Follow these steps to configure server-based authentication between Dynamics 365 Customer Engagement (on-premises) and Exchange Online.
ms.custom: 
ms.reviewer: sericks
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 (on-premises)
ms.assetid: 5622050b-a0e8-40ca-9ed5-fc082d5212a8
caps.latest.revision: 61
ms.author: rahulmital 
author: rahulmital
---
# Connect Customer Engagement (on-premises) to Exchange Online

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

This article describes how to configure server-based authentication between Dynamics 365 (on-premises) and Exchange Online. The diagram below illustrates the communication between Dynamics 365 (on-premises), Azure Active Directory, and Exchange Online.

![Dynamics 365 (on-premises) and Exchange Online.](media/dynamics-365-onprem-exchange-online.png)

## Permissions required

### Microsoft Dynamics 365
- You must be assigned to the System Administrator security role.
- If you're using a self-signed certificate for evaluation purposes, you must have local Administrators group membership on the computer where Microsoft Dynamics 365 Server is running.
- The account that you use to sign in to the CRM deployment servers must have full local administrator rights.

### Exchange Online
- You must have Office 365 Global Administrators membership. This is required for administrative-level access to the Office 365 subscription and to run the Microsoft AzurePowerShell cmdlets.

    > [!IMPORTANT]
    > In this deployment, the Dynamics 365 administrator can approve mailboxes.

- As part of configuring your Customer Engagement (on-premises) access to Exchange Online, you must ask your tenant's Exchange Online or Global Administrator to [engage with Exchange Support](/microsoft-365/admin/get-help-support?view=o365-worldwide&preserve-view=true) to turn on this access for your Exchange Online tenant ID.

## Set up server-based authentication with Microsoft Dynamics 365 and Exchange Online

Follow the steps in the order provided to set up Dynamics 365 (on-premises) with Exchange Online.

> [!IMPORTANT]
> The steps described here must be completed in the order provided. If a task is not completed, such as a Windows PowerShell command that returns an error message, the issue must be resolved before you continue to the next command, task, or step.

### Verify prerequisites

Before you configure Dynamics 365 (on-premises) and Exchange Online for server-based authentication, the following prerequisites must be met:

- Microsoft Dynamics 365 Hybrid Connector. The Microsoft Dynamics 365 Hybrid Connector is a free connector that lets you use server-based authentication with Microsoft Dynamics 365 (on-premises) and Exchange Online. More information: [Microsoft Dynamics 365 Hybrid Connector](https://signup.microsoft.com/Signup?OfferId=2d11d538-945d-48c6-b609-a5ce54ce7b18&pc=76ac7a4d-8346-4419-959c-d3896e89b3c9)
- An x509 digital certificate issued by a trusted certificate authority is used to authenticate between Dynamics 365 (on-premises) and Exchange Online. The certificate should have a [KeySpec value](/windows-server/identity/ad-fs/technical-reference/ad-fs-and-keyspec-property) of 1. If you're evaluating server-based authentication, you can use a self-signed certificate.
- Verify that all servers that run the Asynchronous Processing Service have the certificate that is used for Server-to-Server authentication.
- Verify that the account that runs the Asynchronous Processing Service has read access to private keys of the certificate. More information: [Grant the Asynchronous Processing Service service account read access to the certificate](#grant-the-asynchronous-processing-service-service-account-read-access-to-the-certificate)

### Configure server-based authentication

1. On the Microsoft Dynamics 365 Server where the deployment tools server role is running, start the Azure Active Directory Module for Windows PowerShell.
2. Prepare the certificate.

   Add the Dynamics CRM snapin
  ```powershell
  Add-PsSnapin Microsoft.CRM.PowerShell
  ```
  Run the set-crmcertificate command after updating the DataFile parameter to the full path and name of the certificate being used for the S2STokenIssuer
  ```powershell
  Set-CrmCertificate –CertificateType S2STokenIssuer  -StoreName My –StoreLocation LocalMachine -StoreFindType FindBySubjectDistinguishedName –DataFile C:\temp\CRMCert.cer
  ```

 4. [Set up a new Entra ID app](/graph/auth-register-app-v2) to configure server-side synchronization and the customer relationship management app with the certificate from the previous step.
    
    Make sure to [add](/entra/identity-platform/quickstart-configure-app-access-web-apis) and grant the following API permissions to the new app:

    - Application.ReadWrite.All
    - Orgaization.Read.All
    - User.Read
    
    Create a client secrete for this new app and [modify the app registration to create a client secret](/azure/app-service/configure-authentication-provider-aad?tabs=workforce-configuration#-option-2-use-an-existing-registration-created-separately).
    
      :::image type="content" source="media/SSS_Image1.png" alt-text="Upload the deployment profile.":::

    > [!NOTE]
    > The new app, configred above, is only needed for setup and new API permissions. The app can be removed once all the setup steps are completed. 
     
5. In the PowerShell session from step 2, invoke the **ConfigureCrmServerSideSync** command.                     

    [Download](https://github.com/microsoft/PowerApps-Samples/blob/master/powershell/ServerSideSync/ConfigureCrmServerSideSync.ps1) the script and replace the existing script if the ConfigureCrmServerSideSync.ps1 script present in the current powershell session directory, from above, is different than the script in the download link:

 ```powershell
     $ConfigureCrmServerSideSyncWithCommand = ".\ConfigureCrmServerSideSync.ps1 -cerFilePath c:\Personalcertfile.pfx -microsoftEntraIdTenantIdOrDomainName microsoft_entraid_tenantid_or_domain_name -ClientID 
     app_id_from_step3 -ClientSecret client_secret_from_step3" 
     Invoke-Expression -command $ConfigureCrmServerSideSyncWithCommand 
 ```

> [!IMPORTANT]
> For customers using Exchange Online with Government Community Cloud (GCC) High for US government environments, the **S2SDefaultAuthorizationServerMetadataUrl** in the PowerShell script must be changed to *https://login.microsoftonline.us/metadata/json/1*.

### Set the Exchange Online tenant ID

1. In the Azure Active Directory module for Windows PowerShell shell, run the following commands.

    ```powershell
    $CRMContextId = (Get-MsolCompanyInformation).ObjectID
    $CRMContextId
    ```

2. Copy the GUID that is displayed to the clipboard.

3. Update S2STenantId for the organization by running these commands, where OrganizationName is the unique name of the organization and ExchangeOnlineTenantId is the TenantId retrieved in the prior step. 

    ```powershell
    $organizationName = "OrganizationName"
    $CRMContextId = "ExchangeOnlineTenantId"
    $orgInfo = Get-CrmOrganization -Name $organizationName
    $ID = $orgInfo.id 
    
        if($ID)
            {
              Set-CrmAdvancedSetting -ID $orgInfo.ID -configurationEntityName "Organization" -setting "S2STenantId" -value $CRMContextId
            }
    ```

### Error received during enable server-based authentication wizard
Error: Failed Authentication. This error can be returned when the certificate used for server-to-server authentication is missing or invalid. To resolve, update or install the certificate and try again.

## Create an email server profile
1. Go to **Settings** > **Email Configuration** > **Email Server Profiles**.
2. Select **New** > **Exchange Online (Hybrid)**.
3. For an Exchange email server profile, specify the following details.

    |Fields  |Description  |
    |---------|---------|
    |Name     | Specify a meaningful name for the profile.        |
    |Description     | Type a short description about the objective of the email server profile.        |
    |Server Type     | Prepopulated with Exchange Online (Hybrid).        |
    |Owner     | Prepopulated with the name of the owner of the email server profile.        |
    |Use Default Tenant ID      |  If you've used the PowerShell commands above to set the Exchange Online tenant ID (recommended), select **Yes** to use that ID. If you set this to **No**, you must specify the Exchange Online tenant ID manually (not recommended!).       |
    |Exchange Online Tenant ID     | If you've used the PowerShell commands above to set the Exchange Online tenant ID (recommended), the ID is prepopulated in this field.        |
    |Auto Discover Server Location     |  Prepopulated with the Exchange Online URL. Select **Yes** (recommended), if you want to use the auto discover service to determine the server location. If you set this to **No**, you must specify the email server location manually.       |
    |Incoming Server Location and Outgoing Server Location     |  If you select **No** in **Auto Discover Server Location**, enter a URL for **Incoming Server Location** and **Outgoing Server Location**.       |
    |**Additional Settings**   |         |
    |Process Email From    | Select a date and time. Email received after the date and time is processed by server-side synchronization for all mailboxes associated with this profile. If you set a value less than the current date, the change is applied to all newly associated mailboxes and their earlier processed emails are pulled.        |
    |Minimum Polling Intervals in Minutes    | Type the minimum polling interval, in minutes, for mailboxes that are associated with this email server profile. The polling interval determines how often server-side synchronization polls your mailboxes for new email messages.          |
    |Move Failed Emails to Undeliverable Folder    | To move the undelivered email to the Undeliverable folder, select **Yes**. If there’s an error in tracking email messages in Dynamics 365 as email activities, and if this option is set to **Yes**, the email message is moved to the Undeliverable folder.         |

4. Select **Save**.
5. Select **Test Connection** and review the results. To diagnose issues, see the following section.

### Troubleshoot the Exchange Online (Hybrid) profile connection

If you’ve run **Test Connection** and have issues with the Exchange Online (Hybrid) profile connection, use the information in the **Test Connection** dialog box to diagnose and fix the connection. 

You can find information on recurring issues and other troubleshooting information in [Blog: Test and Enable Mailboxes in Microsoft Dynamics CRM 2015](https://blogs.msdn.com/b/crm/archive/2015/08/31/test-and-enable-mailboxes-in-microsoft-dynamics-crm-2015.aspx) and [Troubleshooting and monitoring server-side synchronization](../admin/troubleshooting-monitoring-server-side-synchronization.md).

## Configure default email processing and synchronization

Set server-side synchronization to be the default configuration method.

1. Go to **Settings** > **Email Configuration** > **Email Configuration Settings**.
2. Set the processing and synchronization fields as follows:
   
    - **Server Profile**: The profile you created in the above section.
    - **Incoming Email**: Server-Side Synchronization or Email Router
    - **Outgoing Email**: Server-Side Synchronization or Email Router
    - **Appointments, Contacts, and Tasks**: Server-Side Synchronization or Email Router

    > [!NOTE]
    > If your users primarily use Dynamics 365 for Outlook on their desktop computers, Microsoft Dynamics 365 for Outlook might be a better choice.

    If you leave the Email processing form unapproved user and queues at the default values (selected), you need to approve emails and queues for user mailboxes as directed below in Approve Email.

    ![Exchange Server profile.](media/system-settings-exchange-profile.png)

3. Select **OK**.
 
## Configure mailboxes

To set mailboxes to use the default profile, you must first set the Server Profile and the delivery method for email, appointments, contacts, and tasks.

In addition to administrator permissions, you must have Read and Write privileges on the Mailbox entity to set the delivery method for the mailbox.

Select one of the following methods:

![Apply default email settings.](media/apply-default-email-settings.png)

### Edit mailboxes to set the profile and delivery methods

1. Go to **Settings** > **Email Configuration** > **Mailboxes**.
2. Select **Active Mailboxes**.
3. Select the mailboxes that you want to configure, and then select **Edit**.
4. In the **Change Multiple Records** form, under **Synchronization Method**, set **Server Profile** to the Exchange Server profile you created earlier. 
5. Set **Incoming** and **OutgoingEmail** to **Server-Side Synchronization** or **Email Router**.
6. Set **Appointments**, **Contacts**, and **Tasks** to **Server-Side Synchronization**.

    > [!NOTE]
    > If your users primarily use Dynamics 365 for Outlook on their desktop computers, Microsoft Dynamics 365 for Outlook might be a better choice.

7. Select **Change**.
 
## Approve email

You need to approve each user mailbox or queue before that mailbox can process email. 
1. Go to **Settings** > **Email Configuration** > **Mailboxes**.
2. Select **Active Mailboxes**.
3. Select the mailboxes that you want to approve, and then select **More Commands (…)** > **Approve Email**.
4. Select **OK**. 

## Test configuration of mailboxes

1. Go to **Settings** > **Email Configuration** > **Mailboxes**.
2. Select **Active Mailboxes**.
3. Select the mailboxes you want to test, and then select **Test & Enable Mailboxes**.

This tests the incoming and outgoing email configuration of the selected mailboxes and enables them for email processing. If an error occurs in a mailbox, an alert is shown on the Alerts wall of the mailbox and the profile owner. Depending on the nature of the error, Microsoft Dynamics 365 tries to process the email again after some time or disables the mailbox for email processing. 

The result of the email configuration test is displayed in the **Incoming Email Status**, **Outgoing Email Status**, and **Appointments, Contacts, and Tasks Status** fields of a mailbox record. An alert is also generated when the configuration is successfully completed for a mailbox. This alert is shown to the mailbox owner.

> [!TIP]
> If you’re unable to synchronize contacts, appointments, and tasks for a mailbox, you may want to select the **Sync items with Exchange from this Dynamics 365 org only, even if Exchange was set to sync with a different org** check box. [Read more about this check box](../admin/when-would-want-use-check-box.md).

## Test email configuration for all mailboxes associated with an email server profile

1. Go to **Settings** > **Email Configuration** > **Email Server Profiles**.
2. Select the profile you created, and then select **Test & Enable Mailboxes**.

When you test the email configuration, an asynchronous job runs in the background. It may take a few minutes for the test to be completed. Microsoft Dynamics 365 tests the email configuration of all the mailboxes associated with the Exchange Server profile. For the mailboxes configured with server-side synchronization for synchronizing appointments, tasks, and contacts, it also checks to make sure they’re configured properly. 

> [!TIP]
> If you’re unable to synchronize contacts, appointments, and tasks for a mailbox, you may want to select the **Sync items with Exchange from this Dynamics 365 org only, even if Exchange was set to sync with a different org** check box. [Read more about this check box](../admin/when-would-want-use-check-box.md).

## Grant the Asynchronous Processing Service service account read access to the certificate

This procedure explains how to grant the Asynchronous Processing Service service account read access to private keys of the certificate.

1. On the computer where the certificate is located, in the search box enter mmc.exe, and then press Enter.
1. In Microsoft Management Console, select **File**, and then select **Add/Remove Snap-in**.
1. Select **Certificates**, select **Add**, select **Computer account**, select **Next**, select **Local computer**, and then select **Finish**.
1. Select **OK** to close the **Add or Remove Snap-ins** dialog.
1. Expand **Certificates – (Local Computer)**, expand **Personal**, and then select **Certificates**.
1. Right-click the certificate you're using for authentication with Exchange Online, then select **All Tasks** > **Manage Private Keys**.
1. Select **Add**, search for and select the service account the Asynchronous Processing Service runs under, **Allow Read** permission, and then select **OK**.
1. Restart the **Microsoft Dynamics CRM Asynchronous Processing Service** and the **Microsoft Dynamics CRM Asynchronous Processing Service (maintenance)** services.

## Related information
[Server-side synchronization](../admin/server-side-synchronization.md) </br>
[Troubleshooting and monitoring server-side synchronization](../admin/troubleshooting-monitoring-server-side-synchronization.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
