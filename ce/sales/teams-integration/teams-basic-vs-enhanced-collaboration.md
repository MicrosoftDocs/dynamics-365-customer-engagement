---
title: "Basic vs Enhanced Collaboration in Microsoft Teams"
description: "Learn about the differences between Basic and Enhanced Collaboration in Microsoft Teams, including the permissions, connection setups, and more."
ms.date: 08/09/2022
ms.topic: article
author: sbmjais
ms.author: shjais
ms.reviewer: 
ms.custom: 
search.audienceType: 
  - enduser
applies_to: 
  - Dynamics 365 apps
ms.assetid: 8097c9ec-023b-407d-ac0e-074b5e1964a5
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 1
---
# Difference between the Basic and Enhanced Collaboration Experience with Microsoft Teams 

This article provides information about the differences between Basic and Enhanced Collaboration in Microsoft Teams, including the permissions, connection setups, and more.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | <ul><li>Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, Dynamics 365 Sales Professional, Dynamics 365 Team Members, or any Dynamics 365 customer engagement app license</li> <li>Microsoft Teams license</li></ul>  <br>More information: <ul><li>[Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/)</li><li>[Microsoft Teams pricing](https://www.microsoft.com/microsoft-teams/compare-microsoft-teams-options?activetab=pivot:primaryr2&rtc=1)</li><li>[Dynamics 365 Team Members](/dynamics365/get-started/team-members-license)</li><li>[Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409)</li></ul> |
| **Security roles** | <ul><li>Any primary sales role, such as salesperson, or sales manager</li><li>Any role that has access to a Dynamics 365 record</li></ul> <br>  More information: [Primary sales roles](../security-roles-for-sales.md#primary-sales-roles)|

## Know the difference

Before you can start using the collaboration experience, it needs to be turned on in your customer engagement apps in Dynamics 365 (Dynamics 365 Sales, Dynamics 365 Customer Service, Dynamics 365 Field Service, Dynamics 365 Marketing, and Dynamics 365 Project Service Automation). 


Enable Basic Collaboration Experience to share documents between a connected Microsoft Teams channel and your customer engagement apps record. To learn how to turn on Basic or Enhanced collaboration, see [Enable linking of Dynamics 365 records to Teams channels](enable-record-linking.md).

 
|Collaboration type  |Description  |
|---------|---------|
|**Basic Collaboration Experience**     |  <ul><li>You need system admin permissions to enable this feature.</li><br/>  <li>When you choose the **Collaborate** option in a customer engagement apps (such as Dynamics 365 Sales and Dynamics 365 Customer Service) record page, the connection set-up process between the app record and Microsoft Teams collaboration channel happens in Microsoft Teams.</li><br/> <li>You can manually pin an app record or view from Microsoft Teams. <br/> <br/>**Note:** The option to add recommended members during the manual set-up process from Microsoft Teams is not supported.  </li></ul>       |
|**Enhanced Collaboration Experience**    | <ul><li>You need Microsoft 365 tenant admin permissions to enable this feature. </li><br/>  <li>When you choose the **Collaborate** option on in app record or view page, a set-up wizard will guide you through the connection set-up process between the app record or view page in customer engagement apps and Microsoft Teams collaboration.</li><br/> <li>You can manually pin an app record or view from the Microsoft Teams app and add recommended members if you are the team channel owner.</li><br/>  </ul>  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
