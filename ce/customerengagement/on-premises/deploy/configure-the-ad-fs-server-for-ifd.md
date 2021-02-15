---
title: "Configure the AD FS server for IFD | Microsoft Docs"
ms.custom: ""
ms.date: "10/01/2018"
ms.prod: "crm-2016"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (on-premises)"
ms.assetid: 29ba2ff1-8391-4b42-be1c-6bc1b3e4d14d
caps.latest.revision: 25
ms.author: matp
author: Mattp123
manager: kvivek
---
# Configure the AD FS server for IFD



After you have enabled IFD on the [!INCLUDE[pn_microsoftcrm_server](../includes/pn-microsoftcrm-server.md)] you will need to create a relying party for the IFD endpoint on the [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] server.  
  
## Configure relying party trusts  
  
1.  On the computer that is running [!INCLUDE[pn_Windows_Server](../includes/pn-windows-server.md)] where the [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] federation server is installed, start [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] Management.  
  
2.  In the **Navigation Pane**, expand **Trust Relationships**, and then select **Relying Party Trusts**.  
  
3.  On the **Actions** menu located in the right column, select **Add Relying Party Trust**.  
  
4.  In the **Add Relying Party Trust Wizard**, select **Start**.  
  
5.  On the **Select Data Source** page, select **Import data about the relying party published online or on a local network**, and then type the URL to locate the federationmetadata.xml file.  
  
     This federation metadata is created during IFD Setup, for example, https://auth.contoso.com/FederationMetadata/2007-06/FederationMetadata.xml.  
  
     Type this URL in your browser and verify that no certificate-related warnings appear.  
  
6.  Select **Next**.  
  
7.  On the **Specify Display Name** page, type a display name, such as `Dynamics 365 IFD Relying Party`, and then select **Next**.  
  
8.  On the **Configure Multi-factor Authentication Now** page, make your selection and select **Next**.  
  
9. On the **Choose Issuance Authorization Rules** page, select **Permit all users to access this relying party**, and then select **Next**.  
  
10. On the **Ready to Add Trust** page, on the **Identifiers** tab, verify that **Relying party identifiers** has three identifiers such as the following:  
  
    -   https://auth.contoso.com  
  
    -   https://orgname.contoso.com  
  
    -   https://dev.contoso.com  
  
     If your identifiers differ from the above example, select **Previous** in the **Add Relying Party Trust Wizard** and check the Federation metadata address.  
  
11. Select **Next**, and then select **Close**.  
  
12. If the Rules Editor appears, select **Add Rule**. Otherwise, in the **Relying Party Trusts** list, right-click the relying party object that you created, select **Edit Claims Rules**, and then select **Add Rule**.  
  
    > [!IMPORTANT]
    >  Be sure the **Issuance Transform Rules** tab is selected.  
  
13. In the **Claim rule template** list, select the **Pass Through or Filter an Incoming Claim** template, and then select **Next**.  
  
14. Create the following rule:  
  
    -   Claim rule name: `Pass Through UPN` (or something descriptive)  
  
    -   Add the following mapping:  
  
        1.  Incoming claim type: **UPN**  
  
        2.  **Pass through all claim values**  
  
15. Select **Finish**.  
  
16. In the **Rules Editor**, select **Add Rule**, and in the **Claim rule template** list, select the **Pass Through or Filter an Incoming Claim** template, and then select **Next**.  
  
    -   Claim rule name: `Pass Through Primary SID` (or something descriptive)  
  
    -   Add the following mapping:  
  
        1.  Incoming claim type: **Primary SID**  
  
        2.  **Pass through all claim values**  
  
17. Select **Finish**.  
  
18. In the **Rules Editor**, select **Add Rule**,  
  
19. In the **Claim rule template** list, select the **Transform an Incoming Claim** template, and then select **Next**.  
  
20. Create the following rule:  
  
    -   Claim rule name: `Transform Windows Account Name to Name` (or something descriptive)  
  
    -   Add the following mapping:  
  
        1.  Incoming claim type: **Windows account name**  
  
        2.  Outgoing claim type: **Name**  
  
        3.  **Pass through all claim values**  
  
21. Select **Finish**, and, when you have created all three rules, select **OK** to close the Rules Editor.  
  
## For Windows Server 2016, run a cmdlet  
 If you're [!INCLUDE[pn_adfs_short](../includes/pn-adfs-short.md)] server is running [!INCLUDE[pn_windowsserver2016](../includes/pn-windowsserver2016.md)], run the following Windows PowerShell cmdlet:  
  
```powershell  
Grant-AdfsApplicationPermission -ClientRoleIdentifier "<ClientRoleIdentifier>" -ServerRoleIdentifier <ServerroleIdentified>  
```  
  
1.  ClientRoleIdentifier :  the ClientId of your Adfsclient. For example: e8ab36af-d4be-4833-a38b-4d6cf1cfd525  
  
2.  ServerroleIdentified :  the Identifier of your relying party. For example: https://adventureworkscycle3.crm.crmifd.com/  
  
 For more information, see [Grant-AdfsApplicationPermission](https://technet.microsoft.com/itpro/powershell/windows/adfs/grant-adfsapplicationpermission).  
  
## See Also  
 [Implement claims-based authentication: external access](implement-claims-based-authentication-external-access.md)



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]