---
title: "Sequence creation and activation in the sales accelerator  | MicrosoftDocs"
description: "Learn how to create and activate sequences in the sales accelerator."
ms.date: 01/11/2021
ms.service: crm-online
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Create and activate a sequence

Every organization has its own selling processes for sellers to follow. A sequence helps sellers overcome any inconsistencies in training or lack of documentation as they progress through the sales journey. When you create a sequence, you define the activities you want your sellers to perform&mdash;and the order to perform them in&mdash;as they handle leads and opportunities. This lets sellers concentrate on selling and gives them a better understanding of what to do next.

**To create and activate a sequence**

1. Sign in to your sales app.   
2. Go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.   
3. Under **Sales accelerator**, select **Sequence**.  
4. On the **Sequences** page, select **+ New sequence**.   
    > [!div class="mx-imgBorder"]
    > ![Create a sequence dialog box](media/sequence-create-sequence.png "Create a sequence dialog box")   
5. In the **Create a sequence** dialog box, enter the following information:   

    | Parameter | Description |
    |-----------|-------------|
    | Sequence name | The name of the sequence. |
    | Description | A description of the sequence. (Optional) |
    | Entity | The entity type for which you want to apply this sequence. By default, the Lead entity type is selected. |   
6. Select **Next**.   
7. Choose and configure one of the following activities:   
    > [!div class="mx-imgBorder"]
    > ![Choose an activity type - email, phone call, or task](media/sequence-choose-activity.png "Choose an activity type - email, phone call, or task")       
    - **Email**: Creates an email activity for sellers to communicate with customers. When this activity is shown to the seller, an envelope icon is displayed on the record. When a seller selects the icon, an email composer opens with a template, if one was selected. If no template was selected, an empty email composer opens.  
       > [!div class="mx-imgBorder"]
       > ![Add an email activity](media/sequence-activity-add-email.png "Add an email activity")    

       Enter the following information to configure the email activity, and then select **Save**:   
       1. A name and description for the activity. The information you enter here will be displayed to sellers.   
       2. If templates are available for your organization, in the **Assign email template** box, select the template you want to assign for this step.   

          > [!div class="mx-imgBorder"]
          > ![Example email activity](media/sequence-activity-email-created.png "Example email activity")   

        You can define conditions for email activity to determine the branch that sequence moves to next step. More information: [Define conditions for email activity](adaptive-sequence.md#define-conditions-for-email-activity).      
    - **Phone call**: Creates a phone call activity for sellers to communicate with customers. When this activity is shown to the seller, a phone icon is displayed on the record. When sellers select the icon, a softphone appears on the app to dial the customer.    
        > [!div class="mx-imgBorder"]
        > ![Add a phone call activity](media/sequence-activity-add-phone-call.png "Add a phone call activity")    

        Enter a name and description for the phone call activity, and then select **Save**. The information you enter here will be displayed to sellers.   
        > [!div class="mx-imgBorder"]
        > ![Example phone call activity](media/sequence-activity-phone-call-created.png "Example phone call activity")    

        You can define conditions for phone call activity to determine the branch that sequence moves to next step. More information: [Define conditions for phone call activity](adaptive-sequence.md#define-conditions-for-phone-call-activity).      
    - **Task**: Creates a custom activity that you define&mdash;such as scheduling a meeting with the customer&mdash;that isn't specified in the activity selector.   
        > [!div class="mx-imgBorder"]
        > ![Add a custom task activity](media/sequence-activity-add-task.png "Add a custom task activity")    

        Enter the name and description of the custom activity, and then select **Save**. The information you enter here will be displayed to sellers.   
        > [!div class="mx-imgBorder"]
        > ![Example task activity](media/sequence-activity-task-created.png "Example task activity")   
    - **Set wait time**: Specifies the interval between activities&mdash;that is, after an activity is completed and before the next activity occurs&mdash;during which sellers need to wait. A sequence can't end with this activity.    
        When this activity is shown to sellers on a record, they don't need to perform any action; they simply need to wait until the wait time expires before they perform the next activity.   
        > [!div class="mx-imgBorder"]
        > ![Set wait time](media/sequence-activity-add-set-wait-time.png "Set wait time")   

        Choose the duration in days and hours that you want sellers to wait before they perform the next activity, and then select **Save**. The maximum wait time is 30 days.   
        > [!div class="mx-imgBorder"]
        > ![Example wait time](media/sequence-activity-set-wait-time-created.png "Example wait time")   
8. Select the **Add** icon, and then repeat step 7 for all the activities that you want to add to the sequence.    
9. Select **More options** in the upper-right corner of the page, and then select **Save**.    
10. Select **More options** again, and then select **Activate** to activate the sequence.   
    >[!NOTE]
    >You can have up to 250 active sequences at a time in your organization.        
11. Select **Yes** in the confirmation message that appears.   
    > [!NOTE]
    > An error might occur if you've added **Set wait time** as the last activity of the sequence. You must delete this last **Set wait time** activity, and then save and activate the sequence.       
    The sequence is activated and listed in the sequence designer home page.   
    > [!div class="mx-imgBorder"]
    > ![Sequence designer home page](media/sequence-home-page.png "Sequence designer home page")    
Next, you connect the active sequence to lead or opportunity records.

<table>
<tr><td>

> [!div class="nextstepaction"] 
> [Next step: Connect a sequence to records](connect-a-sequence-to-records.md)
</td></tr>
</table> 

### See also

[Create and manage sequences](create-manage-sequences.md)     
[Adaptive sequences](adaptive-sequence.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]