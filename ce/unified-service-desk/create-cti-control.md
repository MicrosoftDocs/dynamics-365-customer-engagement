---
title: "Create a CTI Control | MicrosoftDocs"
description: "The topic explains on how to create a CTI control."
ms.custom:
  - dyn365-USD
ms.date: 08/23/2017
ms.reviewer: ""
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2013"
  - "Dynamics CRM 2015"
  - "Dynamics CRM 2016"
ms.assetid: c9e49c30-dc33-454e-b067-c90ecca6d659
caps.latest.revision: 7
author: kabala123
ms.author: kabala
manager: sakudes
---
# Create a CTI Control
To manage agent states and call states, [!INCLUDE[pn_computer_telephony_integration_cti](../includes/pn-computer-telephony-integration-cti.md)] scenarios require the following user interface (UI) controls:  

- **Agent state management control**: Displays the current state of the agent within a [!INCLUDE[pn_user_inteface_integration_uii](../includes/pn-user-interface-integration-uii.md)] desktop (such as [!INCLUDE[pn_unified_service_desk](../includes/pn-unified-service-desk.md)]. This control doesn’t need to be tied to the [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] system, but it allows you to map [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] agent states with the current agent state, which is the visual state of the agent desktop.  

- **Call control**: Provides buttons that the agent can use to make a call, answer a call, put a call on hold, transfer a call to another agent, or hang up.  

  Both of these controls are normal [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] hosted controls that inherit from either the [HostedControl](https://docs.microsoft.com/dotnet/api/microsoft.uii.csr.hostedcontrol) or [HostedWpfControl](https://docs.microsoft.com/dotnet/api/microsoft.uii.csr.aif.hostedapplication.hostedwpfcontrol) class. You can also choose to merge both the controls into a single [!INCLUDE[pn_uii_acronym](../includes/pn-uii-acronym.md)] hosted control. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use UII hosted controls with Unified Service Desk](../unified-service-desk/use-uii-hosted-controls-unified-service-desk.md)  

## Interfaces for implementing a CTI Control  
 Use the following interfaces to implement the user interface of a CTI Control.  

### ICtiAgentStateControl  
 The [ICtiAgentStateControl](https://docs.microsoft.com/dotnet/api/microsoft.uii.desktop.cti.core.ictiagentstatecontrol) interface is a specialized interface for describing a hosted control that is used for processing and/or displaying agent state information. This interface contains the [Boolean)](https://docs.microsoft.com/dotnet/api/microsoft.uii.desktop.cti.core.ictiagentstatecontrol.setagentstate\(system.guid,system.string,system.string,system.boolean\)) method that’s used to set the state of an agent.  

### IDesktopUserActionsConsumer  
 The [IDesktopUserActionsConsumer](https://docs.microsoft.com/dotnet/api/microsoft.uii.desktop.core.idesktopuseractionsconsumer) interface is not specific to [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)], but it is typically used by the CTI Controls to provide access to desktop operations. It has two members:  

- [DesktopLoadingComplete](https://docs.microsoft.com/dotnet/api/microsoft.uii.desktop.core.idesktopuseractionsconsumer.desktoploadingcomplete): Raised when the desktop has completed loading. This is raised in a separate thread from the main desktop UI thread.  

- [IDesktopUserActions)](https://docs.microsoft.com/dotnet/api/microsoft.uii.desktop.core.idesktopuseractionsconsumer.setdesktopuseractionsaccess\(microsoft.uii.desktop.core.idesktopuseractions\)): Used by the desktop loader to set a pointer to itself in the hosted control that implemented the [ICtiEnabledControlConsumer](https://docs.microsoft.com/dotnet/api/microsoft.uii.desktop.cti.core.ictienabledcontrolconsumer) interface. It is the pointer to the desktop interface (shell).  

  By implementing this interface, you get access to all user actions, as shown in the following example.  

```  
bool AppExistsInUI(string applicationName);  
bool CloseDynamicApplication(string applicationName);  
bool CloseSession();  
bool CloseSession(Session sessionToClose);  
bool CreateDynamicApplication(string applicationName);  
WorkflowData GetCurrentWorkflowState();  
bool SetFocusOnApplication(string applicationName);  
string UserDefinedCommand(string command, string request);  

```  

### ICtiEnabledControlConsumer  
 The [ICtiEnabledControlConsumer](https://docs.microsoft.com/dotnet/api/microsoft.uii.desktop.cti.core.ictienabledcontrolconsumer) interface describes a hosted control that will accept pointers to the [CtiCallStateManager](https://docs.microsoft.com/dotnet/api/microsoft.uii.desktop.cti.core.cticallstatemanager) and the [CtiAgentStateManager](https://docs.microsoft.com/dotnet/api/microsoft.uii.desktop.cti.core.ctiagentstatemanager).  

 This interface has method definitions to perform following functions:  

- [Object)](https://docs.microsoft.com/dotnet/api/microsoft.uii.desktop.cti.core.ictienabledcontrolconsumer.setmanagers\(system.object,system.object\)): Called by UII when a control that implements this interface is initialized.  

- [SessionControllerEventArgs)](https://docs.microsoft.com/dotnet/api/microsoft.uii.desktop.cti.core.ictienabledcontrolconsumer.sessioncloseevent\(microsoft.uii.csr.sessioncontrollereventargs\)): Called by UII when a session is closing.  

  The [ICtiEnabledControlConsumer](https://docs.microsoft.com/dotnet/api/microsoft.uii.desktop.cti.core.ictienabledcontrolconsumer) interface uses the [IsManagersSet](https://docs.microsoft.com/dotnet/api/microsoft.uii.desktop.cti.core.ictienabledcontrolconsumer.ismanagersset) property to set or get whether the [Object)](https://docs.microsoft.com/dotnet/api/microsoft.uii.desktop.cti.core.ictienabledcontrolconsumer.setmanagers\(system.object,system.object\)) method has been called successfully.  

<a name="Configure"></a>   
## Configure the CTI Control hosted control in Unified Service Desk  

1. Sign in to [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  

2. On the nav bar, choose **Microsoft Dynamics 365** > **Settings** > **Unified Service Desk**.  

3. On the **Unified Service Desk** page, click **Hosted Controls**.  

4. On the **Hosted Controls** page, click **New**.  

5. On the **New Hosted Control** page, specify the following values:  


   |         Field         |                                                                                                                                                                                                 Value                                                                                                                                                                                                 |
   |-----------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
   |         Name          |                                                                                                                                                                                            Specify a name.                                                                                                                                                                                            |
   |  USD Component Type   |                                                                                                                                                                                        CCA Hosted Application                                                                                                                                                                                         |
   |  Hosted Application   |                                                                                                                                                                                            Hosted Control                                                                                                                                                                                             |
   | Application is Global |                                                                                                                                                                                                Checked                                                                                                                                                                                                |
   |     Display Group     |                                                                                                                                                                                               CtiPanel                                                                                                                                                                                                |
   |        Adapter        |                                                                                                                                                                                            Use No Adapter                                                                                                                                                                                             |
   |     Assembly URI      |                                                                                                                                                          This is the name of your assembly (.dll) file that you built in the previous step.                                                                                                                                                           |
   |     Assembly Type     | This is the name of your assembly followed by a dot, and then the class name of your [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] Control. For example, if your assembly (dll) name is `MyCtiControl`, and the name of the class of your [!INCLUDE[pn_cti_acronym](../includes/pn-cti-acronym.md)] project is `CtiControl`, type the following in this field: `MyCtiControl.CtiControl`. |


6. Choose **Save** to create the hosted control.  

### See also  
 [Considerations for creating a CTI adapter for Unified Service Desk](../unified-service-desk/consideration-creating-cti-adapter-unified-service-desk.md)   
 [Create a CTI Connector](../unified-service-desk/create-cti-connector.md)   
 [Create a CTI Desktop Manager](../unified-service-desk/create-cti-desktop-manager.md)   
 [UII Computer Telephony Integration (CTI) framework](../unified-service-desk/uii-computer-telephony-integration-cti-framework.md)
