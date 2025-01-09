---
title: "Post-installation and configuration guidelines for Dynamics 365 Customer Engagement (on-premises) | Microsoft Docs"
description: Understand the configuration needed after you install Dynamics 365 Customer Engagement (on-premises)
ms.custom: ""
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 6f6a7fc0-f9cf-4602-bd6c-4b4924185644
caps.latest.revision: 61
author: Mattp123
ms.author: matp
---
# Post-installation and configuration guidelines for Microsoft Dynamics 365

This section describes several of the tasks that the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] administrator should consider after the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] application is installed. This section isn’t meant to be an exhaustive resource used to configure deployments. Instead, use this section as a guideline to determine what best practices to implement and features to configure, based on your organization's needs.  
  
<a name="BKMK_copy_encr_key"></a>   
## Copy your organization encryption key  
 All new and upgraded organizations use data encryption that uses an encryption key to secure data such as user passwords for email mailboxes and [!INCLUDE[pn_yammer](../includes/pn-yammer.md)] accounts. This encryption key may be required to use [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] after a redeployment or failure recovery. We strongly recommend that you make a copy of the encryption key and save it to a secure location. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Copy your organization data encryption key](../admin/data-encryption.md#copy-your-organization-data-encryption-key)  
  
<a name="BKMK_MakeMicrosoft"></a>   
## Make Dynamics 365 client-to-server network communications more secure  
 With any network design, it is important to consider the security of your organization's client-to-server communications. When making necessary decisions that can help protect data, we recommend that you understand the following information about [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] network communication and about the technology options that are available that provide more secure data transmissions.  
  
 If you installed [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] or upgraded a [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] that isn’t already configured for HTTPS, [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] client-to-server communications are not encrypted. When using a website that supports only HTTP, information from [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] clients is transmitted in clear text and, therefore, possibly vulnerable to malicious intent, such as "man-in-the-middle" type attacks that could compromise content by adding scripts to perform harmful actions.  
  
### Configuring Dynamics 365 for HTTPS  
 Configuring a site for HTTPS will cause a disruption in the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] application so plan the configuration when there will be minimal disruption to users. The high-level steps for configuring [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] for HTTPS are as follows:  
  
1.  In [!INCLUDE[pn_Deployment_Manager_long](../includes/pn-deployment-manager-long.md)], disable the server where the [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)], [!INCLUDE[pn_Organization_Web_Service](../includes/pn-organization-web-service.md)], [!INCLUDE[pn_Discovery_Web_Service](../includes/pn-discovery-web-service.md)], and [!INCLUDE[pn_Deployment_Web_Service](../includes/pn-deployment-web-service.md)] roles are running. If this is a Full Server deployment, all server roles are running on the same computer. For information about how to disable a server, see [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)][!INCLUDE[pn_Deployment_Manager_Help](../includes/pn-deployment-manager-help.md)].  
  
2.  Configure the website where the [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] role is installed to use HTTPS. For more information about how to do this, see Internet Information Services (IIS) Help.  
  
3.  Set the binding in [!INCLUDE[pn_deploymentmanager](../includes/pn-deploymentmanager.md)]. This is done on the **Web Address** tab of the **Properties** page for the deployment. For more information about how change the bindings see [Microsoft Dynamics 365 deployment properties](microsoft-dynamics-365-deployment-properties.md).  
  
4.  If you want to make other [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] services more secure and [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] is installed by using separate server roles, repeat the previous steps for the additional server roles.  
  
<a name="BKMK_configure_IFD"></a>   
## Configure a Dynamics 365 Internet-facing deployment  
 After all [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] roles are installed, you can configure the deployment so that remote users can connect to the application through the Internet. To do this, start [!INCLUDE[cc_Rule_Deployment_manager_short](../includes/cc-rule-deployment-manager-short.md)] and complete the [!INCLUDE[pn_Configure_Claims-based_Wizard](../includes/pn-configure-claims-based-wizard.md)] followed by the [!INCLUDE[pn_Internet_Facing_Deployment_Configuration_Wizard](../includes/pn-internet-facing-deployment-configuration-wizard.md)]. Alternatively, you can complete these tasks using [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)]. More information: [Overview of Dynamics 365 Customer Engagement (on-premises) PowerShell](/powershell/dynamics365/customer-engagement/overview?view=dynamics365ce-ps&preserve-view=true)  
  
