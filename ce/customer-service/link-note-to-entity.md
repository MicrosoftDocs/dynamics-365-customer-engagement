---
title: Enable linking of timeline notes to other table records
description: Learn how to associate notes with a table.
author: gandhamm
ms.author: mgandham 
ms.reviewer: neeranelli
ms.topic: how-to 
ms.collection: 
ms.date: 08/01/2023
ms.custom: bap-template 
---

# Enable linking of timeline notes with other table records

You can use the **Relate note to a table record** feature to perform the following actions on case, account, and contact tables, without having to leave the current page:
- Move a note on the timeline of an existing table record to another table record. For example, you can transfer a note on the timeline of a contact to an existing case. 
 > [!NOTE]
 > When the note is linked to another table record, it no longer appears on the current table's timeline, as the note gets moved from the current record to the new table record. 
- Create a new table record from the note. For example, you can create a case from an existing note on a contact's timeline.

You can choose to enable this feature on any table that allows you to add a timeline component. However, the tables that a note can be linked to are only account, contact, and case.

## Configure linking of timeline notes

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
1. Select **Tables**, and then select the table for which agents can link notes taken on the timeline.
1. Select **Form**.
1. Create a new form or use an existing form. More information: [Create, edit, or configure forms using the model-driven form designer](/power-apps/maker/model-driven-apps/create-and-edit-forms).
1. Select the timeline component on the form.
1. In the **Properties** > **Notes** section, perform the following steps:
    - Select **Link to Table**.
    - Select the table you want to link the note to. You can select Account, Case, and Contact. The required table's pane appears.
    - Select **Enable** on the table’s pane. If you've selected **Case**, you must specify the following:
      - **Create Case using**: the form type that opens when the agent creates a new case from the note.
      - **Configure form**: the form that is displayed when the agent creates a new case from the note.
      - **Map notes title to**: the field to which the notes title should get copied. For example, if you select **Case Title**, when you create a new case, the Case title is auto- populated with the value of the notes title.
      - **Map notes description to**: The field to which the notes description should get copied to. For example, if you select **Description**, when you create a new case, the case description is auto populated with the value of the notes description. 
1. Save and publish the customizations.
