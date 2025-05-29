---
title: Add multiple preferred agent records 
description: Learn how to add multiple preferred agents to contact records in Customer Service.
author: neeranelli 
ms.author: nenellim  
ms.reviewer: nenellim
ms.topic: how-to 
ms.collection: 
ms.date: 01/28/2025
ms.custom: bap-template 
---

# Add multiple preferred agent records

You can add multiple preferred agents to contact records at a time using the [createRecord](/power-apps/developer/model-driven-apps/clientapi/reference/xrm-webapi/createrecord) call to update the preferred agent tables, [Preferred Agent (msdyn_preferredagent)](../../developer/reference/entities/msdyn_preferredagent.md) and [Preferred Agent Customer Identity (msdyn_preferredagentcustomeridentity)](../../developer/reference/entities/msdyn_preferredagentcustomeridentity.md).

If you want to add multiple preferred agent routing records through the script, ensure that you map only three unique agents to a contact. If you add more than three agents, though the application displays all the mapped agents, work items are routed to the top three agents only. Agents are ordered based on the preference rating. If agents have the same preference rating, the application orders the agents based on the record creation timestamp.

You can also update or delete records using the [updateRecord](/power-apps/developer/model-driven-apps/clientapi/reference/xrm-webapi/updaterecord) or [deleteRecord](/power-apps/developer/model-driven-apps/clientapi/reference/xrm-webapi/deleterecord) calls.

## Sample code syntax

A sample code syntax is as follows.

```JavaScript
{
    var contactid = "<replace_with_contactid_guid>";
    var systemuserid = [`"<agentid-guid-1>"`,`"<agentid-guid-2>"`,`"<agentid-guid-3>"`]; // A maximum of three preferred agents can be mapped to one contact.
    for (var i = 0; i < 2; i++)
    {    
        var data =
            {
                "msdyn_name": "Preferred agent mapping",        
                "msdyn_recordId_contact@odata.bind": "/contacts("+contactid+")",        
                "msdyn_systemuserid@odata.bind": "/systemusers("+systemuserid[i]+")",        
                "msdyn_preferencerating": i+1,        
                "msdyn_recordtype": 192350001
            };    // necessary fields for the entity record creation

            Xrm.WebApi.createRecord("msdyn_preferredagent", data); // create record
    }
}
```

> [!IMPORTANT]
> We recommend that you add the contact and preferred agent routing through the **Preferred agent routing** page.

## Related information

[Configure routing to preferred agents](../administer/configure-preferred-agent.md)