> [!IMPORTANT]
>  For [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)] to successfully connect to a new deployment of [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)], you must run a Repair of the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] application on the server running [!INCLUDE[pn_iis](../includes/pn-iis.md)] where the [!INCLUDE[pn_Web_Application_Server](../includes/pn-web-application-server.md)] role is installed *after* the [!INCLUDE[pn_Internet_Facing_Deployment_Configuration_Wizard](../includes/pn-internet-facing-deployment-configuration-wizard.md)] is successfully completed. <!-- [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Uninstall, change, or repair Microsoft Dynamics 365 Server](uninstall-change-repair-dynamics-365-server.md)  -->
 <!--  
 For more information about configuring [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] for claims-based authentication, see [Configure IFD for Microsoft Dynamics 365](configure-ifd-for-dynamics-365.md).  -->
  
<a name="BKMK_AddRemove"></a>   
## Add or remove sample data  
 Sample data is available to help you become familiar with how [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] works. By using sample data, work with records and see how they relate to each other, how data displays in charts, and see what information is in reports.  
  
 Sample data can be added or removed from within the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] application. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)][Add or remove sample data](/dynamics365/customer-engagement/admin/add-remove-sample-data)  
  
<a name="config_guidelines"></a>   
## Complete the configuration tasks for new organizations  
 After you've completed installing [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)], but before the business users in your organization start using it, there are some basic tasks that you, as the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] administrator, should complete. These tasks include defining business units and security roles, adding users, and importing data.  
  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Set up a Dynamics 365 organization](../admin/set-up-a-dynamics-365-organization.md)  
  
<a name="install_solution"></a>   
## Import apps and solutions   
  Sales and Field Service apps are available to you. More information: [Available apps for Dynamics 365 Customer Engagement (on-premises)](available-apps.md)

  Use solutions to extend functionality and the user interface. Customizers and developers distribute their work as solutions. Organizations use [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] to import the solution. Find a solution in the [Microsoft AppSource](https://appsource.microsoft.com/).  
  
> [!IMPORTANT]
>  Importing a solution or publishing customizations can interfere with normal system operation. We recommend that you schedule solution imports when it’s least disruptive to users.  
  
 For more information about how to import a solution, see [Import, update, and export a solution](/dynamics365/customer-engagement/customize/import-update-export-solutions).  
  
<a name="BKMK_WS2012R2"></a>   
## Configure Windows Server for Dynamics 365 Customer Engagement (on-premises) applications that use OAuth  
 The following information describes how to configure Windows Server with AD FS to support [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] applications such as [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)], [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)],  [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)], [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)], or other [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] applications that need OAuth support.  

<!--   
> [!NOTE]
>  -   There are a few issues that were present when configuring [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] 2.0 and 2.1 that are no longer needed for [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] 2.2. For example, with 2.0/2.1 you had to configure the MEX endpoint using a script or obtain a hotfix. This isn’t needed with [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] 2.2. In addition, [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] 2.2 adds the rule “Pass through all UPN Claims” in the [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] claim provider trust by default, so the extra step to add the rule is no longer required.  -->
<!-- > -   To register [!INCLUDE[pn_netbreeze_long](../includes/pn-netbreeze-long.md)],  see [Set up the connection between Dynamics CRM and Social Engagement](https://go.microsoft.com/fwlink/p/?LinkId=733269).  -->
  
### Enable forms authentication  
 By default, forms authentication is disabled in the intranet zone. You must enable forms authentication by following these steps:  
  
1.  Log on to the [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] server as an administrator.  
  
2.  Open the ADFS management wizard.  
  
3.  Select **Authentication Policies** > **Primary Authentication** > **Global Settings** > **Authentication Methods** > **Edit**.  
  
4.  Select (check) **Form Based Authentication** on the **Intranet** tab.  
  
### Configure the OAuth provider  
 Follow these steps to configure the OAuth provider in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]:  
  
1.  Log on to the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] server as an administrator.  
  
2. Add the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)][!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] snap-in (Microsoft.Crm.PowerShell.dll). [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Administer the deployment using Windows PowerShell](/previous-versions/dynamicscrm-2016/deployment-administrators-guide/dn531202(v=crm.8))  
  
   ```powershell  
   Add-PSSnapin Microsoft.Crm.PowerShell  
   ```  
  
3. Enter the following [!INCLUDE[pn_PowerShell](../includes/pn-powershell.md)] commands.  
  
   ```powershell  
  
   $ClaimsSettings = Get-CrmSetting -SettingType OAuthClaimsSettings  
   $ClaimsSettings.Enabled = $true  
   Set-CrmSetting -Setting $ClaimsSettings  
  
   ```  
  
### Register the client apps  
 The client apps must be registered with [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)].  
  
1.  Log on to the [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] server as administrator.  
  
