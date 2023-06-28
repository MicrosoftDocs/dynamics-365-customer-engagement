---
title: "Prevent random running of scripts  in Unified Service Desk| MicrosoftDocs"
description: "Learn how to prevent random running of scripts in Unified Service Desk using UII options."
ms.date: 01/02/2023
ms.topic: article
author: gandhamm
ms.author: mgandham
search.audienceType: 
  - admin
ms.custom: 
  - dyn365-USD
  - dyn365-admin
---
# Prevent random running of scripts in Unified Service Desk

The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client includes the following two UII options that you can use to prevent random running of scripts via ShellExecute, RunScript, etc.
  
- ValidateSecurityForUIIAction
- ListOfActionsToValidate

Use the `ValidateSecurityForUIIAction` UII option to turn the security feature to true or false. `ListOfActionsToValidate` is a valid list of actions on which the security check must be performed.

If `ValidateSecurityForUIIAction` option is set to true, then you'll get configured action data if:
- the current action is in the list given in the `ListOfActionsToValidate` option.
- the current action data is a subset or exact match to the action data configured for that particular action.

Else, an error message is displayed indicating that the action isn't configured and that you must contact your administrator for further action.

  
### See also

 [Manage Options for Unified Service Desk](../../unified-service-desk/admin/manage-options-unified-service-desk.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
