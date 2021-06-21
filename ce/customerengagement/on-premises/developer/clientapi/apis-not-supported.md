---
title: "Client APIs not supported in Dynamics 365 Customer Engagement (on-premises)| MicrosoftDocs"
description: "List of Client APIs not supported in Dynamics 365 Customer Engagement (on-premises)"
ms.date: 06/17/2021
ms.service: crm-online
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 16271bd8-cfa8-4a7f-802a-60fbff7c3722
author: nkrb
ms.author: nabuthuk
manager: kvivek
search.audienceType: 
  - developer
---

# Client APIs not supported in Dynamics 365 Customer Engagement (on-premises)

This section provides information about client APIs that are not supported in Dynamics 365 Customer Engagement (on-premises). Unless otherwise specified, all the client APIs should works for both online and on-premises environments. For a list of all the client APIs that support both online and on-premises environment, see [Client API reference](/powerapps/developer/model-driven-apps/clientapi/reference).


|Client API| Methods/Properties|
|----------|-------------------|
|executionContext.getEventArgs()|[executionContext.getEventArgs().preventDefaultOnError()](/powerapps/developer/model-driven-apps/clientapi/reference/save-event-arguments/preventdefaultonerror)|
|formContext.data.entity|[formContext.data.entity.addOnPostSave()](/powerapps/developer/model-driven-apps/clientapi/reference/controls/addonpostsave)<br/> [formContext.data.entity.removeOnPostSave()](/powerapps/developer/model-driven-apps/clientapi/reference/controls/removeonpostsave)|
|formContext.ui|[formContext.ui.footerSection](/powerapps/developer/model-driven-apps/clientapi/reference/formcontext-ui-footersection)<br/> [formContext.ui.HeaderSection](/powerapps/developer/model-driven-apps/clientapi/reference/formcontext-ui-headersection)|
|Xrm.Navigation|[title](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-navigation/navigateto#parameters)<br/>|
|Xrm.Utility|[Xrm.Utility.getGlobalContext().client.isNetworkAvailable](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-utility/getglobalcontext/client#isnetworkavailable)<br/> [Xrm.Utility.getGlobalContext().userSettings.securityRolePrivileges](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-utility/getglobalcontext/usersettings#securityroleprivileges) <br/> [Xrm.Utility.getGlobalContext().organizationSettings.isTrialOrganization](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-utility/getglobalcontext/organizationsettings#istrialorganization)<br/> [Xrm.Utility.getGlobalContext().organizationSettings.organizationExpiryDate](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-utility/getglobalcontext/organizationsettings#organizationexpirydate)|
|Xrm.WebAPI|[Xrm.WebAPI.execute](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-webapi/execute.md)<br/> [Xrm.WebAPI.executeMultiple](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-webapi/executemultiplr.md)|


## See also

[Client scripting using JavaScript](client-scripting.md)