---
title: Customize Customer Service workspace to view the IVR transcripts 
description: Learn how to Customize Customer Service workspace to view the IVR transcripts
author: gandhamm
ms.author: mgandham
ms.reviewer: neeranelli
ms.topic: how-to .
ms.collection: get-started 
ms.date: 07/29/2023
ms.custom: bap-template 
---

# Customize Customer Service workspace to view the IVR transcripts

You'll need to customize the Conversation form for Customer Service workspace for agents to view the transcripts from Nuance IVR on the Active Conversation form. Perform the following steps to add **CC_Transcript_Control** to the form:

1.	In [Power Apps](https://make.preview.powerapps.com/), select the environment that contains your solution.
2.	Select **Tables**, select the **Conversation** table, and then select the **Forms** area.
3.	Select the required form. 
4.	On the left navigation pane, select **Components**.
5.	Select **CC_Transcript_Control** in the list of available components. This component is available out-of-the-box.
6.	Specify the required **TableName** and **TableColumn** in **CC_IsExternalContext**.
7.	 Save and publish the form.  The form on the application UI displays the transcript from the IVR.

When there’s no transcript available, you can choose to disable the transcript using a web resource.More information: [Create a JavaScript web resource](/power-apps/maker/model-driven-apps/configure-event-handlers-legacy#create-a-javascript-web-resource).

Here’s the sample code to disable the transcript coming from the Mix IVR bot:

```
export class FormWebResource {
    public static async onFormLoad(context: XrmClientApi.EventContext): Promise<void> {
        var formContext = context.getFormContext();
        formContext.tabs.get("<Your form tab name>").sections.get("<Your section name>").setVisible(false);
    }
}
```

## Define field requirements for Call Intent

Nuance Professional Services can extend the **msdyn_ocexternalcontext** to include additional customer metadata that is added to the context of the Nuance IVR application. They must modify the payload file to include the newly added fields. For more information on the msdyn_ocexternalcontext entity, see: msdyn_ocexternalcontext
Perform the steps in [Create and edit columns in Dataverse](/power-apps/maker/data-platform/create-edit-field-portal) to extend the table.



## Prerequisites

<!--add your content here-->

<!--H2s. Required. A how-to article explains how to do a task. The bulk of each H2 should be a procedure.-->
## Section heading

<!--Intro paragraph-->
<!--Step 1-->
<!--Step 2-->
<!--Step n-->

<!--Next steps. Optional. Provide no more than three next steps. Include some context so the customer can determine why they would click the link.-->
## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
