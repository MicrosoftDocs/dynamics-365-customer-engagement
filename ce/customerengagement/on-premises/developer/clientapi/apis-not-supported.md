---
title: "Client APIs not supported in Dynamics 365 Customer Engagement (on-premises)| MicrosoftDocs"
description: "Learn what Client API methods and properties are not supported for Dynamics 365 Customer Engagement (on-premises)"
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

This section covers all the client API methods and properties that are not supported in Dynamics 365 Customer Engagement (on-premises). For all the client API methods and properties that works for both online and on-premises environments, see article [Client API reference](/powerapps/developer/model-driven-apps/clientapi/reference)


|Client API| Methods/Properties| 
|----------|-------------------|
|Xrm.WebAPI|[Xrm.WebAPI.execute](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-webapi/execute.md)<br/> [Xrm.WebAPI.executeMultiple](/powerapps/developer/model-driven-apps/clientapi/reference/xrm-webapi/executemultiplr.md)<br/> [Xrm.WebAPI.retrieveMultipleRecords().successCallback(fetchXmlPagingCookie)]()|
|Xrm.Device|[Xrm.Device.captureImage(maximumAllowedFileSize)]()<br/> [Xrm.Device.captureAudio(maximumAllowedFileSize)]()<br/> [Xrm.Device.captureVideo(maximumAllowedFileSize)]()<br/> [Xrm.Device.openARViewer()]()|
|Xrm.Navigation|[Xrm.Navigation.NavigateTo(title)]()<br/> [Xrm.Navigation.NavigateTo(lookupAttributeName)]()<br/> [Xrm.Navigation.openForm(bpfDisplayStateForCrossEntityNavigation)]()|
|Xrm.Utility|[Xrm.Utility.getGlobalContext().client.isNetworkAvailable]()<br/> [Xrm.Utility.getGlobalContext().getCurrentAppSettings()]() <br/>[Xrm.Utility.getGlobalContext().getFeatureControlSettings()]()<br/> [Xrm.Utility.getGlobalContext().userSettings.securityRolePrivileges]() <br/>[Xrm.Utility.getGlobalContext().userSettings.securityRolePrivilegesInfo]() <br/> [Xrm.Utility.getGlobalContext().organizationSettings.isTrialOrganization]()<br/> [Xrm.Utility.getGlobalContext().organizationSettings.organizationExpiryDate]()|
|formContext.ui|[formContext.ui.footerSection]()<br/> [formContext.ui.HeaderSection]()|
|formContext.data.entity|[formContext.data.entity.addOnPostSave()]()<br/> [formContext.data.entity.removeOnPostSave()]()|
|executionContext.getEventArgs()|[executionContext.getEventArgs().preventDefaultOnError()]()|



## See also

[Client scripting in Customer Engagement using JavaScript](client-scripting.md)