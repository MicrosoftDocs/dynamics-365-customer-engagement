---
title: "Configure routing to preferred agents | MicrosoftDocs"
description: "Configure settings to route work items to preferred agents in Customer Service."
ms.date: 08/25/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Configure routing to preferred agents (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

For a more personalized experience, Dynamics 365 Customer Service gives you the option to route work items from a specific contact to the customer's preferred agents or relationship managers.

Configure contacts and their preferred agents in the Customer Service admin center. If a contact isn't configured, you can't assign a preferred agent to the contact.

To find the preferred agent for an incoming work item, the contact should be identified. For more information, see the **Channel-specific support for identifying a contact record** section.

In the preview release, you can map agents to contacts only.

> [!IMPORTANT]
> In the preview release, if the Omnichannel solution is already installed in your organization, you must perform the steps in [Create custom data in organizations with existing Omnichannel solution](#create-custom-data-in-organizations-with-existing-omnichannel-solution) to route records to the preferred agents successfully.

## Configure preferred agent for contacts

Make sure that the agent you intend to assign to a contact is a member of the queue to which a work item will be routed.

1. In the Customer Service admin center site map, select **Routing**.

1. On the page that appears, next to **Preferred agent routing (preview)**, select **Manage**.

1. Turn on **Enable preferred agent routing**.

1. Select who should get the work item if preferred agent is unavailable:

   - **Next best agent based on assignment logic**: The work item will be routed based on the assignment rules. We recommend that you use this option for live chat conversations and voice channel calls.

   - **No one. Let the work remain unassigned in the queue**: The work item will remain in the queue until an agent picks it up or it's manually assigned to another agent. We recommend that you use this option for asynchronous channel conversations.

1. Select contacts and their preferred agents in the **Preferred agents matrix** area by doing the following steps:

1. Select **Add a contact** to add a contact.

1. In **Contact full name**, enter a contact name, and select a value from the dropdown list.

1. Select **Add user** to map agents to the contact.

   Only agents who are configured as bookable resources and assigned the agent role persona are displayed in the list of users.

   You can map up to three preferred agents to a contact. The order in which you map the agents is the order in which they'll receive a work item if an agent earlier in the list isn't available.

1. Save and close.

  :::image type="content" source="media/preferred-agents-mapped-view.png" alt-text="Screenshot of the Preferred agent routing settings page, showing contacts and their preferred agents.":::

### Routing diagnostics and preferred agent settings

If you've turned on routing diagnostics, a work item's diagnostics page includes information about preferred agent routing under **Agent assignment trace**. The **Assignment criteria** section shows whether the setting is turned on. The **Assignment trace** section displays the reason information. More information: [Diagnostics for unified routing](unified-routing-diagnostics.md)

## Update contacts and preferred agents

In **Preferred agents matrix**, use the edit and remove options to modify contacts and their preferred agents.

For each contact, you can map up to three agents and remove any two. At least one agent remains mapped to a contact.

### Identify contacts in supported channels

For the supported channels, use the information mentioned in the following table to identify customers as contacts.

|Channel|Customer record|
|-------|---------------|
|Record |<ul><li>**Case**: Use the **Customer** field to store the contact ID.</li><li>**Email, phone, fax, letter, appointment**: Use the **Regarding** field to store the contact ID. </li></ul>|
|**Digital messaging**: Chat, voice, and other channels|<ul><li> **Chat**: [Authenticated users are automatically identified as contacts](record-identification-rule.md). For unauthenticated users, use the pre-conversation survey to set the survey question name as **Name**.</li><li>**Voice**: Authenticated with the phone number.</li><li>Other channels: [Social profile](card-support-in-channels.md#support-for-social-profiles). </li></ul> |

### Use APIs to configure, update, and delete preferred agent records 

> [!IMPORTANT]
> We recommend that you add the contact and preferred agent routing through the Preferred agent routing (preview) page.

If you want to configure, update, or delete contact and their preferred agents in the Preferred agent matrix, you must perform the steps in this section.

1. Go to the Preferred agent routing (preview) on the Customer Service admin center app, and then open the developer tools window.
1. In the developer console window, run the code for the following actions depending on your business requirements.

   
- **Create**
    
     Use the following code to map a contact to their preferred agents. Ensure that these conditions are met before running the script:
      - You can map three agents to a contact.
      - You cannot add duplicate records.
      - The preference rating can only be a positive value between 1 to 3.
      - contact-id and systemuser-id can't be NULL.
   
    ```js
    var contactid = "contact-id"; // contact's id
    var systemuserid = "systemuser-id"; // agent's id
    var data = {"msdyn_name": "Test","msdyn_recordId_contact@odata.bind": "/contacts("+contactid+")",
    "msdyn_systemuserid@odata.bind": "/systemusers("+systemuserid+")",
    "msdyn_preferencerating": "1",
    "msdyn_recordtype": 192350001};
  
    //Create record XRM call 
         Xrm.WebApi.createRecord("msdyn_preferredagent", data);
            // creates a preferred agent mapping with the specified data
        
    ```

- **Delete**
    
     Use the following code to delete an agent mapped to the contact.

    ```js
  
  
       //Delete record XRM call 
         Xrm.WebApi.deleteRecord("msdyn_preferredagent", "preferred-agent-id-here"); 
            // Deletes a mapped agent with the specified id

    ```

 - **Update**
    
     Use the following code to update an agent mapped to the contact. Ensure that these conditions are met before running the script:
      - You cannot add duplicate records.
      - The preference rating can only be a positive value between 1 to 3.

    ```js
  
       var data = {"msdyn_recordId_contact@odata.bind": "/contacts(contact-id)"}; //contact-id is 
       //Update record XRM call 
        Xrm.WebApi.updateRecord("msdyn_preferredagent", "preferred-agent-id", data);
            // Updates a mapped agent with the specified id

    ```

### Roles and permissions for preferred agent routing

You must have one of the following roles to configure preferred agent routing.

- **For Customer Service**: CSR Manager
- **For Omnichannel for Customer Service**: Omnichannel administrator

You must be able to access the Contact entity. More information: [Contact](/customerengagement/on-premises/developer/entities/contact?view=op-9-1&preserve-view=true)

If you have a custom role, you must also have access to the following entities:

- [msdyn_preferredagent](developer/reference/entities/msdyn_preferredagent.md)
- [msdyn_preferredagentcustomeridentity](developer/reference/entities/msdyn_preferredagentcustomeridentity.md)

### Create custom data in organizations with existing Omnichannel solution

If the Omnichannel solution is already installed in your organization and you want to use the preferred agent settings for routing records, such as the case or email record, you must perform the steps in this section.

1. Go to the Customer Service admin center app, and enter the following URL in the address bar to make an oData call and determine if data exists.

    `OrgURL`/api/data/v9.0/msdyn_preferredagentroutedentities  

1. If no data is displayed, then in the developer console window, run the code for each of the following record types depending on the records that you want to route.

- **Case**

    ```js
    var data = {
        msdyn_customeridentifiername: 'customerid',
        msdyn_name: 'Preferred Agent Routed Entity',
        msdyn_preferredagentroutedentityid: '90ef68ce-67d7-ec11-a7b6-000d3a9c947d',
        msdyn_routedentityname: 'incident'
    }
    //Create record XRM call
    Xrm.WebApi.createRecord("msdyn_preferredagentroutedentity", data).then(
        function success(result) {
            console.log("Record created with ID: " + result.id);
            // perform operations on record creation
        },
        function(error) {
            console.log(error.message);
            // handle error conditions
        }
    );
    ```

- **Email**

    ```js
    var data = {
        msdyn_customeridentifiername: 'regardingobjectid',
        msdyn_name: 'Preferred Agent Routed Entity',
        msdyn_preferredagentroutedentityid: '0fa834dc-79d7-ec11-a7b6-000d3a9c947d',
        msdyn_routedentityname: 'email'
    }
    //Create record XRM call 
    Xrm.WebApi.createRecord("msdyn_preferredagentroutedentity", data).then(
        function success(result) {
            console.log("Record created with ID: " + result.id);
            // perform operations on record creation 
        },
        function(error) {
            console.log(error.message);
            // handle error conditions 
        }
    ); 
    ```

- **Appointment**

    ```js
    var data = {
        msdyn_customeridentifiername: 'regardingobjectid',
        msdyn_name: 'Preferred Agent Routed Entity',
        msdyn_preferredagentroutedentityid: 'b78386c4-79d7-ec11-a7b6-000d3a9c947d',
        msdyn_routedentityname: 'appointment'
    }
    
    //Create record XRM call 
    Xrm.WebApi.createRecord("msdyn_preferredagentroutedentity", data).then(
        function success(result) {
            console.log("Record created with ID: " + result.id);
            // perform operations on record creation 
        },
        function(error) {
            console.log(error.message);
            // handle error conditions 
        }
    );
    ```

- **Letter**

    ```js
    var data = {
        msdyn_customeridentifiername: 'regardingobjectid',
        msdyn_name: 'Preferred Agent Routed Entity',
        msdyn_preferredagentroutedentityid: 'c9896fa2-98d7-ec11-a7b6-000d3a9c947d',
        msdyn_routedentityname: 'letter'
    }
    
    //Create record XRM call 
    Xrm.WebApi.createRecord("msdyn_preferredagentroutedentity", data).then(
        function success(result) {
            console.log("Record created with ID: " + result.id);
            // perform operations on record creation 
        },
        function(error) {
            console.log(error.message);
            // handle error conditions 
        }
    );
    ```

- **Fax**

    ```js
    var data = {
        msdyn_customeridentifiername: 'regardingobjectid',
        msdyn_name: 'Preferred Agent Routed Entity',
        msdyn_preferredagentroutedentityid: '43c91071-98d7-ec11-a7b6-000d3a9c947d',
        msdyn_routedentityname: 'fax'
    }
    
    //Create record XRM call 
    Xrm.WebApi.createRecord("msdyn_preferredagentroutedentity", data).then(
        function success(result) {
            console.log("Record created with ID: " + result.id);
            // perform operations on record creation 
        },
        function(error) {
            console.log(error.message);
            // handle error conditions 
        }
    );
    ```

- **Phone call**

    ```js
    var data = {
        msdyn_customeridentifiername: 'regardingobjectid',
        msdyn_name: 'Preferred Agent Routed Entity',
        msdyn_preferredagentroutedentityid: '307eef45-98d7-ec11-a7b6-000d3a9c947d',
        msdyn_routedentityname: 'phonecall'
    }
    
    //Create record XRM call 
    Xrm.WebApi.createRecord("msdyn_preferredagentroutedentity", data).then(
        function success(result) {
            console.log("Record created with ID: " + result.id);
            // perform operations on record creation 
        },
        function(error) {
            console.log(error.message);
            // handle error conditions 
        }
    ); 
    ```
 
### See also

[Overview of unified routing](overview-unified-routing.md)  
[Configure queues](queues-omnichannel.md)  
