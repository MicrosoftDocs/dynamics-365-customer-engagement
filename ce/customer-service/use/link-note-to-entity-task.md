---
title:  Learn about linking timeline notes with table records
description: Learn how-to link timeline notes to other table records.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to
ms.collection: 
ms.date: 05/28/2026
ms.custom: bap-template 
---

# Learn about linking timeline notes with table records

You can use notes on the timeline to record case summary, investigations, or add images and files for reference. You can use **Relate note to a table record** on the timeline to perform the following actions on case, account, and contact tables without leaving the page that you're on:

- Move a note on the timeline of an existing table record to another table record. For example, you can move a note on the timeline of a contact to an existing case. After you move the note, it appears only on the timeline to which you moved and not on both. 
- Create a new table record from the note. For example, you can create a case from an existing note on a contact's timeline.

## Understand linking timeline notes

The following sections contain scenarios to describe how linking timeline notes to tables works. 

## Move note from one table record to another table record

Consider the following scenario: You created a note on the timeline of the account Contoso Coffee during an interaction with the customer about an issue with the CX300 coffee machine. After the interaction, you want to link the note to an existing case or create one. 

To link the note on the Contoso Coffee account to the Issue with coffee machine case:
1.	On the Contoso Coffee account timeline, select the note to link.
2.	Select **Link to record** button. 
3.	On the window that appears, search for the case to move the note to. The case is "Issue with coffee machine".
4.	The application displays a message to confirm if the note must be unlinked from the account table. Select **OK**. The note now appears only on the timeline of the "Issue with coffee machine" case.

## Create a table record from a note

Consider a scenario where in a voice conversation, the customer record **Contoso Coffee** appears in the **Customer Details** section of the **Active Conversation** form. The timeline reflects either the account or contact record, depending on the selected record. Learn more in [Take notes specific to conversation](oc-take-notes.md).

To add a note, select **Notes** in the communication panel. After you save the note, it displays on the timeline.  

To create a case from the note, perform the following steps:

1.	On the timeline, select the note you created for the Contoso Coffee account. 
1.	Select **Link to record**. 
1.	On the window that appears, select **Add a new record**. Available options such as **Case**, **Account**, or **Contact** depend on the administrator configuration.
1. Select **Case**. The case form opens, with fields prepopulated from the note based on the administrator configuration. For example, if your administrator configured the notes title to be copied as the case title and the notes description to be copied to the case description, **Case Title** and **Description** are automatically populated from the note. 
1. Add the information on the quick create case form and save the details.
1. When prompted to unlink the note from the original record, select **OK**. The note appears on the timeline of the new case.

    :::image type="content" source="../media/link-note-conversation-mini.png" alt-text="runtime experience for the relate conversation timeline note to case " lightbox="../media/link-note-conversation.png":::

### Related information

[Enable linking of timeline notes with other tables](../administer/link-note-to-entity.md)  