2.  In a [!INCLUDE[pn_PowerShell_short](../includes/pn-powershell-short.md)] window, execute the following commands to register each application that is applicable to your deployment.  
  
     [!INCLUDE[pn_crm_2016_shortest](../includes/pn-crm-2016-shortest.md)] mobile apps for [!INCLUDE[tn_Apple_iphone](../includes/tn-apple-iphone.md)], [!INCLUDE[tn_android](../includes/tn-android.md)], and [!INCLUDE[pn_ms_Windows_short](../includes/pn-ms-windows-short.md)].  
  
    ```powershell  
    Add-AdfsClient -ClientId 00001111-aaaa-2222-bbbb-3333cccc4444 -Name "Microsoft Dynamics CRM for tablets and phones" -RedirectUri ms-app://s-1-15-2-2572088110-3042588940-2540752943-3284303419-1153817965-2476348055-1136196650/, ms-app://s-1-15-2-1485522525-4007745683-1678507804-3543888355-3439506781-4236676907-2823480090/, ms-app://s-1-15-2-3781685839-595683736-4186486933-3776895550-3781372410-1732083807-672102751/, ms-app://s-1-15-2-3389625500-1882683294-3356428533-41441597-3367762655-213450099-2845559172/, ms-auth-dynamicsxrm://com.microsoft.dynamics,ms-auth-dynamicsxrm://com.microsoft.dynamics.iphone.moca,ms-auth-dynamicsxrm://com.microsoft.dynamics.ipad.good,msauth://code/ms-auth-dynamicsxrm%3A%2F%2Fcom.microsoft.dynamics,msauth://code/ms-auth-dynamicsxrm%3A%2F%2Fcom.microsoft.dynamics.iphone.moca,msauth://code/ms-auth-dynamicsxrm%3A%2F%2Fcom.microsoft.dynamics.ipad.good,msauth://com.microsoft.crm.crmtablet/v%2BXU%2FN%2FCMC1uRVXXA5ol43%2BT75s%3D,msauth://com.microsoft.crm.crmphone/v%2BXU%2FN%2FCMC1uRVXXA5ol43%2BT75s%3D, urn:ietf:wg:oauth:2.0:oob  
    ```  
  
     [!INCLUDE[pn_crm_2016_outlook_shortest](../includes/pn-crm-2016-outlook-shortest.md)].  
  
    ```powershell  
    Add-AdfsClient -ClientId  11112222-bbbb-3333-cccc-4444dddd5555  -Name "Dynamics CRM Outlook Client" -RedirectUri app://22223333-cccc-4444-dddd-5555eeee6666/  
    ```  
  
     [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client.  
  
    ```powershell  
    Add-AdfsClient -ClientId  33334444-dddd-5555-eeee-6666ffff7777  -Name "Dynamics 365 Unified Service Desk" -RedirectUri app://44445555-eeee-6666-ffff-7777aaaa8888/  
    ```  
  
     [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] developer tools.  
  
    ```powershell  
    Add-AdfsClient -ClientId  55556666-ffff-7777-aaaa-8888bbbb9999  -Name "Dynamics 365 Development Tools" -RedirectUri app://66667777-aaaa-8888-bbbb-9999cccc0000/  
    ```  
  
3.  To register the [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)], in [!INCLUDE[pn_crm_op_edition](../includes/pn-crm-op-edition.md)], go to **Settings** > **Dynamics 365 App for Outlook** and register the app there.  
  
### Required steps after enabling OAuth for Dynamics 365 Server

When OAuth is enabled, and you have registered your applications, it's required to complete the following steps:

#### Remove site authentication providers

1. On the Dynamics 365 Server where the web application server role is running, open Internet Information Services (IIS) Manager. 
2. In the left pane, under the organization name, expand **Sites**, and then select **Microsoft Dynamics CRM**. 
3. Double-click **Authentication** in the middle pane.
4. Right-click **Windows Authentication**, and select **Providers**. For each provider in the list, select the provider, select **Remove**, and then select **OK**. 
5. After all providers are removed, right-click **Windows Authentication**, and then select **Disable**.

   ![Remove site provider.](media/remove-site-provider.png)

6. Repeat the previous steps to remove all Windows Authentication providers from the **nga** and **AppWebServices** site folders.

#### Add the AD FS address to the client local intranet zone to avoid client authentication prompts

1.	On the client computer, select **Start**, enter *inetcpl.cpl*, and select Enter to open **Internet Properties**.
2.	Select the **Security** tab, select the **Local intranet** zone, select **Sites**, and then select **Advanced**.
3. Enter in the AD FS address, select **Add**, select **Close**, select **OK**, and then select **OK** again.

