---
title: "Considerations for creating a CTI adapter for Unified Service Desk | MicrosoftDocs"
description: "The topic provides information on things to consider while creating a computer telephony integration (CTI) adapter to make it work with Unified Service Desk."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 12/31/2019
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
# Considerations for creating a CTI adapter for Unified Service Desk

[!INCLUDE[cc-data-platform-banner](../includes/cc-data-platform-banner.md)]

This topic provides information on things to consider while creating a computer telephony integration (CTI) adapter to make it work with [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].  

<a name="UISpec"></a>   
## CTI Control (softphone user interface) specification  
 To ensure that softphone and [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] user interface components will interoperate with [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)], the following conditions should be met:  

- Controls are created using [!INCLUDE[pn_ms_Windows_Presentation_Foundation](../includes/pn-ms-windows-presentation-foundation.md)], and are derived from the [DynamicsBaseHostedControl](/dotnet/api/microsoft.crm.unifiedservicedesk.dynamics.dynamicsbasehostedcontrol) class.  

- [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] controls are placed on `CtiPanel`  panel in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. The height of the control should be 23 to fit in `CtiPanel`. Larger controls may be used.  

- Multiple [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] control or user interface components can exist on `CtiPanel`. This is a horizontal stack panel so if you have multiple controls on this panel, they appear next to each other.  

<a name="Actions"></a>   
## Actions supported for telephony functions  
 A feature of [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] is the ability to configure advanced application designs without programming. This kind of functionality is exposed through the concept of actions in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. To support the idea of extending telephony control functions to buttons, agent scripts, and links in hosted applications, the system relies on actions being defined for capabilities exposed by the [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] adapter. This is done by exposing UII Actions in the [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] Desktop Manager hosted control of your [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] component. Each of these actions gives the administrator more control over the behavior of the application.  

We recommend that the following actions be defined and implemented in the **CTI Desktop Manager** hosted control.  

|Action|Description|  
|------------|-----------------|  
|Dial|The number to call. If this parameter is not provided, a dialpad is displayed for the user to enter digits.<br /><br /> If the call is active, this action dials the digits as if for an IVR.|  
|Transfer| Initiate or complete a transfer. If a transfer has been initiated but not completed, this action transfers the call and ignores the parameter. If an active call is present, this action places the call on hold and makes a new call by passing the context data.|  
|Conference| Initiate or complete a conference. If a conference has been initiated but not completed, this action opens the call in conference mode and ignores the parameter. If an active call is present, it places the call on hold and makes a new call by passing the context data.|  
|Hangup| Ends the current call.|  

> [!NOTE]
>  If these actions are supported by the **CTI Desktop Manager** hosted control, users will be able to trigger this functionality from a wide variety of locations within the application, thus providing a tightly integrated agent experience.  

<a name="CTIScreenPop"></a>   
## CTI screen pop  
 You must ensure the following while designing [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] screen pops in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)].  

- The following values must be populated in the `CallInfo` parameter of the [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)]request.  


  | Parameter |                                                                                               Description                                                                                               |
  |-----------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
  | direction | Specify “inbound” for incoming calls and “outbound” for outgoing calls.<br /><br /> Is used by the system to allow the admin to specify different behavior depending on the direction of the call. |
  | Calltype  |                                                                    Specify “phonecall” for voice calls and “chat” for chat sessions.                                                                    |


- [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] adapters should not automatically create activities in Microsoft Dataverse because this is not always the required behavior. Therefore, this should be left for the system administrators to configure.  

    ```csharp  
    try  
    {  
      FireRequestAction(new RequestActionEventArgs("*", CtiLookuprequest.CTILOOKUPACTIONNAME,GeneralFunctions.Serialize<CtiLookupRequest>(data)));  
    }  
    ```  

  > [!NOTE]
  >  It is assumed that the `CTILOOKUPACTIONNAME` be used for calling the [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] action, and that the application name will be "*", as shown in the example code.  

> [!IMPORTANT]
>  It is possible to create [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] adapters for [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] that don’t follow the [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)][!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] framework.  

