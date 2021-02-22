---
title: "Configure the AD FS server for claims-based authentication | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: f7d5c4db-4238-4f42-93a5-16904617311f
caps.latest.revision: 39
ms.author: matp
author: Mattp123
manager: kvivek
---
# Configure the AD FS server for claims-based authentication



After enabling claims-based authentication, the next step is to add and configure the claims provider and relying party trusts in [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)].  
  
## Configure the claims provider trust  
 You need to add a claims rule to retrieve the user principal name (UPN) attribute from [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] and send it to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] as a UPN.  
  
#### Configure AD FS to send the UPN LDAP attribute as a claim to a relying party  
  
1.  On the server running [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)], start [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] Management.  
  
2.  In the **Navigation Pane**, expand **Trust Relationships**, and then select **Claims Provider Trusts**.  
  
3.  Under **Claims Provider Trusts**, right-click **[!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)]**, and then select **Edit Claims Rules**.  
  
4.  In the Rules Editor, select **Add Rule**.  
  
5.  In the **Claim rule template** list, select the **Send LDAP Attributes as Claims** template, and then select **Next**.  
  
6.  Create the following rule:  
  
    -   Claim rule name: *UPN Claim Rule* (or something descriptive)  
  
    -   Add the following mapping:  
  
        1.  Attribute store: **[!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)]**  
  
        2.  LDAP Attribute: **User Principal Name**  
  
        3.  Outgoing Claim Type: **UPN**  
  
7.  Select **Finish**, and then select **OK** to close the Rules Editor.  
  
## Configure a relying party trust  
 After you enable claims-based authentication, you must configure [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] as a relying party to consume claims from [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] for authenticating internal claims access.  
  
1.  On the server running [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)], start [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] Management.  
  
2.  In the **Navigation Pane**, expand **Trust Relationships**, and then select **Relying Party Trusts**.  
  
3.  On the **Actions** menu located in the right column, select **Add Relying Party Trust**.  
  
4.  In the **Add Relying Party Trust Wizard**, select **Start**.  
  
5.  On the **Select Data Source** page, select **Import data about the relying party published online or on a local network**, and then type the URL to locate the federationmetadata.xml file.  
  
     This federation metadata is created during claims setup. Use the URL listed on the last page of the [!INCLUDE[pn_Configure_Claims-based_Wizard](../includes/pn-configure-claims-based-wizard.md)] (before you select **Finish**), for example, https://internalcrm.contoso.com/FederationMetadata/2007-06/FederationMetadata.xml. Verify that no certificate-related warnings appear.  
  
6.  Select **Next**.  
  
7.  On the **Specify Display Name** page, type a display name, such as *Dynamics 365 Claims Relying Party*, and then select **Next**.  
  
8.  On the **Configure Multi-factor Authentication Now** page, make your selection and select **Next**.  
  
9. On the **Choose Issuance Authorization Rules** page, select **Permit all users to access this relying party**, and then select **Next**.  
  
10. On the **Ready to Add Trust** page, on the **Identifiers** tab, verify that **Relying party identifiers** has a single identifier such as the following:  
  
    -   https://internalcrm.contoso.com  
  
     If your identifier differs from the above example, select **Previous** in the **Add Relying Party Trust Wizard** and check the Federation metadata address.  
  
11. Select **Next**, and then select **Close**.  
  
12. If the Rules Editor appears, select **Add Rule**. Otherwise, in the **Relying Party Trusts** list, right-click the relying party object that you created, select **Edit Claims Rules**, and then select **Add Rule**.  
  
    > [!IMPORTANT]
    >  Be sure the **Issuance Transform Rules** tab is selected.  
  
13. In the **Claim rule template** list, select the **Pass Through or Filter an Incoming Claim** template, and then select **Next**.  
  
14. Create the following rule:  
  
    -   Claim rule name: *Pass Through UPN* (or something descriptive)  
  
    -   Add the following mapping:  
  
        1.  Incoming claim type: **UPN**  
  
        2.  **Pass through all claim values**  
  
15. Select **Finish**.  
  
16. In the **Rules Editor**, select **Add Rule**, in the **Claim rule template** list, select the **Pass Through or Filter an Incoming Claim** template, and then select **Next**.  
  
17. Create the following rule:  
  
    -   Claim rule name: *Pass Through Primary SID* (or something descriptive)  
  
    -   Add the following mapping:  
  
        1.  Incoming claim type: **Primary SID**  
  
        2.  **Pass through all claim values**  
  
18. Select **Finish**.  
  
19. In the **Rules Editor**, select **Add Rule**.  
  
20. In the **Claim rule template** list, select the **Transform an Incoming Claim** template, and then select **Next**.  
  
21. Create the following rule:  
  
    -   Claim rule name: *Transform Windows Account Name to Name* (or something descriptive)  
  
    -   Add the following mapping:  
  
        1.  Incoming claiming type: **Windows account name**  
  
        2.  Outgoing claim type: **Name**  
  
        3.  **Pass through all claim values**  
  
22. Select **Finish**, and when you have created all three rules, select **OK** to close the Rules Editor.  
  
     ![Three claims rules](media/crm-itpro-claimswp-3rules.PNG "Three claims rules")  
  
     This illustration shows the three relying party trust rules you create.  
  
 The relying party trust you created defines how [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] Federation Service recognizes the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] relying party and issues claims to it.  
  
## Enable Forms Authentication  
 In [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] in [!INCLUDE[pn_windows_server_2012_r2](../includes/pn-windows-server-2012-r2.md)], forms authentication is not enabled by default.  
  
1.  Log on to the [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] server as an administrator.  
  
2.  Open the AD FS management console and select **Authentication Policies**.  
  
3.  Under **Primary Authentication**, **Global Settings**, **Authentication Methods**, select **Edit**.  
  
4.  Under **Intranet**, enable (check) **Forms Authentication** and then select **OK**.  
  
 ![Enable forms authentication](media/crm-itpro-claimswp-formsauth.PNG "Enable forms authentication")  
  
## For Windows Server 2016, run a cmdlet  
 If you're [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] server is running [!INCLUDE[pn_windowsserver2016](../includes/pn-windowsserver2016.md)], run the following Windows PowerShell cmdlet:  
  
```powershell  
Grant-AdfsApplicationPermission -ClientRoleIdentifier "<ClientRoleIdentifier>" -ServerRoleIdentifier <ServerroleIdentified>  
```  
  
1.  ClientRoleIdentifier :  the ClientId of your Adfsclient. For example: e8ab36af-d4be-4833-a38b-4d6cf1cfd525  
  
2.  ServerroleIdentified :  the Identifier of your relying party. For example: https://adventureworkscycle3.crm.crmifd.com/  
  
 For more information, see [Grant-AdfsApplicationPermission](https://technet.microsoft.com/itpro/powershell/windows/adfs/grant-adfsapplicationpermission).  
  
## See Also  
 [Implement claims-based authentication: internal access](implement-claims-based-authentication-internal-access.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]