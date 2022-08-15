---
title: "Client scripting reference for Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
description: Learn about the Power Apps client APIs that are not supported in Customer Engagement (on-premises) with a reference table of unsupported client APIs.
ms.date: 06/24/2021

ms.topic: article
ms.assetid: 16271bd8-cfa8-4a7f-802a-60fbff7c3722
author: Nkrb
ms.author: nabuthuk
search.audienceType: 
  - developer
---

# Client scripting reference for Dynamics 365 Customer Engagement (on-premises)

All the client APIs that are documented in the [Client API reference](/powerapps/developer/model-driven-apps/clientapi/reference) section in Power Apps docs are available for Dynamics 365 Customer Engagement (on-premises) *except* the ones listed in the section below.

## Client APIs not supported in Customer Engagement (on-premises)

This section provides information about client APIs that are not supported in Dynamics 365 Customer Engagement (on-premises).

|Client API/area| Methods/parameters not supported|
|----------|-------------------|
|executionContext.getEventArgs()|[executionContext.getEventArgs().getEntityReference()](/powerapps/developer/model-driven-apps/clientapi/reference/save-event-arguments/getentityreference)<br/> [executionContext.getEventArgs().getIsSaveSuccess()](/powerapps/developer/model-driven-apps/clientapi/reference/save-event-arguments/getissavesuccess) <br/> [executionContext.getEventArgs().getSaveErrorInfo()](/powerapps/developer/model-driven-apps/clientapi/reference/save-event-arguments/getsaveerrorinfo) <br/> [executionContext.getEventArgs().preventDefaultOnError()](/powerapps/developer/model-driven-apps/clientapi/reference/save-event-arguments/preventdefaultonerror) |
|formContext.data.entity|[formContext.data.entity.addOnPostSave()](/powerapps/developer/model-driven-apps/clientapi/reference/controls/addonpostsave)<br/> [formContext.data.entity.removeOnPostSave()](/powerapps/developer/model-driven-apps/clientapi/reference/controls/removeonpostsave)|
|formContext.ui|[formContext.ui.footerSection](/powerapps/developer/model-driven-apps/clientapi/reference/formcontext-ui-footersection)<br/> [formContext.ui.HeaderSection](/powerapps/developer/model-driven-apps/clientapi/reference/formcontext-ui-headersection)|
|Xrm.Navigation|The `title` parameter in [Xrm.Navigation.navigateTo](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-navigation/navigateto#parameters) isn't supported.|
|Xrm.Utility|[Xrm.Utility.getGlobalContext().client.isNetworkAvailable](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-utility/getglobalcontext/client#isnetworkavailable)<br/> [Xrm.Utility.getGlobalContext().organizationSettings.isTrialOrganization](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-utility/getglobalcontext/organizationsettings#istrialorganization)<br/> [Xrm.Utility.getGlobalContext().organizationSettings.organizationExpiryDate](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-utility/getglobalcontext/organizationsettings#organizationexpirydate) <br/>[Xrm.Utility.getGlobalContext().userSettings.securityRolePrivileges](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-utility/getglobalcontext/usersettings#securityroleprivileges) |

