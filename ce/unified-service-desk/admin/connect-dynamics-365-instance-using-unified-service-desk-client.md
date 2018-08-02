---
title: "Connect to a Dynamics 365 instance using the Unified Service Desk for Dynamics 365 Customer Engagement client | MicrosoftDocs"
description: "Learn how to connect to the Unified Service Desk solution using the Unified Service Desk client."
ms.custom:
  - dyn365-USD, dyn365-admin
ms.date: 08/23/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: cc1e6d1d-0ea6-46f7-ae4b-131b7bda2cf7
caps.latest.revision: 10
author: kabala123
ms.author: kabala
manager: sakudes
tags: 
 - "MigrationHO"
---
# Connect to a Dynamics 365 instance overview
The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client is the agent application you can use to connect to the [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] instance where you have deployed your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] entities and configuration data. On signing in through the client application, it reads the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration on the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance, and accordingly exposes the controls and functionality in the application.  
  
<a name="Signin"></a>   
## Sign in to Unified Service Desk  
 If you want to configure the sign-in experience, such as pre-populate values in the sign-in dialog box or automatically sign in users without displaying the sign-in dialog box, see [Configure sign-in information](../../unified-service-desk/admin/connect-dynamics-365-instance-using-unified-service-desk-client.md#ConfigureSignIn).  
  
1.  Start the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client by double-clicking the application shortcut on your desktop.  
  
2.  In the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sign-in dialog box, provide authentication details to connect to your [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] server.  
  
 ![Unified Service Desk client login screen](../../unified-service-desk/media/usd-login.PNG "Unified Service Desk client login screen")  
  
    -   For [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] select **Office 365**.  
  
    -   For on-premises deployments, select **On-premises** and choose from the following **Authentication Sources**.  
  
        - **Active Directory**. Choose this authentication source if you are connecting to [!INCLUDE[pn_crm_op_edition](../../includes/pn-crm-onprem.md)] internally through your network and do not connect to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] throught the Internet.  
  
        - **Internet-facing Deployment (IFD)**. Choose this authentication source if you are connecting to [!INCLUDE[pn_crm_op_edition](../../includes/pn-crm-onprem.md)] through the Internet.  
  
        - **OAuth**. Choose this authentication source if you are connecting to [!INCLUDE[pn_crm_op_edition](../../includes/pn-crm-onprem.md)] by using a security token service (STS) that is not [!INCLUDE[pn_Windows_Server](../../includes/pn-windows-server.md)] but supports the OAuth open framework.  
  
    -   If you have multiple organizations, and want to select the organization where [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] is deployed, select the **Display list of available organizations** check box, and then click **Login**.  
  
3.  If you have multiple organizations, select the organization you want to connect to.  
  
4.  The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] splash screen appears. This screen shows information about the configuration data being read by the client in the background. Next, the main window appears and prompts you to enter your [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] server credentials. Type in your credentials, and then sign in to the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application.  
  
 Any time you start the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client and need to sign in again, you don’t have to provide your connection information again. Your credentials are stored securely in the Windows Credential Manager and other connection information is stored in the Default_USD.config file at c:\Users\\*<USER_NAME>*\AppData\Roaming\Microsoft\USD, and used for subsequent sign-in activities.  
  
 If you want to change your connection information to sign in, click **Change Credentials** in the splash screen. You’ll see the initial sign-in dialog box where you can enter different credentials.  
  
 ![Unified Service Desk Change Credentials screen](../../unified-service-desk/media/usd-second-signin.png "Unified Service Desk Change Credentials screen")  
  
