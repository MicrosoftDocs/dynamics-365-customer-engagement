---
title: "Install Microsoft Dynamics 365 for Outlook using a command prompt | MicrosoftDocs"
ms.custom:
ms.date: 03/06/2017
ms.reviewer:
ms.service: crm-online
ms.suite:
ms.tgt_pltfrm:
ms.topic: article
applies_to: 
  - Dynamics 365 apps 
ms.assetid: 0e35546e-766b-4f5a-aead-0e8219ecb7f2
caps.latest.revision: 47
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType:
  - admin
  - customizer
  - enduser
search.app:
  - D365CE
  - D365Outlook
---
# Install Microsoft Dynamics 365 for Outlook using a command prompt
Installing [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)] is a two-step procedure. First, you must run Setup to install the files on the computer. Next, run the [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)][!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] to configure the application and complete the installation.

> [!IMPORTANT]
>  If there’s a conflict between a value in the configuration file and a value in the command-line parameters, the command-line parameter takes precedence.

<a name="BKMK_Step1Install"></a>
## Step 1: Install files

> [!NOTE]
>  See [Install Dynamics 365 for Outlook](install.md) for download instructions.

 The following command displays the available options to run [!INCLUDE[pn_Microsoft_Dynamics_CRM_for_Outlook_Setup](../../includes/pn-microsoft-dynamics-crm-for-outlook-setup.md)] at the command prompt:

 **Setupclient.exe** [/**A**] [/**Q**] [/**X**] [/**L** or /**LV** "[*drive*:][[ *path*] *logfilename*.log]"] [/targetdir "[*drive*:][ *path*]"] [/installofflinecapability] [/disableofflinecapability] [/ignoreofflinequeue]

### Command examples for Dynamics 365 for Outlook installation
 For users who travel or who are not always connected to the [!INCLUDE[pn_microsoftcrm_server](../../includes/pn-microsoftcrm-server.md)], [!INCLUDE[pn_crm_outlook_offline_access](../../includes/pn-crm-outlook-offline-access.md)] provides access to their customer data. To install [!INCLUDE[pn_crm_outlook_offline_access](../../includes/pn-crm-outlook-offline-access.md)] in quiet mode:

```
Setupclient /Q /l c:\clientinstalllog.txt /installofflinecapability /targetdir "c:\Program Files\Microsoft Dynamics CRM Client"
```

 To uninstall [!INCLUDE[pn_crm_outlook_offline_access](../../includes/pn-crm-outlook-offline-access.md)] in quiet mode:

```
SetupClient /x /q
```

#### Parameters for Dynamics 365 for Outlook installation

|              Parameter               |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
|--------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|                 None                 |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     Used without parameters, **Setupclient.exe** will run with all display screens.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
|       installofflinecapability       |                                                                                                                                                                                                                                                                                                                                                                                                                  Determines whether offline capability will be installed. When you include this parameter, offline capability and components are installed. If you don’t specify this parameter, the online-only client is installed.                                                                                                                                                                                                                                                                                                                                                                                                                   |
|     /targetdir \<"drive:\path">      |                                                                                                                                                                                                                                                                                                                                                                                                                                                         Specifies the folder in which [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] files will be installed.                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
|                  /A                  | Creates an administrative installation of [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] by creating a Windows Installer package. This package lets users run [!INCLUDE[pn_Setup](../../includes/pn-setup.md)] from a network share or lets non-administrative users run [!INCLUDE[pn_Setup](../../includes/pn-setup.md)] that is driven from a group policy. This parameter must be used with the **/targetdir** parameter described earlier. When using this parameter, the **/targetdir** value doesn’t have to be located on the local computer. A mapped drive or network share, such as \\\\*share\mscrm_client_admin*, can be used. **Important:**  If you don’t specify a target folder by using the `/targetdir` parameter, [!INCLUDE[pn_Setup](../../includes/pn-setup.md)] installs the administrative installation to the default folder \<*drive*:> Program Files\Microsoft Dynamics CRM. <br /><br /> For example, the command:<br /><br /> `Setupclient /Q /A /targetdir "\\share\mscrm_client_admin"` |
|                  /Q                  |                                                                                                                                                                                                                                                                                                                                                                 Quiet mode installation. This parameter requires a configuration file in XML format. The `/i` parameter contains the name of the XML configuration file. No dialog boxes or error messages will appear on the display screen. To capture error message information, include the log file parameter (/**L** or /**LV**).                                                                                                                                                                                                                                                                                                                                                                 |
| /L [drive:][[path] logfilename.log]  |                                                                                                                                                                                                                                                                                                                                                                                                                                   Creates a log file of installation activity. You must specify the file name of the log file and where to put it, but the path can’t be a relative path, such as %appdata%\CRMLogs.                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| /LV [drive:][[path] logfilename.log] |                                                                                                                                                                                                                                                                                                                                                                                                                               Creates a verbose log file of installation activity. You must specify the file name of the log file and where to put it, but the path can’t be a relative path, such as %appdata%\CRMLogs.                                                                                                                                                                                                                                                                                                                                                                                                                                |
|       disableofflinecapability       |                                                                                                                                                                                                                                                                                                                                                             When you specify this parameter, [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] is configured to hide the “go offline” button in the application. This button lets users switch to [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] with offline capability.                                                                                                                                                                                                                                                                                                                                                              |
|          ignoreofflinequeue          |                                                                                                                                                                                                                                                                                                                                                                                                                                      When you specify this parameter, [!INCLUDE[pn_Setup](../../includes/pn-setup.md)] will not attempt to synchronize items that may remain in the offline queue during upgrade.                                                                                                                                                                                                                                                                                                                                                                                                                                       |
|                  /X                  |                                                                                                                                                                                                                                                                                                                                                                                                                            Uninstalls [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]. This is a maintenance mode option that is only available when the application is already installed.                                                                                                                                                                                                                                                                                                                                                                                                                             |

### Sample Dynamics 365 for Outlook XML configuration file for installation
 The following configuration-file example installs [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] without offline access capability into the Program Files folder.

> [!NOTE]
>  You can use the same file that includes both the installation and configuration elements. [!INCLUDE[pn_Setup](../../includes/pn-setup.md)] and the [!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] ignore the elements that aren’t relevant to the operation.

```
<Deployments>
<TargetDir>c:\program files\Microsoft Dynamics CRM\Client</TargetDir>
<InstallOfflineCapability>false</InstallOfflineCapability>
</Deployments>
```

<a name="BKMK_Step2Configure"></a>
## Step 2: Configure Dynamics 365 for Outlook by using an XML configuration file
 After you install [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], you must configure it. You can do this by running the [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)][!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] at the command prompt. The [!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] file is named **Microsoft.Crm.Application.Outlook.ConfigWizard.exe** and is located in the Client\ConfigWizard folder where [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] is installed. By default, the folder is C:\Program Files\Microsoft Dynamics CRM.

> [!NOTE]
>  The credentials of the user who will run [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] are used to authenticate to [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)]. Therefore, to perform a silent configuration of [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], you must run the [!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] under the user's context, such as by running a user-invoked batch file or as a one-time entry in a logon script. For more information, see [User credentials are required when you run the Configuration Wizard](install-using-command-prompt.md#BKMK_usercred_CW). To deploy [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] by using Microsoft Group Policy, see [Deploy Microsoft Dynamics 365 for Outlook by using Group Policy](deploy-using-group-policy.md).
>
>  If a path to the configuration file isn’t specified, the [!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] looks for the default configuration file (**default_client_config.xml**) in the non-roaming profile folder (%localappdata%\Microsoft\MSCRM\\). If the file isn’t located in the non-roaming profile folder, the [!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] looks for the folder where [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] is installed. By default, [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] is installed in the C:\Program Files\Microsoft Dynamics CRM folder.
>
>  If the configuration file is located in the roaming location used by other applications (AppData\Roaming\Microsoft\MSCRM\\), it won’t be honored.

<a name="BKMK_CommandExamp"></a>
## Command examples for the Dynamics 365 for Outlook configuration
 The following command configures [!INCLUDE[pn_oc_laptop_short](../../includes/pn-oc-laptop-short.md)] by using a file named **config_client.xml** in quiet mode, and outputs a log file named **clientinstall.log**:

```
Microsoft.Crm.Application.Outlook.ConfigWizard.exe /Q /i c:\config_client.xml /xa /l c:\clientinstall.log
```

 The /**Q** quiet mode configuration parameter requires a configuration file in XML format. No dialog boxes or error messages will appear on the display screen. To capture error message information, include the log file parameter (/**L**) or verbose logging (/**LV**).

> [!IMPORTANT]
>  Valid user credentials stored in the Windows Vault are required to run the [!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] in quiet mode. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [User credentials are required when you run the Configuration Wizard](install-using-command-prompt.md#BKMK_usercred_CW)

 The `/i` [*drive*:] [[*path*] *configfilename.xml*]] command-line parameter provides [!INCLUDE[pn_Microsoft_Dynamics_CRM_for_Outlook_Setup](../../includes/pn-microsoft-dynamics-crm-for-outlook-setup.md)] with required information. It is the same information that each installation screen requires. The XML elements must be in English (US); special or extended characters can’t be used. An XML configuration file that has localized XML elements will not work correctly. An explanation of each XML element and a sample XML file follows:

 The `/xa` parameter, when used with the /q parameter, removes all organizations that are configured for [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)].

 The /R parameter may be used to suppress the [!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] user interface and only display the progress dialog box. This parameter requires a valid XML[!INCLUDE[pn_Setup](../../includes/pn-setup.md)] file that is named Default_Client_Config.xml and must be located in either the local user AppData or Client installation folder.

<a name="Outlook_xml_config_file"></a>
## Dynamics 365 for Outlook XML configuration file elements

|                                                         Element                                                         |                                                                                                                                                                                                                                                                                                    Description                                                                                                                                                                                                                                                                                                    |
|-------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|                                             \<Deployments> \</Deployments>                                              |                                                                                                                                                                                                                                                         The configuration file must be a valid XML file that uses \<**Deployment**> as the root element.                                                                                                                                                                                                                                                          |
|                            \<InstallOfflineCapability>true/false\</InstallOfflineCapability>                            |                                                                                                                                                                                       Specifies the type of [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] installation. Specifying `true` will install [!INCLUDE[pn_oc_laptop_short](../../includes/pn-oc-laptop-short.md)] capability.                                                                                                                                                                                        |
|                                       \<TargetDir>drive:\path\</TargetDirectory>                                        |                                                                                                                                                                                                                                      Specifies the folder in which [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] files will be installed.                                                                                                                                                                                                                                      |
|                                              \<Deployment> \</Deployment>                                               |                                                                                                                                                                                                                                                                                 Parent element for all of the following elements.                                                                                                                                                                                                                                                                                 |
|                                \<DiscoveryUrl>https://website:portnumber\</DiscoveryUrl>                                |                       Specifies the URL for the [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)][!INCLUDE[pn_Discovery_Web_Service](../../includes/pn-discovery-web-service.md)].<br /><br /> For [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)], use the full organization URL, such as https://orgname.crm.dynamics.com, or depending on your online environment and location, use the discovery service URL, in the form https://disco.crm.dynamics.com. For a list of URLs, see [MSDN: Discovery service](/previous-versions/dynamicscrm-2016/developers-guide/gg309401(v=crm.8)).                        |
|                             \<FederatedAuthentication>true/false\</FederatedAuthentication>                             |                                                                                                                                         Specifies if federated ([!INCLUDE[pn_azure_active_directory](../../includes/pn-azure-active-directory.md)]) credentials are used for authentication in the [!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)]. If you specify `false`, you can use credentials such as user@contoso.onmicrosoft.com.                                                                                                                                          |
|                                           \<Organizations> \</Organizations>                                            |                                                                                                                                                                                                                                                                     This is the parent element for the following \<**Organization**> element.                                                                                                                                                                                                                                                                     |
| \<Organization FriendlyName="*My Friendly Organization Name*" IsPrimary="true"/"false">OrganizationName\</Organization> |                                                       Specifies the name of the organization that the client will connect to.<br /><br /> **FriendlyName**. Specifies a different display name other than the organization name in [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)].<br /><br /> **IsPrimary**. Specifies the organization that will be configured as the synchronizing organization in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]. **Note:**  *OrganizationName* is case-sensitive.                                                        |
|                                    \<CEIPNotification>true/false\</CEIPNotification>                                    | Specifies whether [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] will display the “I want to join the Customer Experience Improvement Program” notification banner. The default setting is `true` and the notification banner is displayed. If you specify `false`, the notification banner doesn’t appear in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Microsoft Customer Experience Improvement Program](https://go.microsoft.com/fwlink/p/?LinkId=199851) |

<a name="BKMK_usercred_CW"></a>
## User credentials are required when you run the Configuration Wizard
 The [!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] requires user credentials. During a silent configuration, by using /Q with the Microsoft.Crm.Application.Outlook.ConfigWizard.exe file, the [!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] will look for the user’s credentials in the Windows Vault. If the [!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] can’t find the credentials, or the credentials aren’t in the required format, the configuration will not finish and an error will be recorded to the configuration log file. Notice that the [!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] doesn’t support adding the user UPN or password in the XML configuration file. For more information about the Windows Vault and Credential Manager, see [What is Credential Manager](https://go.microsoft.com/fwlink/p/?LinkId=513243)

<a name="BKMK_SampleConfFile"></a>
## Sample Dynamics 365 for Outlook XML configuration file for configuration
 The following configuration file example configures [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] to connect to a primary organization named *Contoso* and another organization named *AdventureWorksCycle* on the [!INCLUDE[pn_microsoftcrm_server](../../includes/pn-microsoftcrm-server.md)] that is named *crmserver*.

> [!NOTE]
>  You can use the same file that includes both the installation and configuration elements. [!INCLUDE[pn_Setup](../../includes/pn-setup.md)] and the [!INCLUDE[pn_configuration_wizard](../../includes/pn-configuration-wizard.md)] will ignore the elements that aren’t relevant to the operation.
>
>  **Example Default_Client_Config.xml file**

```
<Deployments>
<Deployment>
<DiscoveryUrl>https://crmserver</DiscoveryUrl>
<Organizations>
<Organization IsPrimary='true'>Contoso</Organization>
<Organization>AdventureWorksCycle</Organization>
</Organizations>
<CEIPNotification>false</CEIPNotification>
</Deployment>
</Deployments>
```

> [!NOTE]
>  The preceding example specifies two different organizations that the user has access to and configures [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] to not display the “I want to join the Customer Experience Improvement Program” notification banner. The value in the `Organization` element can’t contain special characters or spaces. For [!INCLUDE[pn_crm_op_edition](../../includes/pn-crm-op-edition.md)], you can find the organization unique name by running the Get-CrmOrganization [!INCLUDE[pn_PowerShell](../../includes/pn-powershell.md)] cmdlet or go to **Settings** > **Customizations** > **Developer Resources** and under **Instance Reference Information** copy the **Unique Name**.

### Configure Dynamics 365 for Outlook by using a script

1. Write a script that automatically updates the configuration settings for users of [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]. You could use lines such as the following to perform the basic configuration actions, based on a new configuration file that is stored on the computer indicated as <`servername`>.

    In the following script, the default client configuration file is overwritten, previously configured organizations are removed, user credentials are added to the Windows Vault, and the new organization is installed.

   ```
   copy /y \\<servername>\share\Default_Client_Config.xml "c:\Program Files\Microsoft Dynamics CRM\Default_Client_Config.xml"
   "C:\Program Files\Microsoft Dynamics CRM\Client\ConfigWizard\Microsoft.Crm.Application.Outlook.ConfigWizard.exe" /q /xa
   cmdkey /generic:Microsoft_CRM_https://disco.crm.dynamics.com/ /user:user@contoso.com /password{password_goes_here}
   "C:\Program Files\Microsoft Dynamics CRM\Client\ConfigWizard\Microsoft.Crm.Application.Outlook.ConfigWizard.exe" /q /i
   "C:\Program Files\Microsoft Dynamics CRM\Default_Client_Config.xml"
   ```

   > [!TIP]
   >  Consider running your script as a logon script, or forcing the script to run at a specific time, such as by using [!INCLUDE[pn_ms_system_center_config_mgr_2012_long](../../includes/pn-ms-system-center-config-mgr-2012-long.md)].
   >
   >  In the script, you might also want to include detection logic that determines whether the client computer has already been configured. If it has, you can have the script exit without taking action.

    **Example Default_Client_Config.xml file**

   ```
   <Deployment>
   <DiscoveryUrl>https://CrmDiscoveryUrl</DiscoveryUrl>
   <Organizations>
   <Organization IsPrimary='true'>Organization1</Organization>
   </Organizations>
   </Deployment>
   ```

2. Run the script on each client computer in the organization whose server has changed. You can run the script in various ways, including through the **Profile** tab of the user properties dialog box in [!INCLUDE[pn_Active_Directory_Users_Computers](../../includes/pn-active-directory-users-computers.md)] (ADUC), or through Group Policy Objects (GPO).

### See Also
 [Install Dynamics 365 for Outlook](install.md)



[!INCLUDE[footer-include](../../includes/footer-banner.md)]