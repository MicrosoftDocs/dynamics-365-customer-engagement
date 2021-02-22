---
title: "Create an action call for a UII action | MicrosoftDocs"
description: "Learn about creating an action call for a UII action."
author: v-sailab
ms.author: v-sailab
manager: shujoshi
ms.date: 12/31/2017
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
search.audienceType: 
  - customizer
  - developer
search.app: 
  - D365CE
  - D365USD
---
# Create an action call for a UII action in Unified Service Desk

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

There are two ways in which you can create an action call for a [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] action:  

-   Create an action call and then attach it to the hosted control and the respective UII action.  

-   Start from a hosted control that contains the UII action that you want to create the action call for.  

<a name="StartActionCall"></a>   
## Start from the action call  

1. Sign in to Unified Service Desk Administrator.
  
2. Select **Action Calls** under **Basic Settings**. 

4. Select **+ New Action Call** on the command bar.  

5. On the **New Action Call** page, specify information for various fields as per the following table.  

   ![New action call in Unified Service Desk](../unified-service-desk/media/usd-new-action-call.png "New action call in Unified Service Desk")  


   |     Field      | Description |
   |----------------|------------------------------------------------------------|
   |      Name      | A descriptive name of the action call. |
   | Hosted Control | The hosted control having the UII action to be called. |
   |     Action     | The UII action name to call on the hosted control. To call a UII action for a hosted control, the action must be added to the list of UII actions for a hosted control in Microsoft Dataverse.|
   |      Data      | This is the serialized data (string data) that is passed as the data parameter to the action. **Note:**  Some actions interpret multiline input specified here as separate parameters. |

6. Select the **Advanced** tab and specify the following.

   |     Field      | Description |
   |----------------|------------------------------------------------------------|
   |   Condition    | This is a [!INCLUDE[pn_JavaScript](../includes/pn-javascript.md)] expression that should result in true or false. For example, “[[account.name]]”==”My Account”<br /><br /> If the condition results in false or throws an exception, the action won’t be performed. If the action is blank or the result is true, the action will be performed. **Note:**  If the condition results in false or throws an exception, the action won’t be performed. If the action is blank or the result is true, the action will be performed.               |
   |  Shortcut Key  | This is a shortcut key that can be used by an agent to run this action while within the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] client. Anything valid for the `KeyBinding.Gesture` string can be used here. For more information see: [https://msdn.microsoft.com/library/system.windows.input.keybinding.gesture.aspx](https://msdn.microsoft.com/library/system.windows.input.keybinding.gesture.aspx).<br /><br /> Examples:<br /><br /> -   CTRL+R<br />-   CTRL+ALT+A<br />-   SHIFT+ALT+A<br />-   CTRL-F12 |

   > [!TIP]
   >  You can view the embedded help at the bottom of the **New Action Call** page to know the description and the applicable parameters that can be passed using the action call.  

6. Select **Save**.  

<a name="StartHostedControl"></a>   
## Start from the hosted control  

1. Create or edit the hosted control that contains the UII action that you want to create an action call for. For more information, see [Create or edit a hosted control](../unified-service-desk/create-edit-hosted-control.md).  

2. On the hosted control page, select the **Related** tab, and then choose **UII Actions**.  

   ![Navigation to UII Actions for a hosted control](../unified-service-desk/media/usd-uii-actions-hosted-control.png "Navigation to UII Actions for a hosted control")  

3. Select the required UII action record, and then choose **Edit** in the command bar. This will open the UII action record.  

4. Select the **Related** tab, and then choose **Action Calls**.

5. On the action call list page, choose **+ New Action Call** on the command bar.  

6. On the **New Action Call** page, follows steps 5 and 6 in the previous section.  

### See also  
 [Manage hosted controls, actions, and events](../unified-service-desk/manage-hosted-controls-actions-events.md)   
 [Unified Service Desk Configuration Walkthroughs](../unified-service-desk/unified-service-desk-configuration-walkthroughs.md)  



[!INCLUDE[footer-include](../includes/footer-banner.md)]