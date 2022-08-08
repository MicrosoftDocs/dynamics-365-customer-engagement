---
title: "Manager your sequences in sales accelerator"
description: "Manage your sequences by viewing, cloning, editing, and deleting in sales accelerator."
ms.date: 08/15/2022
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Manage sequences 

Manage your sequences in sales accelerator by viewing details, cloning, editing, and deleting.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise, Dynamics 365 Sales Premium, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Salesperson <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## View details of sequence and connected records

1. Sign in to your sales app and in the lower-left corner of the page, go to **Change area** > **Personal settings**.   
2. Under **Sales accelerator**, select **Sequences**.   
3. On the **Sequences** page, select and open the sequence for which you want to view the details such as activities and assigned records.    
    
    >[!TIP]
    >Alternatively, hover over a sequence, and then select **More options** > **View sequence**.    

    The sequence opens and on the **Designer** tab, you can view the activities that are defined for the sequence.     

    :::image type="content" source="media/sequence-designer-sequence-tab.png" alt-text="Designer tab of a sequence.":::
   
4. To view the list of connected records, select the **Connected *record*** tab. In this example, we're selecting a sequence with record type lead. You can also remove and connect records with the sequence through this view. More information: [Connect a sequence to records](connect-a-sequence-to-records.md#ContactThroughASequence)   
    - The **Connected segments** section lists the segments that are associated with the sequence.   
    - The **Connected *records*** section displays the list of records that are connected to the sequence with the following information in columns:   
        - **Progress**: Shows the number of steps that are completed in the record.  
        - **Current step**: Shows the step that is to be completed.    
        - **Days elapsed**: Shows the number of days since the record moved into the current step. 

    :::image type="content" source="media/sequence-connected-records-tab.png" alt-text="Connected records tab of a sequence.":::

5. To view the properties of the sequence such as, name, description, record type, and owner, select **Properties**. If the sequence is in active state, you can only view the information. Deactivate the sequence to update the Name and description. Record type and Owner information can't be edited at any state.

    :::image type="content" source="media/sequence-view-properties.png" alt-text="View properties of a sequence.":::

    The **Properties** pane opens.

    :::image type="content" source="media/sequence-properties-pane.png" alt-text="Properties pane of a sequence.":::

More information: [View details of a sequence and its connected records](view-sequence-details-connected-records.md)

## Clone and edit a sequence

Cloning a sequence makes it easier to edit, and save the changes to create new sequence. Also, cloning pulls down a full copy of the sequence data that you're cloning at that point in time, including all steps and configurations. After you edit, you can save and activate the cloned sequence and apply it to records.

1. Sign in to your sales app and in the lower-left corner of the page, go to **Change area** > **Personal settings**.   
1. Under **Sales accelerator**, select **Sequences**.   
1. Open the sequence that you want to clone and select **Create a copy**.

    >[!TIP]
    >Alternatively, hover over a sequence, and then select **More options** > **Create a copy**.    
    
    > [!div class="mx-imgBorder"]
    > ![Select create a copy](media/sequence-clone-copy-sequence.png "Select create a copy")  

1. On the **Create a copy** dialog, enter the name of the sequence and description.    

    > [!div class="mx-imgBorder"]
    > ![Enter the name of the sequence and description](media/sequence-clone-name-description-dialog.png "Enter the name of the sequence and description")   

1. Select one of the buttons:   
    - **Save and edit**: Select this button to open the sequence editor and add steps as necessary. To edit a sequence, see [Edit a sequence](#edit-a-sequence-seller).
    - **Save and close**: Select this button to save and create the sequence. 

**To edit the sequence**<a name='edit-a-sequence-seller'></a>  

1. Open the sequence that you want to edit.    

    >[!NOTE]      
    >If the sequence is **Active** state, you can one of the following actions to edit.  
    >- Deactivate or [create a copy](#clone-a-sequence)
    >- Select **Edit sequence**. More information: [Edit an active sequence and view version history](edit-active-sequence.md)  

1. Do one of the following activities:   
    - To add an activity, perform **step 4** from [Create and connect sequence for yourself](create-sequence-seller.md ).       
    - To edit an activity, select the activity and the details open in the right pane.   
        Make the edits you want, and then select **Save**.      
1. (Optional) If you want the sequence to be available to connect with records, select **Activate**.    
1. Save and exit the sequence designer.

More information: [Clone and edit a sequence](edit-a-sequence.md).

## Delete a sequence

1. Sign in to your sales app and in the lower-left corner of the page, go to **Change area** > **Personal settings**.   
1. Under **Sales accelerator**, select **Sequences**.   
1. On the **Sequences** page, hover over the sequence you want to delete, and then select **More options** > **Delete**.  
1. In the confirmation message that appears, select **Delete permanently**.      
    
    >[!NOTE]
    >If you are deleting a sequence that is the active state, a confirmation message is displayed that the sequence will be deactivated and deleted. Select **Deactivate and delete**.
    
    > [!div class="mx-imgBorder"]
    > ![Confirmation message for deleting a sequence](media/sequence-delete-confirmation-message.png "Confirmation message for deleting a sequence")

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]


### See also

[What is sales accelerator](sales-accelerator-intro.md)

[Create and connect sequence for yourself](create-sequence-seller.md)

[Apply and remove tags from your sequences](apply-remove-tags-seller.md)