#### Grant application permission 
On the AD FS server, run the following command in a Windows PowerShell console. This is required if you use Windows Server 2016 AD FS or later versions.

```powershell
Grant-AdfsApplicationPermission -ClientRoleIdentifier "<client_id/org_id>" -ServerRoleIdentifier "<org_auth_url>"
```

> [!IMPORTANT]
> Make sure org_auth_url is complete and accurate URL. Also, you must include the trailing forward slash /. <br />
> For example:  
> ```powershell 
> Grant-AdfsApplicationPermission -ClientRoleIdentifier "806e5da7-0600-e611-80bf-6c3be5b27d7a" -ServerRoleIdentifier https://auth.contoso.com:444/ 
> ```
> To display the authentication URL, run this PowerShell command: 
> ```powershell
>  Get-ADFSRelyingPartyTrust 
> ```

#### Restart AD FS
On the AD FS server, run the following PowerShell commands to force AD FS to restart.
```powershell
net stop adfssrv 
net start adfssrv
```

#### Enable Device Registration Service (DRS) on the federation server
To make sure that devices can connect to your deployment, follow the instructions in this topic: [Configure a federation server with Device Registration Service](/windows-server/identity/ad-fs/deployment/configure-a-federation-server-with-device-registration-service). 

## Request custom certificates using the Certificates MMC snap-in

This section explains how to generate a custom certificate request (CSR) that can be used to obtain an SSL certificate for Microsoft Dynamics 365 Customer Engagement on-premises.

> [!IMPORTANT]
> For claim-based authentication and the internet-facing deployment to work, it's mandatory that the steps below are completed.

1. Sign in to any Windows computer with an account that is a member of the local **Administrators** group.  
1. Select **Start**, type *mmc.exe*, and then press ENTER.
1. Select **File** on the command bar, and then select **Add/Remove Snap-in**.
1. In the list of available snap-ins, **select Certificates**, and then select **Add**.
1. Select **Computer account**, and then select **Next**.
1. Select **Local computer**, select **Finish**, and then select **OK**.

After you have added the Certificates snap-in for your local computer store open, create a custom certificate request.

1. In the MMC console tree, expand **Certificates (Local Computer)**.
1. Right-click **Personal**, point to **All Tasks**, point to **Advanced Operations**, and then select **Create Custom Request**.
1. The **Certificate Enrollment** wizard opens. Select **Next**.
1. On the **Select Certificate Enrollment Policy** page select **Proceed without enrollment policy** under **Custom Request**, and then select **Next**.
1. On the **Custom Request** page next to the **Template** options select **(No template) Legacy key** and select the **PKCS #10** request format option, and then select **Next**.
   :::image type="content" source="media/cert-custom-request.png" alt-text="Select options to create the custom certificate request":::

   > [!IMPORTANT]
   > CNG certificates aren't supported.
1. On the **Certificate Information** page expand **Details**, and then select **Properties**.
   :::image type="content" source="media/cert-properties.png" alt-text="Certificate properties":::
