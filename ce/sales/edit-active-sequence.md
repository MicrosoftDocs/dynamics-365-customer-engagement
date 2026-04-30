---
title: Edit an active sequence and view version history 
description: Edit an active sequence by creating new versions of the sequence without deactivating it in sales accelerator.
ms.date: 04/30/2026
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.reviewer: udag
---

# Edit an active sequence and view version history 

When you've changed the process of an active sequence, you can create a new version of the sequence without deactivating it. You can update a sequence multiple times, and when you connect a record to the sequence, the record will be connected to the latest version.

>[!IMPORTANT]
>The records that were connected to a previous version of the sequence remain connected to that previous version.

## Edit an active sequence

1.	Sign in to your Dynamics 365 Sales Hub app.   
1.	Go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.   
1.	Under **Sales accelerator**, select **Sequences**.   
1.	On the **Sequences** page, open the sequence that is in active state.    
1.	On the sequence view page, select **Edit sequence**.

    :::image type="content" source="media/sequence-edit-active-select-edit-sequence.png" alt-text="Screenshot of the Edit sequence option on a sequence view page.":::    
 
1. On the confirmation message, select **OK**.  

    A version is created for the sequence.
 
1.	Edit the sequence as required, and then select **Activate**.
 
    :::image type="content" source="media/sequence-edit-active-sequence-activate.png" alt-text="Screenshot of activating the edited sequence.":::    

1.	On the confirmation message, provide a description of the change, and then select **Save**.    
 
A new version of the existing sequence is created and saved.

## View version history and associated records

Viewing the version history helps you to understand the number of versions that have been created for a sequence, and view the records that are connected to each version.    

1.	Open the sequence.

1.	To view the version history, select **Show full version history** from the dropdown list beside the sequence name.

    :::image type="content" source="media/sequence-version-select-version-history.png" alt-text="Screenshot of selecting the Show full version history option.":::

    A list of versions that exist for the sequence is displayed on the right pane.

    The current selected version is highlight with a blue line corresponding to the version name.  

    > [!NOTE]
    > If there are no leads connected to the sequence, and you created a new version, only the latest version is displayed in the list.

1.	To view the version of the sequence to which a record is connected, go to the **Connected *records*** tab. In this example, we selected the **Connected leads** tab.    

    A list of leads that are connected to the sequence is displayed, along with the version to which they're connected.   

    :::image type="content" source="media/sequence-version-view-leads-list.png" alt-text="Screenshot of the list of leads with associated sequence versions.":::     
 

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

## Related information

[Edit a sequence](edit-a-sequence.md)    
[Create and activate a sequence](create-and-activate-a-sequence.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
