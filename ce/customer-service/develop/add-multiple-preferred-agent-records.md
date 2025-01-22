---
title: Add multiple preferred agent records 
description: .
author: snehasishlaik 
ms.author: nenellim  
ms.reviewer: nenellim
ms.topic: how-to 
ms.collection: 
ms.date: 01/22/2025
ms.custom: bap-template 
---


# Add multiple preferred agent records

You can add multiple preferred agents to contact records at a time using the [createRecord](/power-apps/developer/model-driven-apps/clientapi/reference/xrm-webapi/createrecord) call to update the preferred agent entities, [msdyn_preferredagent](./develop/reference/entities/msdyn_preferredagent.md) and [msdyn_preferredagentcustomeridentity](./develop/reference/entities/msdyn_preferredagentcustomeridentity.md).

If you want to add multiple preferred agent routing records through the script, ensure that you map only three unique agents to a contact. If you add more than three agents, though the application displays all the mapped agents, work items are routed to the top three agents only. Agents are ordered based on the preference rating. If agents have the same preference rating, the application orders the agents based on the record creation timestamp.

You can also update or delete records using the [updateRecord](/power-apps/developer/model-driven-apps/clientapi/reference/xrm-webapi/updaterecord) or [deleteRecord](/power-apps/developer/model-driven-apps/clientapi/reference/xrm-webapi/deleterecord) calls.

A sample code syntax is as follows.

var contactid = "<replace_with_contactid_guid>";
var systemuserid = ["<agentid-guid-1>","<agentid-guid-2>","<agentid-guid-3>"]; // upto 3 preferred agents can be mapped to 1 contact
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

## Prerequisites
<!--Prerequisites. Optional. If you need prerequisites, make them your first H2 in a how-to guide. Use clear language and use a list format.-->

<!--Add your content here-->

## Section heading
<!--H2s. Required. A how-to article explains how to do a task. The bulk of each H2 should be a procedure.-->

<!--Intro paragraph-->
<!--Step 1-->
<!--Step 2-->
<!--Step n-->

## Next steps
<!--Optional. Provide no more than five next steps. Include some context so the customer can determine why they would click the link. Learn more in [Link to more resources](../topics/link-to-more-resources.md#next-steps-and-see-also-links).-->

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
