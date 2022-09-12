---
title: "Use API calls to create, update, delete preferred agent routing | MicrosoftDocs"
description: "API calls to configure preferred agents in Customer Service."
ms.date: 08/25/2022
ms.topic: article
author: gandhamm
ms.author: mgandham
manager: shujoshi
---

# Use API calls to create, update, or delete preferred agent routing mapping

You can add multiple preferred agents to contact records in bulk using the create API call. If you are running the script to add multiple preferred agent routing records, ensure the following:

- Map only 3 agents to a contact. If you add more than three agents, though the application displays all the mapped agents, work items are routed only to the top three agents. Agents are ordered the based on the preference rating. If agents have the same preference rating, the application orders the agents based on the time when the record was created.
- Avoid adding the same agent to a contact multiple times.
- The preference rating must be a positive number between 1 and 3
- System user id and contact id must not be NULL.

> [!IMPORTANT]
> We recommend that you add the contact and preferred agent routing through the Preferred agent routing (preview) page. See: [Configure routing to preferred agents](configure-preferred-agent.md)

### Roles and permissions for preferred agent routing

You must have one of the following roles to configure preferred agent routing.

- **For Customer Service**: CSR Manager
- **For Omnichannel for Customer Service**: Omnichannel administrator

You must be able to access the Contact entity. More information: [Contact](/customerengagement/on-premises/developer/entities/contact?view=op-9-1&preserve-view=true)

If you have a custom role, you must also have access to the following entities:

- [msdyn_preferredagent](developer/reference/entities/msdyn_preferredagent.md)
- [msdyn_preferredagentcustomeridentity](developer/reference/entities/msdyn_preferredagentcustomeridentity.md)

### Create, update, delete API calls

Perform the steps in this section to create, update, or delete preferred agent mapping through API calls:

1. Go to the Customer Service admin center app and then open the developer tools window.
1. In the developer console window, run the code for the following actions depending on your business requirements. 

- **Create**

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

- **Update**

    ```js
   var data = {"msdyn_recordId_contact@odata.bind": "/contacts(contact-id)"}; //contact-id is 
   //Update record XRM call 
    Xrm.WebApi.updateRecord("msdyn_preferredagent", "preferred-agent-id", data);
        // Updates a mapped agent with the specified id

    ```

- **Delete**

    ```js
      //Delete record XRM call 
     Xrm.WebApi.deleteRecord("msdyn_preferredagent", "preferred-agent-id-here"); 
        // Deletes a mapped agent with the specified id

    ```


 
### See also

[Overview of unified routing](overview-unified-routing.md)  
[Configure queues](queues-omnichannel.md)  