<a name="ConfigureSignIn"></a>   
## Configure sign-in information  
 If needed, administrators can configure the sign-in experience for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] and pre-populate values in the sign-in dialog box (except user name and password) so users can connect to the specified [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance, or they can configure it to automatically sign in users to an on-premises [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] instance based on their [!INCLUDE[pn_Active_Directory](../../includes/pn-active-directory.md)] credentials without even displaying the sign-in dialog box.  
  
> [!NOTE]
>  You can’t add or remove the fields in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sign-in dialog box. You can only specify the values that will appear in the fields when a user tries to sign in. However, users can change the pre-populated values in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sign-in dialog box before signing in.  
  
 To configure sign-in information, use the UnifiedServiceDesk.exe.config file that is available in the client installation directory (typically c:\Program Files\Microsoft Dynamics CRM USD\USD).  
  
1.  Run [!INCLUDE[pn_Notepad](../../includes/pn-notepad.md)] as an administrator.  
  
2.  In [!INCLUDE[pn_Notepad](../../includes/pn-notepad.md)], open the UnifiedServiceDesk.exe.config file from the client installation directory (typically c:\Program Files\Microsoft Dynamics CRM USD\USD).  
  
3.  Add the following keys under the `<appSettings>` node in the UnifiedServiceDesk.exe.config file.  
  
    ```xml  
    <add key="CrmDeploymentType" value="<DEPLOYMENT_TYPE>" />  
    <add key="CrmUseSSL" value="<VALUE>" />  
    <add key="CrmOrg" value="<ORG_NAME>" />  
    <add key="CrmPort" value="<PORT_NUMBER>" />  
    <add key="CrmServerName" value="<CRM_SERVER_NAME>" />  
    <add key="UseDefaultCreds" value="<VALUE>" />  
    <add key="CacheCredentials" value="<VALUE>" />  
    <add key="CrmOnlineRegion" value="<CRM_ONLINE_REGION>" />  
    <add key="AuthHomeRealm" value="<VALUE>" />  
    <add key="AskForOrg" value="<VALUE>" />  
    <add key="CrmDomain" value="<DOMAIN_NAME>" />  
    ```  
  
4.  Provide an appropriate value for each of the keys. Each key maps to an individual field in the sign-in dialog box. The following table shows valid key values.  
  
    |Key|Value|  
    |---------|-----------|  
    |`CrmDeploymentType`|`Prem` or `O365`<br /><br /> `Prem` must be used if you’re connecting to an on-premises or [!INCLUDE[pn_Internet_facing_deployment](../../includes/pn-internet-facing-deployment.md)] of [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)]; `O365` must be used if you’re connecting to [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)].|  
    |`CrmUseSSL`|`True` or `False`<br /><br /> This key is applicable only if you specified `Prem` in the `CrmDeploymentType` key.|  
    |`CrmOrg`|Specify the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] organization name|  
    |`CrmPort`|Specify the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] port number<br /><br /> This key is applicable only if you specified `Prem` in the `CrmDeploymentType` key.|  
    |`CrmServerName`|Specify the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] server name<br /><br /> This key is applicable only if you specified `Prem` in the `CrmDeploymentType` key.|  
    |`UseDefaultCreds`|`True` or `False` **Note:**  For on-premises [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] installation `(<add key="CrmDeploymentType" value="Prem" />`) and Active Directory authentication `(<add key="AuthHomeRealm" value="Active Directory" />`), set the value of this key to `True` to directly sign in users to the specified [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] server or organization without even displaying the sign-in dialog box.|  
    |`CacheCredentials`|`True` or `False` **Note:**  To force the connection dialog box to display every time the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client is launched, set the value of this key to `False`. By default, the client caches the last connection information, and uses it next time to establish a connection to the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] server, unless the user cancels and specifies a different connection.|  
    |`CrmOnlineRegion`|`NorthAmerica`, `EMEA`, `APAC`, `SouthAmerica`, `Oceania`, `JPN`, `CAN`, `IND`, or `NorthAmerica2`<br /><br /> If you don’t know the online region, leave the value empty: `value=""`<br /><br /> This key is applicable only if you specified `O365` in the `CrmDeploymentType` key.|  
    |`AuthHomeRealm`|`Active Directory` or `Internet-facing deployment(IFD)`.<br /><br /> This key is applicable only if you specified `Prem` in the `CrmDeploymentType` key.|  
    |`AskForOrg`|`True` or `False`<br /><br /> Indicates whether the **Display list of available organizations** check box is selected in the sign-in dialog box.|  
    |`CrmDomain`|Name of the [!INCLUDE[pn_ms_Windows_short](../../includes/pn-ms-windows-short.md)] domain.<br /><br /> This key is applicable only if you specified `Prem` in the `CrmDeploymentType` key.|  
  
5.  Save the UnifiedServiceDesk.exe.config file.  
  
6.  Do the following on *each* user’s computer where you want to configure the sign-in information:  
  
    1.  Copy the UnifiedServiceDesk.exe.config file that you just modified to the client installation directory (typically c:\Program Files\Microsoft Dynamics CRM USD\USD) to replace the existing file.  
  
    2.  Remove the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sign-in information from the roaming user profiles on the user’s computer. If the user has signed in to [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] from his computer at least once, the following files are created in the c:\Users\\*<USER_NAME>*\AppData\Roaming\Microsoft\USD directory: Default_USD.config and Default_USD. You must delete both these files for the configuration settings in the UnifiedServiceDesk.exe.config to take effect.  
  
 When the user starts the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] application on his computer:  
  
-   The sign-in dialog box shows the values specified in the UnifiedServiceDesk.exe.config file, and also creates the Default_USD.config file in the c:\Users\\*<USER_NAME>*\AppData\Roaming\Microsoft\USD directory to store the connection information (except user name and password; this is stored in [!INCLUDE[pn_Windows_Credential_Manager](../../includes/pn-windows-credential-manager.md)]). Thereafter, the client application uses the Default_USD.config file to display the sign-in information or to automatically sign in to [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].  
  
-   For an on-premises [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] installation with [!INCLUDE[pn_Active_Directory](../../includes/pn-active-directory.md)] authentication, if you have configured to automatically sign in the user without displaying the sign-in dialog box (`<add key="UseDefaultCreds" value="True" />`), the sign-in dialog box is not displayed, but the Default_USD.config file is created in the c:\Users\\*<USER_NAME>*\AppData\Roaming\Microsoft\USD directory to store the connection information (except user name and password). Thereafter, the client application uses the Default_USD.config file to automatically sign in to [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].  
  
 If you need to modify the default sign-in information, you must repeat steps 1-6.  
  
<a name="LogFiles"></a>   
## Troubleshoot sign-in issues  
 [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] provides logging support to log errors that can occur while signing in to the [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]. A log file, Login_ErrorLog.log, is created at c:\Users\\*<USER_NAME>*\AppData\Roaming\Microsoft\UnifiedServiceDesk\\*\<Version>* the first time you encounter any sign-in issues in the client application. Thereafter, the log file is used to record information about subsequent sign-in issues. This information can be helpful for troubleshooting issues related to signing in to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] from the client application.  
  
> [!NOTE]
> [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] also creates another log file, UnifiedServiceDesk.log, at the same location to log operational errors in the client application. The log file is created the first time you encounter any issues in the client application. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Configure diagnostic logging in Unified Service Desk](../../unified-service-desk/admin/configure-client-diagnostic-logging-unified-service-desk.md)  
  
## See also  
 [Manage access in Unified Service Desk](../../unified-service-desk/admin/security-unified-service-desk.md)   
 [Learn to use Unified Service Desk](../../unified-service-desk/learn-to-use-unified-service-desk.md)   
 [Unified Service Desk Configuration Walkthroughs](../../unified-service-desk/unified-service-desk-configuration-walkthroughs.md)   
 [Administer and manage Unified Service Desk](../../unified-service-desk/admin/administer-manage-unified-service-desk.md)
