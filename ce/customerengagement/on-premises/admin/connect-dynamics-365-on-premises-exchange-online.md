---
title: Connect Dynamics 365 On-Premises to Exchange Online
description: Follow these steps to configure server-based authentication between Dynamics 365 Customer Engagement (on-premises) and Exchange Online.
ms.reviewer: mkaur
ms.topic: how-to
applies_to: 
  - Dynamics 365 (on-premises)
ms.author: anladwig
author: anladwig
---
# Connect Dynamics 365 Customer Engagement (on-premises) to Exchange Online

> [!WARNING]
> This configuration uses the Exchange Web Services (EWS) protocol to communicate with Exchange Online, which Microsoft is removing from Exchange Online in April 2027. Learn more in [Deprecation of Exchange Web Services in Exchange Online](/exchange/clients-and-mobile-in-exchange-online/deprecation-of-ews-exchange-online).
>
> Using this feature requires a manual connection process. Starting October 1, 2025, there are no new updates, and no new tenants connect to this feature.
>
> This integration will be removed in the following months:
>
> **Important dates**
>
> - **May 25, 2026** — End of support for Dynamics CRM Customer Engagement v8.0 (on-premises) with Exchange Online.
> - **October 1, 2026** — Recommended deadline to migrate to Dynamics 365 (online), or [Allow list tenant with EWS for support until April 1, 2027](https://techcommunity.microsoft.com/blog/exchange/exchange-online-ews-your-time-is-almost-up/4492361).
> - **April 1, 2027** — End of support for Dynamics CRM Customer Engagement v9.0 (on-premises) with Exchange Online.
>
> If you need server-side synchronization functionality, migrate to Dynamics 365 (online). Learn more in [Dynamics CRM (on-premises) to Dynamics 365 migration](/dynamics365/guidance/fasttrack/migration) and [Dynamics CRM (on-premises) to Dynamics 365 online migration process overview](/dynamics365/guidance/migrate/opol-crm-migration-high-level-overview).
>
> Another alternative is to use supported on-premises versions of Exchange Server instead of Exchange Online. Learn more in [Connect Customer Engagement (on-premises) to Exchange Server (on-premises)](/dynamics365/customerengagement/on-premises/admin/connect-on-prem-exchange-server-on-prem).

Learn how to configure server-based authentication between Dynamics 365 Customer Engagement (on-premises) and Exchange Online to enable server-side synchronization. The following diagram shows how Dynamics 365 Customer Engagement (on-premises), Azure Active Directory, and Exchange Online communicate.

:::image type="content" source="media/dynamics-365-onprem-exchange-online.png" alt-text="Screenshot of a diagram showing communication between Dynamics 365, Azure Active Directory, and Exchange Online.":::

## Permissions required

### Microsoft Dynamics 365
- You must be assigned to the System Administrator security role.
- If you use a self-signed certificate for evaluation purposes, you must have local Administrators group membership on the computer where Microsoft Dynamics 365 Server is running.
- The account that you use to sign in to the CRM deployment servers must have full local administrator rights.

### Exchange Online
- You must be an Office 365 Global Administrator. This role gives you administrative access to the Office 365 subscription and lets you run the Microsoft AzurePowerShell cmdlets.

    > [!IMPORTANT]
    > In this deployment, the Dynamics 365 administrator can approve mailboxes.

- To configure your Dynamics 365 Customer Engagement (on-premises) access to Exchange Online, ask your tenant's Exchange Online administrator to [engage with Exchange Support](/microsoft-365/admin/get-help-support?view=o365-worldwide&preserve-view=true) to turn on this access for your Exchange Online tenant ID.

## Set up server-based authentication with Microsoft Dynamics 365 and Exchange Online

Follow the steps in the order provided to set up Dynamics 365 Customer Engagement (on-premises) with Exchange Online.

> [!IMPORTANT]
> Complete the steps described here in the order provided. If a task isn't completed, such as a Windows PowerShell command that returns an error message, resolve the issue before you continue to the next command, task, or step.

### Verify prerequisites

Before you configure Dynamics 365 Customer Engagement (on-premises) and Exchange Online for server-based authentication, make sure you meet the following prerequisites:

- Microsoft Dynamics 365 Hybrid Connector. The Microsoft Dynamics 365 Hybrid Connector is a free connector that lets you use server-based authentication with Microsoft Dynamics 365 (on-premises) and Exchange Online. For more information, see [Microsoft Dynamics 365 Hybrid Connector](https://signup.microsoft.com/Signup?OfferId=2d11d538-945d-48c6-b609-a5ce54ce7b18&pc=76ac7a4d-8346-4419-959c-d3896e89b3c9).
- An x509 digital certificate issued by a trusted certificate authority to authenticate between Dynamics 365 Customer Engagement (on-premises) and Exchange Online. The certificate should have a [KeySpec value](/windows-server/identity/ad-fs/technical-reference/ad-fs-and-keyspec-property) of 1. If you're evaluating server-based authentication, you can use a self-signed certificate.
- All servers that run the Asynchronous Processing Service have the certificate that is used for Server-to-Server authentication.
- The account that runs the Asynchronous Processing Service has read access to private keys of the certificate. For more information, see [Grant the Asynchronous Processing Service service account read access to the certificate](#grant-the-asynchronous-processing-service-service-account-read-access-to-the-certificate).

### Configure server-based authentication

1. Prepare the certificate.

   Change the directory to the location of the CertificateReconfiguration.ps1 file (by default it's `C:\Program Files\Microsoft Dynamics CRM\Tools`).

    ```powershell
    $certificateParameters = @{
        CertificateFile = "C:\Personalcertfile.pfx"
        Password = "personal_certfile_password"
        UpdateCrm = $true
        CertificateType = "S2STokenIssuer"
        ServiceAccount = "contoso\CRMAsyncService"
        StoreFindType = "FindBySubjectDistinguishedName"
    }

    .\CertificateReconfiguration.ps1 @certificateParameters
    ```

 2. [Set up a new Entra ID app](/graph/auth-register-app-v2) to configure server-side synchronization and the customer relationship management app with the certificate from the previous step.
    
    Make sure to [add](/entra/identity-platform/quickstart-configure-app-access-web-apis) and grant the following API permissions to the new app:

    - Application.ReadWrite.All
    - Organization.Read.All
    - User.Read
    
    Create a client secret for this new app and [modify the app registration to create a client secret](/azure/app-service/configure-authentication-provider-aad?tabs=workforce-configuration#-option-2-use-an-existing-registration-created-separately).
    
      :::image type="content" source="media/SSS_Image1.png" alt-text="Screenshot of the control used to upload the deployment profile.":::

    > [!NOTE]
    > The new app that you configure in the preceding step is only needed for setup and new API permissions. You can remove the app when you complete all the setup steps. 
     
3. In the PowerShell session from step 2, invoke the **ConfigureCrmServerSideSync** command.                     

    [Download](https://github.com/microsoft/PowerApps-Samples/blob/master/powershell/ServerSideSync/ConfigureCrmServerSideSync.ps1) the script and replace the existing script if the **ConfigureCrmServerSideSync.ps1** script present in the current PowerShell session directory is different than the script in the download link.

    ```powershell
    $privateKeyPassword = ConvertTo-SecureString `
        "personal_certfile_password" -AsPlainText -Force

    $serverSideSyncParameters = @{
        PrivateKeyPassword = $privateKeyPassword
        PfxFilePath = "C:\Personalcertfile.pfx"
        OrganizationName = "organization_name"
        MicrosoftEntraIdTenantIdOrDomainName = "microsoft_entraid_tenantid_or_domain_name"
        ClientID = "app_id_from_step3"
        ClientSecret = "client_secret"
    }

    .\ConfigureCrmServerSideSync.ps1 @serverSideSyncParameters
    ```

> [!IMPORTANT]
> For customers using Exchange Online with Government Community Cloud (GCC) High for US government environments, change the **S2SDefaultAuthorizationServerMetadataUrl** in the PowerShell script to `https://login.microsoftonline.us/metadata/json/1`.

### Set the Exchange Online tenant ID

1. [Locate the tenant ID](/entra/fundamentals/how-to-find-tenant). Update the following PowerShell command with the tenant ID and run it.

    ```powershell
    $CRMContextId = "tenant_id"
    $CRMContextId
    ```

2. Copy the GUID that appears to the clipboard.

3. Update `S2STenantId` for the organization by running these commands. Replace `OrganizationName` with the unique name of the organization and `ExchangeOnlineTenantId` with the tenant ID you got in the previous step. 

    ```powershell
    $organizationName = "OrganizationName"
    $CRMContextId = "ExchangeOnlineTenantId"
    $orgInfo = Get-CrmOrganization -Name $organizationName

    if ($orgInfo.ID) {
        $advancedSettingParameters = @{
            ID = $orgInfo.ID
            ConfigurationEntityName = "Organization"
            Setting = "S2STenantId"
            Value = $CRMContextId
        }

        Set-CrmAdvancedSetting @advancedSettingParameters
    }
    ```

### Error received during enable server-based authentication wizard
Error: Failed Authentication. This error can occur when the certificate used for server-to-server authentication is missing or invalid. To resolve this error, update or install the certificate and try again.

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
    |Use Default Tenant ID      |  If you use the preceding PowerShell commands to set the Exchange Online tenant ID (recommended), select **Yes** to use that ID. If you set this field to **No**, you must specify the Exchange Online tenant ID manually (not recommended).       |
    |Exchange Online Tenant ID     | If you use the preceding PowerShell commands to set the Exchange Online tenant ID (recommended), the ID is prepopulated in this field.        |
    |Auto Discover Server Location     |  Prepopulated with the Exchange Online URL. Select **Yes** (recommended), if you want to use the auto discover service to determine the server location. If you set this field to **No**, you must specify the email server location manually.       |
    |Incoming Server Location and Outgoing Server Location     |  If you select **No** in **Auto Discover Server Location**, enter a URL for **Incoming Server Location** and **Outgoing Server Location**.       |
    |**Additional Settings**   |         |
    |Process Email From    | Select a date and time. Server-side synchronization processes email received after the date and time for all mailboxes associated with this profile. If you set a value less than the current date, the change applies to all newly associated mailboxes and their earlier processed emails are pulled.        |
    |Minimum Polling Intervals in Minutes    | Type the minimum polling interval, in minutes, for mailboxes that are associated with this email server profile. The polling interval determines how often server-side synchronization polls your mailboxes for new email messages.          |
    |Move Failed Emails to Undeliverable Folder    | To move the undelivered email to the **Undeliverable** folder, select **Yes**. If there's an error in tracking email messages in Dynamics 365 as email activities, and if this option is set to **Yes**, the email message is moved to the **Undeliverable** folder.         |

4. Select **Save**.
5. Select **Test Connection** and review the results. To diagnose issues, see the following section.

### Troubleshoot the Exchange Online (Hybrid) profile connection

If you run **Test Connection** and have issues with the Exchange Online (Hybrid) profile connection, use the information in the **Test Connection** dialog box to diagnose and fix the connection. 

You can find information on recurring issues and other troubleshooting information in [Blog: Test and Enable Mailboxes in Microsoft Dynamics CRM 2015](https://blogs.msdn.com/b/crm/archive/2015/08/31/test-and-enable-mailboxes-in-microsoft-dynamics-crm-2015.aspx) and [Troubleshooting and monitoring server-side synchronization](../admin/troubleshooting-monitoring-server-side-synchronization.md).

## Configure default email processing and synchronization

Set server-side synchronization as the default configuration method.

1. Go to **Settings** > **Email Configuration** > **Email Configuration Settings**.
2. Set the processing and synchronization fields as follows:
   
    - **Server Profile**: The profile you created in the previous section.
    - **Incoming Email**: Server-Side Synchronization or Email Router
    - **Outgoing Email**: Server-Side Synchronization or Email Router
    - **Appointments, Contacts, and Tasks**: Server-Side Synchronization or Email Router

    > [!NOTE]
    > If your users primarily use Dynamics 365 for Outlook on their desktop computers, Microsoft Dynamics 365 for Outlook might be a better choice.

    If you leave the Email processing form unapproved user and queues at the default values (selected), you need to approve emails and queues for user mailboxes as directed in the following section, **Approve Email**.

    :::image type="content" source="media/system-settings-exchange-profile.png" alt-text="Screenshot of Exchange Server profile settings for email processing and synchronization.":::

3. Select **OK**.
 
## Configure mailboxes

To set mailboxes to use the default profile, first set the server profile and the delivery method for email, appointments, contacts, and tasks.

In addition to administrator permissions, you need Read and Write privileges on the Mailbox entity to set the delivery method for the mailbox.

Select one of the following methods:

:::image type="content" source="media/apply-default-email-settings.png" alt-text="Screenshot of options for applying default email settings to selected mailboxes.":::

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

This action tests the incoming and outgoing email configuration of the selected mailboxes and enables them for email processing. If an error occurs in a mailbox, an alert appears on the Alerts wall of the mailbox and the profile owner. Depending on the nature of the error, Microsoft Dynamics 365 tries to process the email again after some time or disables the mailbox for email processing. 

The result of the email configuration test appears in the **Incoming Email Status**, **Outgoing Email Status**, and **Appointments, Contacts, and Tasks Status** fields of a mailbox record. An alert is also generated when the configuration is successfully completed for a mailbox. This alert is shown to the mailbox owner.

> [!TIP]
> If you can't synchronize contacts, appointments, and tasks for a mailbox, consider selecting the **Sync items with Exchange from this Dynamics 365 org only, even if Exchange was set to sync with a different org** check box. [Read more about this check box](../admin/when-would-want-use-check-box.md).

## Test email configuration for all mailboxes associated with an email server profile

1. Go to **Settings** > **Email Configuration** > **Email Server Profiles**.
2. Select the profile you created, and then select **Test & Enable Mailboxes**.

When you test the email configuration, an asynchronous job runs in the background. It might take a few minutes for the test to complete. Microsoft Dynamics 365 tests the email configuration of all the mailboxes associated with the Exchange Server profile. For the mailboxes you configure with server-side synchronization for synchronizing appointments, tasks, and contacts, it also checks to make sure they're configured properly. 

> [!TIP]
> If you can't synchronize contacts, appointments, and tasks for a mailbox, consider selecting the **Sync items with Exchange from this Dynamics 365 org only, even if Exchange was set to sync with a different org** check box. [Read more about this check box](../admin/when-would-want-use-check-box.md).

## Grant the Asynchronous Processing Service service account read access to the certificate

This procedure explains how to grant the Asynchronous Processing Service service account read access to private keys of the certificate.

1. On the computer where the certificate is located, enter `mmc.exe` in the search box, and then press Enter.
1. In Microsoft Management Console, select **File**, and then select **Add/Remove Snap-in**.
1. Select **Certificates**, select **Add**, select **Computer account**, select **Next**, select **Local computer**, and then select **Finish**.
1. Select **OK** to close the **Add or Remove Snap-ins** dialog.
1. Expand **Certificates – (Local Computer)**, expand **Personal**, and then select **Certificates**.
1. Right-click the certificate you're using for authentication with Exchange Online, select **All Tasks**, and then select **Manage Private Keys**.
1. Select **Add**, search for and select the service account the Asynchronous Processing Service runs under, **Allow Read** permission, and then select **OK**.
1. Restart the **Microsoft Dynamics CRM Asynchronous Processing Service** and the **Microsoft Dynamics CRM Asynchronous Processing Service (maintenance)** services.

## Related information
[Server-side synchronization](../admin/server-side-synchronization.md) </br>
[Troubleshooting and monitoring server-side synchronization](../admin/troubleshooting-monitoring-server-side-synchronization.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