<a name="CTISearch"></a>   
## CTI search  
 [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] searches are done using FetchXML in Dataverse. You can search using any data passed in any parameter from [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] against any field in your entity of choice in Dataverse. Searches are performed one rule at a time until a match is found. After a match to a window navigation rule in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] is found, it will follow the guidance configured in the navigation rule for the next step. Typically, a rule is set up to open a session around the activity, and optionally display the activity in a tab. For more information about how to configure a window navigation rule to perform a [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)]search, see [Walkthrough: Use generic listener adapter for CTI events](../unified-service-desk/walkthrough-use-the-generic-listener-adapter-for-cti-event-routing.md).  

 Let us configure a sample CTI search rule using the window navigation rule in [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. For more information about the window navigation rule, see [Use window navigation rules in Unified Service Desk](../unified-service-desk/use-window-navigation-rules-unified-service-desk.md).  

1. Sign in to Unified Service Desk Administrator.

2. Select **Window Navigation Rules** under **Basic Settings**.  

3. Select **New**.  

4. Type a name and order for the window navigation rule. In the **From** box, select your [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] Desktop Manager hosted control.  

5. After you have selected your [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] Desktop Manager, the [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] options will be displayed starting with an initiating activity. The initiating activity field should contain the entity type passed from the [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] adapter. For example, it can be phonecall, chat, or email. One rule handles only one type of activity from the CTI server.

6. Select **Save**, and enable the fields required for the next steps.  

7. Under **CTI Searches**, select the search icon, and then select **New** in the search box to define a new search criteria using the FetchXML query.  

8. In the **New CTI Search** screen, specify a name and order for the CTI search query. The direction field is Inbound or Outbound and is used to search against only a specific direction of CTI event. This direction is passed from the [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] adapter.  

    Enter the required FetchXML query for the [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] search. Use the advanced find feature in Dataverse to create your initial search, and then download the FetchXML. The key field is often not available in Dataverse Advanced Find search, so you may find that you need to add that condition manually to the XML after you have exported it. You should also select the attributes that you’re interested to show up in the [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] context. These show up immediately rather than be populated after pages load in the display like the other types of data parameters. Once you have the FetchXML you want, paste the text into the **FetchXML** box, and save the [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] search rule.  

   ![New CTI search in Unified Service Desk](../unified-service-desk/media/usd-cti-search-rule-2.PNG "New CTI search in Unified Service Desk")  

9. The system will search each of your [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] search items for the rule. This can be thought of like a cross-entity search. The conditions relate to the final result set and might, in the case of multiple results handling, indicate that one or more records were found from more than one entity type.  

     Below the search list are three conditions and selections used to indicate what is to be done in each case.  

    |Condition|Description|  
    |---------------|-----------------|  
    |No Matches|What the system should do if no matches were found across all the searches specified in the rule.|  
    |Single Match|What the system should do when only one record is found as a result of the combined searches.|  
    |Multiple Matches|What the system should do if more than one result was found across all the searches.|  

     For each condition, there is a decision to be made regarding what to do.  


   |                 Decision                  |                                                                                                                                                                           Description                                                                                                                                                                            |
   |-------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
   |       Create Session then Do Action       |                                                                                                                    Creates a new session before running a configured action. This action will be run within the context of this new session.                                                                                                                    |
   | Create Session, Load Match then Do Action |                                                 Creates a session, then loads the match into a tab or Entity Search based upon the selection in the Result Tab of the model-driven apps form. Finally, it calls an action. This option is only valid for single match.                                                 |
   |                 Do Action                 | Tells the system to do nothing with the result, but optionally call a configured action specific to this condition. You can call the `FireEvent` action on Global Manager hosted control, if you want to call multiple actions in sequence as a result of this. This action will be run in the context of the current session. No new session will be created. |
   |                 Next Rule                 |                                                                                              Tells the system to ignore the rest of the processing of this rule and to look for other rules that may match. New searches will be performed against subsequent rule.                                                                                              |

    > [!IMPORTANT]
    >  Any time the system does not take the “Next Rule” option configured in your navigation rule, it will also run the configured actions on the navigation rule itself. If you want to run rules only in specific cases, you should use the action in the corresponding section. For general purpose actions that should run regardless of the choice made, you might enter them in the actions list for the navigation rule.

<a name="chat"></a>   
## Special features of chat events  
 When responding to chat events, some special things occur in the system. It is assumed that the [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] event data parameter “`CTIDESKTOPMANAGERCONTROL`” value is populated with the [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] Desktop Manager hosted control name and it supports the `SendIM` action. If the [CALLTYPE](/dotnet/api/microsoft.uii.desktop.cti.core.lookuprequestkeys.calltype) passed into the [CtiLookupRequest](/dotnet/api/microsoft.uii.desktop.cti.core.ctilookuprequest) is “Chat”, [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)] will show an extra button on the agent scripting user interface. If the agent selects this button, it will attempt to invoke the `SendIM` action on the [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] Desktop Manager hosted control specified in the `CTIDESKTOPMANAGERCONTROL` control. It will pass the text of the agent script to this action, and it is assumed that the [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] Desktop Manager hosted control will write this text to the chat output.  

### See also  
 [UII Computer Telephony Integration (CTI) framework](../unified-service-desk/uii-computer-telephony-integration-cti-framework.md)   
 [CTIDESKTOPMANAGERCONTROL](/dotnet/api/microsoft.uii.desktop.cti.core.lookuprequestkeys.ctidesktopmanagercontrol)   
 [Create a CTI Desktop Manager](../unified-service-desk/create-cti-desktop-manager.md)   
 [Use window navigation rules in Unified Service Desk](../unified-service-desk/use-window-navigation-rules-unified-service-desk.md)   
 [Walkthrough: Use generic listener adapter for CTI events](../unified-service-desk/walkthrough-use-the-generic-listener-adapter-for-cti-event-routing.md) 


[!INCLUDE[footer-include](../includes/footer-banner.md)]
