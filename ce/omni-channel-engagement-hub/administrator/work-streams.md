---
title: "Create work streams"
description: 
keywords: ""
author: anjgupta
ms.author: anjgup
manager: shujoshi
applies_to: 
ms.date: 11/13/2018
ms.service: 
ms.topic: article
ms.assetid: 5e6285ee-4b79-473d-b920-d1fab636c82e
ms.custom: 
---
# Create and manage work streams

Work streams define the settings and properties for a specific source or originating point from where the customer requests or queries can come. For example, if the requests are originating from two chat portals, you can create two different work streams for each of them. If conversations are created as case records, you can create a separate work stream for the same.

All work streams are associated with unique channels. Channels can be defined for Chats, Entities, etc. A work stream cannot be associated with more than one channel.
Omni-channel Engagement Hub has out of the box work streams defined, but as an administrator, you can define new work streams to introduce a new source.

There are 2 types of work streams:
- **Live Chat work stream**
- **CDS Entity work stream**

## Live Chat work stream
While setting up Live Chat work streams, the following properties are defined:

> [!NOTE]
> The following properties are applicable for a Live Chat work stream. To know more about the CDS work stream and its properties, see [CDS entity work stream](#cds-entity-work-stream).  

- **Channels**. Channels in Omni-channel Engagement Hub are defined as a medium through which a customer can reach out and engage with the agents. For example, a customer can chat with an agent through the chat channel. As an administrator, you can select the channel the work stream is created for. 

  > [!NOTE]
  > In this preview, we are supporting work streams to be defined on Chat and Entity channels.

- **Allowable Presence**. Allowable presence helps in assigning a workstream to only those agents whose presence is one of the available presence associated with the workstream. 

  **More information**: [Configure Presence and Custom Presence](presence-custom-presence.md) 

 - **Capacity**. When a conversation from a work stream is assigned to an agent, it consumes some capacity. Those units of capacity are defined as capacity in the work stream. For example, a conversation in the work stream Chat from Portal carries a capacity of 20 units. When this conversation is assigned to an agent, it consumes 20 units of agent’s capacity.

- **Agent association**. Agents are associated with a work stream to receive conversations only from that work stream. 

- **Work distribution mode and context attributes**. The context attributes can vary for each work stream. For example, for a chat conversation, context attributes include browser, IP address, answers to pre-chat questions, customer ID (for authenticated chat). These variables can then be used to define routing rules to channelize conversations into different queues.

  > [!NOTE]
  > Work stream is the area where context variables can be declared and defined so that the omni-channel system understands the kind of conversation it will receive. Conversations are pre-loaded with certain context attributes. Based on the context attributes, the system takes logical decisions and distributes the conversations to the correct omni-channel queue or agent. For this preview, context variables are applicable only for Live Chat.


 - **Record Identification Rules**. Record identification rules help identify and assist customers better by viewing their details in a Customer 360 page. When an incoming conversation request is received, a notification pops up with contextual information for the request. When an agent accepts the incoming notification, the Customer 360 page opens with the details of the customer and case.

    **More information**: View Customer 360 for an incoming engagement request  

    > [!NOTE]
    > For this preview, you can set up record identification rules while creating a new work stream. These rules are further mapped with a limited set of pre-chat questions. See Record Identification Rule in Step 2 of Create a new work stream. </br>
    For an incoming conversation, as a customer completes a pre-chat survey, the information can then be used to identify the customer. 

- **Routing rules**. Routing rules are configured for each work stream so that conversations can be distributed to the right queues. 

   **More information**: [Create and manage routing rules in Omni-channel](routing-rules.md) 

- **Maximum Concurrency.** Using maximum concurrency, you can set the maximum number of conversations that can be assigned to an agent’s work list from a work stream.

- **Auto-close after inactivity**. Time after which a conversation is moved from waiting state to closed state due to inactivity.

## Create a new live chat work stream

Follow these steps to create a new live chat work stream:

1. In the omni-channel site map, select **Work Distribution Management > Work Streams**. </br>
The **Active Work Streams** view is displayed. 

2. Select **New** in the command bar to create a new work stream.  

  - In the **Summary** tab of the new work stream page:

    - Provide the following information in the **General information** section:
      - **Name**. Name of the work stream
      - **Capacity**. Units of capacity required to process a conversation of this work stream
      - **Stream Source**. Channels supported for this work stream. Choose from Live Chat or CDS Entity.

         **More information**: [CDS entity work stream](#cds-entity-work-stream)

      - **Max Concurrency**. Maximum concurrent sessions for conversations of this work stream
      - **Auto-close after inactivity**. Time after which a conversation is moved from waiting state to closed state due to inactivity.
      - **Record Identification Rule**. Provide the following code snippet in the text box. This snippet helps configure record identifications rules for the work stream.

  ```csharp
<RecordIdentificationRuleSet>  
<RecordIdentificationRule>         
<PrimaryEntity LogicalCollectionName="accounts" PrimaryKeyAttribute="accountid" PrimaryNameAttribute="name" />        
 <fetch version="1.0" output-format="xml-platform" mapping="logical" top="2">             
<entity name="account">                 
<attribute name="accountid" />                 
<attribute name="name" />                 
<filter type="and">
<condition attribute="name" operator="eq" value="${Name}" />                       
<condition attribute="emailaddress1" operator="eq" value="${Email}" />                     
<condition attribute="telephone1" operator="eq" value="${Phone}"/>                 
</filter>             
</entity>         
</fetch>         
<ContextKey name="msdyn_account_msdyn_ocliveworkitem_Customer" />     
</RecordIdentificationRule>     
<RecordIdentificationRule>         
<PrimaryEntity LogicalCollectionName="contacts" PrimaryKeyAttribute="contactid" PrimaryNameAttribute="fullname" />         
<fetch version="1.0" output-format="xml-platform" mapping="logical" top="2">             
<entity name="contact">                 
<attribute name="contactid" />                 
<attribute name="fullname" />                 
<filter type="and">                     
<condition attribute="contactid" operator="eq" source="msdyn_msdyn_ocliveworkitem_msdyn_livechatengagementctx_liveworkitemid" value="${msdyn_portalcontactid}" /> 
<condition attribute="fullname" operator="eq" value="${Name}" />                    
<condition attribute="emailaddress1" operator="eq" value="${Email}" />                     
<condition attribute="telephone1" operator="eq" value="${Phone}" />                 
</filter>             
</entity>         
</fetch>         
<ContextKey name="msdyn_contact_msdyn_ocliveworkitem_Customer" />     
</RecordIdentificationRule>     
<RecordIdentificationRule>         
<PrimaryEntity LogicalCollectionName="incidents" PrimaryKeyAttribute="incidentid" PrimaryNameAttribute="title" />         
<fetch version="1.0" output-format="xml-platform" mapping="logical">             
<entity name="incident">                 
<attribute name="incidentid" />                 
<attribute name="title" />                 
<filter type="and">                     
<condition attribute="ticketnumber" operator="eq" value="${CaseNumber}" />                 
</filter>             
</entity>         
</fetch>         
<ContextKey name="msdyn_incident_msdyn_ocliveworkitem" />     
</RecordIdentificationRule> 
</RecordIdentificationRuleSet>
```

   >[!NOTE]
   >For each new work stream, update the condition variable values and ensure that the names are unique and mapped with pre-chat questions as given below. For example, after a workstream is created, if it is linked to context variable: Name1 and Phone1, then we need to modify the condition variable value from {Name} to {Name1} and {Phone} to {Phone1}.

   >[!IMPORTANT]
   >For the above record identification rules to work, you must create the following questions for the pre-chat survey. </br>

- Authenticated chat

  |Question name  |Answer type | Question text|
  |---------|---------|---------|
  |CaseNumber    |   Multiple lines      |Case Number|
  |    |         ||

- Unauthenticated chat

  |Question name  |Answer type | Question text|
  |---------|---------|---------|
  |CaseNumber    |   Multiple lines      |Case Number|
  |  Name  |     Single line    |Name|
  |  Email  |         Single line|Email|
  |   Phone |    Single line     |Phone|
  |    |         ||

    For information on how to create questions and use them in pre-chat survey, see Set up a question library and Set up a pre-chat survey.

    > [!NOTE]
    > Ensure that the question name is unique, and is used in the XML snippet as is, else the record identification rule will not work. You can provide question text as per your requirement. 

   - Select **Save** to save the work stream.

   - In the **Work distribution** section: 
     - Choose whether the work distribution mode should be **Push** or **Pick**.
     - Select the type of notification setting from the **Notification** drop-down list.
     - Select the time for **Screen pop timeout** from the drop-down list.

       > [!NOTE]
       > **Notification** and **Screen pop timeout** are not supported in this preview and will be made available in a future release.

      - **Context variables** help the omni-channel system understand the kind of conversation it will receive. Quickly create a new context variable for a work stream in the **Context variables** section. 
      - Select **New** and provide the **Name** and the **Type** of the variable in the **Quick Create** flyout. 
      You can edit, activate, deactivate, or delete a context variable by selecting it from the grid.

 - Routing rules help to correctly route the conversations to the agents or queues. Define the routing rules in the **Routing Rule Item** tab:

    - Select **Add new Rule Item** to add a new routing rule item.  
    - In the **General information** section of the **General** tab, provide the following information: 
      - **Name**. Name of the rule item
      - **Work Stream** is auto populated
      - **Queue**. Look up a queue or select New to add a new queue. </br> **More information**: [Create a new omni-channel queue](queues-omni-channel.md#create-a-new-omni-channel-queue)
      - **Description**. A brief description of the rule item.

     - In the **Condition** section, provide the conditions for the omni-channel rule. Based on the conditions defined, the conversations are routed to the correct agents or queues. When you define conditions for the omni-channel routing rules, you can choose from:
        - Entity
        - Attribute
        - Operator
        - Value

       So, for an entity, you can choose from a set of attributes, operators, and values related to the entity. 
       With the help of using appropriate conditions in the routing rules, you can achieve many more routing combinations to route conversations, like:
         - Incoming customer chat request from the portal with specific pre-chat answers should be routed to a specific queue.
         - Incoming custom entities like Change_Requests, etc. should be routed to omni-channel queue with live agents.

           **More information**: [Create and manage routing rules in Omni-channel](routing-rules.md)


   - Select **Save** to save the rule.

 - In the **Agents** tab, select **Add Existing User** to add agents to the work stream. Select the agents you want to add from the **Lookup Records flyout** menu and select **Add**. 
 You can change the view and select users from other views by selecting Change View.

3. Select **Save** to save the live chat work stream.

Once all settings are defined, the work stream is now ready to receive conversations so that the agents can start working on them.

All active work streams can be seen in the **Active Work Streams** view. To be able to use a work stream, you should activate it. To activate a work stream so that it can receive conversations, select a work stream record from the **Active Work Streams** view and select **Activate** from the command bar.

You can deactivate a work stream if you do not want it to receive conversations. Select a work stream record from the **Active Work Streams** view and select **Deactivate** from the command bar.  All deactivated work streams can be seen in the **Inactive Work Streams** view. You can re-activate the work streams in the **Inactive Work Streams** view.

## CDS entity work stream 

CDS entity work stream helps collect conversations from the CDS system and route them to the omni-channel ecosystem. This way, omni-channel agents can take up issues coming from CDS.  For example, cases from CDS can be routed to omni-channel so that agents can assist customers who have opened high priority cases and need help quickly.

> [!NOTE]
> For this preview, CDS entity work stream can collect and route only cases from the CDS system. 

The omni-channel system communicates with the CDS  with the help of **Microsoft Flow**. The omni-channel system can accept cases from CDS, only when the following steps are configured in the **Omni-channel Engagement Hub** and **Flow**:

#### In omni-channel
1. Ensure that the **Stream Source** while configuring a new work stream in omni-channel is set to **CDS Entity**.
2. Note down the ID of the work stream.
3. In the **Work Stream Entity Configuration** section, add the entity to be routed by selecting **Add New Work Stream Entity Configuration**. 
4. Activate the entity by selecting the it  and selecting **Activate** from the ellipsis menu.
5. Set up routing rules, agents, and queues for this work stream.

#### In Microsoft Flow

1. Go to portal.office.com. Select Flow from the list of apps.
2. Navigate to **Settings > Custom Connectors**. Create a new custom connector by selecting **Create Custom Connector**.
3. Select **Import an API file** in the **Create Custom Connector** menu.

   > [!NOTE]
   > Go to the Download Center and save the file at your local machine. Provide your environment name in the custom connector name and file location from your local machine while importing and this API file and select **Continue**.

4. Provide the custom connector name.
5. Select **Test**. You will get a prompt that you must create a custom connector before testing. Select **Create connector**.
6. Once the connector is created, create a new connection by selecting **New Connection**.
A new connection is created and selects the connection name automatically.
7. Provide values as given in the following screenshot and test the connection by selection **Test Operation**.

     - **Organization ID**. Select your organization ID.
     - **Live work stream ID**. Select your live work stream ID.
     - **Entity logical name**. Logical name of the CDS entity that needs to be routed
     - **Entity set name**. Entity name of the CDS entity that needs to be routed. (Typically this ends like a plural name of the logical name)
     - **Record ID**. Use the Dynamic Content and select the ID field
     - **Relationship name with live work stream**. Logical name of the entity's regarding relationship name with Live conversation
     - **Record details**. Using the Dynamic content. Select value-key-item-output.


   > [!IMPORTANT]
   > The request will fail initially with a 404 error. Test the operation until you get a 202 response. Usually it takes around 15 minutes for the connection to start working.

8. Once the connection is established with a 202 response, navigate to **My Flows**.
9. Create a flow by selecting **Create from Blank**.
10. Update the **Name** for the flow and provide the environment name.
11. Search and select the trigger **Dynamics 365 - When a record is created**.
12. Select your org and entity name that needs to be routed.
13. Select **New Step > Add an action**. Search for your custom connector and select the action.
14. Provide the values as given in the following screenshot:

    - **Entity Logical Name**. Logical name of the CDS entity that needs to be routed.
    - **Entity Set Name**. Entity name of the CDS entity that needs to be routed. (Typically this ends like a plural name of the logical name)
    - **Record Id**. Use the Dynamic Content and select the ID field.
    - **Name of Entity Relationship With**. The logical name of the entity's regarding relationship name with Live conversation (for Incident *incident_msdyn_ocliveworkitems*).
    - **Record Details**. Using the Dynamic content. Select value-key-item-output.
    - **Organization ID**. Select your organization ID.
    - **Live Work Stream ID**. Select your live work stream ID.

15. After all the information is complete, select Test to test the flow. Select I’ll perform the trigger action and save the flow.
To test the flow with the entity:

    1. Create a new record for the entity you have chosen to be routed. </br>
    2. Keep the record form filled in CDS. As soon as you click on **Save & test**, go to CDS and save the record immediately (else the test operation may miss the record). 
On successful run you should see the screen below.

The set up is created successfully, and you can now route CDS entities to the omni-channel system using Flow.