1. On the **General** tab, enter the **Friendly name** (display name), and then select **Apply**.
1. Select the **Subject** tab, and add the relevant subject names and alternative names for the certificate. Some public certificate authorities require various subject values. More information: [Certificate subject and alternative names examples](#certificate-subject-and-alternative-names-examples)
1. After you've added all relevant values select **Apply**.
1. Select the **Extensions** tab.
   1. Expand **Key Usage** and then **Add** **Data encipherment**, **Digital signature**, and **Key encipherment** as the **Selected options**.
   1. Expand **Extended Key Usage (application policies)** and then **Add** **Server Authentication** and **Client Authentication** as the **Selected options**.
   1. Select **Apply**.
1. Select the **Private Key** tab.
   1. Expand **Cryptographic Servicer Provider** and then select **Microsoft RSA Schannel Cryptographic Provider (Encryption)**
   1. Expand **Key options** then set **Key size** to *2048* (or higher) and select the **Make private key exportable** option.
   1. Expand **Key type** and then select **Exchange**.
   1. Select **Apply**.
      :::image type="content" source="media/cert-properties2.png" alt-text="Certificated properties for key type":::
1. Review all tabs to make sure all required options are selected or entered. After verification select **OK**.
1. The **Certificate Enrollment** page is displayed. Select **Next**.
1. On the **Where do you want to save the offline request** page, enter the full path to save the request file and ensure that **File format** is set to **Base 64**. Select **Finish**.

Now you will have a CSR in BASE 64 format, which you can forward to an external or internal certificate authority for signing.

> [!IMPORTANT]
> There's no private key included. This avoids any compromise of the private key when transferring to a Certificate Authority.

Your provider will provide a signed version of the certificate including the private key and the payload. That certificate you receive must be imported back on the same machine where you created the certificate request.

### Import and then export the received certificate

Import the certificate into the local certificate store (Personal) and the request will automatically be completed. Doing so merges the private and public key. From the Certificates MMC snap-in right-click the **Certificates** folder in the **Personal** folder, point to **All Tasks**, and then select **Import**. **Browse** to and select the certificate and follow the steps in the **Certificate Import Wizard** to import it.

Finally, you export the certificate.

1. In the Certificates MMC snap-in, right-click the certificate, point to **All Tasks**, and then select **Export**.
1. On the **Certificate Export Wizard** select **Next**, and then select **Yes, export the private key**. Select **Next**.
1. On the **Export File Format** page, leave all the default settings, and then select **Next**.
   :::image type="content" source="media/cert-export-format.png" alt-text="Certificate export format":::
1. On the **Security** page select **Password**.
   1. Enter a password that will be your private key. Ensure to save that information in a secure place.
   1. Select **Encryption** as **AES256-SHA256**.
   1. Select **Next**.
1. Enter the folder path where you want to save the certificate, that will be saved in PFX format. 
1. Select **Next** and then select **Finish**.

Now you can use the PFX certificate for Dynamics 365 Customer Engagement (on-premises) and other applications such as AD FS as well.

> [!IMPORTANT]
> If your certificate authority doesn't accept legacy type certificate requests, ensure to match all requirements except the Cryptographic Service Provider (CSP). You can run the below Certutil.exe in an elevated command shell to reimport the PFX with the required provider.
>  
> `certutil -csp "Microsoft RSA SChannel Cryptographic Provider" -importpfx <drive><name of cert>.pfx AT_KEYEXCHANGE`

### Certificate subject and alternative names examples

Subject name examples.

|Type  |Value entered  |Subject name  |
|---------|---------|---------|
|Country     | DE        | C=DE     |
|Locality     |  Munich       |  L=Munich       |
|Organization     |  Contoso Ltd       | O=Contoso Ltd        |
|Organizational unit     |  IT       | OU=IT        |
|State     |  Bavaria       |  S=Bavaria       |
|Common name     |  *.contoso.com<sup>1</sup>       |  CN=*.contoso.com<sup>1</sup>       |

<sup>1</sup>Uses wildcard. A wildcard certificate is recommended as it covers all DNS values created for the domain.

:::image type="content" source="media/cert-subject-names.png" alt-text="Certificate subject name examples":::

For the subject alternative names (SAN) ensure to cover all DNS values you require. For example, alternative name DNS type values for the fictional company named Contoso might be: auth.contoso.com, dev.contoso.com, internalcrm.contoso.com, adfs.contoso.com, crmorg1.contoso.com, crmorg2.contoso.com, and so on.

:::image type="content" source="media/cert-alt-names.png" alt-text="Certificate subject alternative name examples":::

## Configure databases for SQL Server AlwaysOn

Although the article referenced below applies to an earlier version of Dynamics 365 Customer Engagement (on-premises), you can use similar steps to configure the Dynamics 365 Customer Engagement (on-premises), version 9 organization and configuration databases for SQL Server AlwaysOn.

> [!IMPORTANT]
> The final tasks under step 4 in the below article link that describe how to **Create the MSCRMSqlClrLogin SQL Login** under [Create the SQL logins for the Microsoft Dynamics 365 security groups on all secondary replicas](/previous-versions/dynamicscrm-2016/deployment-administrators-guide/jj822357(v=crm.8)#create-the-sql-logins-for-the-microsoft-dynamics-365-security-groups-on-all-secondary-replicas) are not applicable to this version and should be ignored when configuring Dynamics 365 Customer Engagement (on-premises), version 9 databases to use SQL Server AlwaysOn. <br/> MSCRMSqlClrLogin SQL login, the asymmetric key for it, and Microsoft.Crm.SqlClr.Helper.dll aren’t required with Dynamics 365 Customer Engagement (on-premises), version 9.

 More information: [Set configuration and organization databases for SQL Server AlwaysOn failover](/previous-versions/dynamicscrm-2016/deployment-administrators-guide/jj822357(v=crm.8))

<a name="BKMK_usertrain"></a>   
## User training and adoption  
 [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Training and Adoption Kit for Microsoft Dynamics 365](/power-platform/admin/try-powerapps-dynamics-365)  
  
## See also  
 [Installing on-premises Dynamics 365](installing-on-premises-dynamics-365.md)   
 [Operating Microsoft Dynamics 365](operating-microsoft-dynamics-365.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
