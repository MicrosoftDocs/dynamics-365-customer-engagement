---
title: "Personalize sales accelerator settings"
description: "Use personal settings to determine how activities are scheduled based on work availability and deciding what happens when an activity is complete."
ms.date: 10/26/2021
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---
# Personalize sales accelerator 

Use personal settings to determine how activities are scheduled based on work availability and deciding what happens when an activity is complete.

## License and role requirements
|  | |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security Role** | Salesperson and above <br>  See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## What can you personalize

As a seller, you can personalize sales accelerator by determining how activities are scheduled based on your work availability and deciding what happens when you complete an activity. The following personal settings are available for you to configure:

-	[Configure your work availability](#configure-your-work-availability)
-	[Configure the auto advance steps](#configure-the-auto-advance-steps)
-	[Configure steps and activities](#configure-steps-and-activities)

## Configure your work availability

Configure your working days, hours, and days off to adjust scheduled tasks and lead assignment according to your availability. For example, you're taking a day off on April 1, 2021, and you have a few activities to complete that day. When you configure the calendar with your day off, any activities that were scheduled for that day will be moved to your next available date or time.

Depending on the license you have in the organization, you use one of the following ways to configure your work availability:
- Sales Premium: [Through work list settings](#through-work-list-settings)
- Sales Enterprise: [Through personal settings](#through-personal-settings)

>[!NOTE]
>- Ensure that you've read and write privileges to **Calendar** entity. More information: [Security roles and privileges](/power-platform/admin/security-roles-privileges).
>- Verify that the administrator as enabled the option to configure your availability. 
>    - Through sequence settings, see [Enable the availability option in sequence settings](customize-sales-accelerator-sellers.md#enable-the-availability-option-in-sequence-settings).
>    - Through sales accelerator configuration, see step 4 in [Configure sales accelerator for assignment rules](sales-accelerator-assignment-rules.md). 

### Through work list settings (Sales Premium)<a name="through-work-list-settings"></a>

1.	Sign in to the Dynamics 365 Sales Hub app, and go to **My work** > **Sales accelerator**. 
    
2.	In the work list section, select More options > settings.   
    >[!div class="mx-imgBorder"]
    >![Select settings in the work list to configure your availability](media/sa-personal-settings-select-settings-icon-worklist.png "Select settings in the work list to configure your availability")     
3.	On the **Personal settings** page, select **Availability**.
    >[!div class="mx-imgBorder"]
    >![Select Availability under Personal settings](media/sa-personal-settings-select-availability-settings.png "Select Availability under Personal settings")      

    >[!NOTE]
    >If your administrator chosen the **Outlook** option, a message is displayed to configure your work availability through your Outlook calendar.     
    >![Configure your work availability through outlook message.](media/sa-personal-settings-select-availability-settings-outlook.png "Configure your work availability through outlook message.")    
    >Go to Outlook calendar, set your work hours and vacation, and then save the calender events.    
    >Your availability is automatically updated in the Dynamics 365 application calendar.      

4.	Select **+ New**, and choose an option to configure your calendar according to your requirements.    
    -	**Working hours**: Configure your regular working hours between dates you define. This helps sales accelerator to consider the assignment of activities to your work list.    
        >[!div class="mx-imgBorder"]
        >![Working hours settings](media/sa-personal-settings-work-hours-settings.png "Working hours settings")    
        
        Configure the following options:     
        1.	Select a date for which you want to configure your working hours.     
        2.	Select the working hours in your day. By default, nine working hours are configured from 8:00 AM to 5:00 PM, without any breaks. To add a general break or lunch hours between working hours, select **Add** (**+**). In the following example, you can see that a break of 30 minutes has been added to the working hours. You can continue adding breaks as needed.     
            >[!div class="mx-imgBorder"]
            >![Working hours set from 8:00 AM to 12:30 PM, followed by a break from 12:30 PM to 1:00 PM, followed by working hours from 1:00 PM to 5:00 PM](media/sa-personal-settings-work-hours-choose-date-time.png "Working hours set from 8:00 AM to 12:30 PM, followed by a break from 12:30 PM to 1:00 PM, followed by working hours from 1:00 PM to 5:00 PM")    
        3.	Choose whether you want to repeat this working hour configuration each day or only on this day of the week:    
            -	If you select **Every day**, the configured working hours are applied to each day of the week, including Saturday and Sunday. You can select any days for which you don't want to apply these working hours. In the following example, Saturday and Sunday have been removed from this working hour configuration. 
            Also, you can **choose an end date** on which you want to end this working hour configuration.      
                >[!div class="mx-imgBorder"]
                >![Working hours set to repeat Monday through Friday, but not Saturday or Sunday](media/sa-personal-settings-work-hours-select-every-day.png "Working hours set to repeat Monday through Friday, but not Saturday or Sunday")    
            -	If you select **Every week**, the configured working hours are applied to the same day every week. In the following example, the configuration is applied on Wednesday, and all subsequent Wednesdays will have the same working hour configuration. 
            Also, you can **choose an end date** on which you want to end this working hour configuration.        
                >[!div class="mx-imgBorder"]
                >![Working hours set to repeat every Wednesday](media/sa-personal-settings-work-hours-select-a-week-day.png "Working hours set to repeat every Wednesday")    

        4.	Select your time zone. The time zone allows to match the time properly when your team is spread across countries or regions. By default, Coordinated Universal Time (Greenwich Mean Time) is selected.    
        5.	Save the configurations.      
     -	**Non-working hours**: Configure a break or time you're taking off from work on a particular day. Choose the period of time you want to take off, and then select **Save**.     
        In the following example, you have an appointment with a doctor for a checkup between 1:00 and 4:00 PM on March 2, 2021. When you use the **Non-working hours** option to update your calendar, sales accelerator will consider the break and adjust your activity timeline to match your working hours.    
        >[!div class="mx-imgBorder"]
        >![Non-working hours set for an appointment](media/sa-personal-settings-non-work-hours-settings.png "Non-working hours set for an appointment")    
    -	**Time off**: Configure vacations or personal days off from work. This option blocks a full day or multiple days. When you're applying for multiple days, select the **All-day** option, and then choose start and end dates.     
        Provide a description so other sellers can know your status and your reason for being away. Select your time zone, and then save the configurations.    
        In the following example, you plan to go on vacation with family from March 9 to March 12, and you use the **Time off** option to update your calendar. Sales accelerator will consider the vacation and adjust the activity timeline to match your vacation.   
        >[!div class="mx-imgBorder"]
        >![Time off set for a family vacation](media/sa-personal-settings-time-off-settings.png "Time off set for a family vacation")    

### Through personal settings (Sales Enterprise)<a name="through-personal-settings"></a>

1.	Sign in to your sales app, and in the lower-left corner of the page, go to **Change area** > **Personal settings**. 

2.	Select **Calendar**.

    The calendar opens for the current month with your work availability. Also, at the bottom of the calendar, you can see the default local time of your organization.

    > [!div class="mx-imgBorder"]
    > ![Work availability calendar page.](media/sales-accelerator-work-availability-calendar.png "Work availability calendar page")

    >[!NOTE]
    >If your administrator chosen the **Outlook** option, a message is displayed to configure your work availability through your Outlook calendar.     
    >![Configure your work availability through outlook message.](media/sa-personal-settings-select-availability-settings-outlook.png "Configure your work availability through outlook message.")    
    >Go to Outlook calendar, set your work hours and vacation, and then save the calender events.    
    >Your availability is automatically updated in the Dynamics 365 application calendar.      

3.	Configure your calendar according to your requirements as described in step 4 from the [Through work list settings](#through-work-list-settings) section.     

## Configure the auto advance steps

The **Auto advance** settings specify the next course of action to take when you complete or skip a step.

1.	Sign in to the Dynamics 365 Sales Hub app, and go to **My work** > **Sales accelerator**.
2.	In the work list, select the settings icon.   
    >[!div class="mx-imgBorder"]
    >![Select settings in the work list to configure auto advance steps](media/sa-personal-settings-select-settings-icon-worklist.png "Select settings in the work list to configure auto advance steps")      
3.	On the **Personal settings** page, select **Auto advance**.      
    >[!div class="mx-imgBorder"]   
    >![Select auto advance settings](media/sa-personal-settings-auto-advance-settings.png "Select auto advance settings")      

    The following settings are available for completing or skipping an activity:       
    -	**Ask before moving to the next work item**: When an activity is completed or skipped, a message is displayed before you move to the next record in the work list. On the message, you'll select an appropriate option to proceed. The following image shows the message that's displayed when you skip an activity.    
        >[!div class="mx-imgBorder"]
        >![For skipping an activity: "Do you want to go to the next item in your work list or stay here and continue working?" Options are "Go to next" or "Stay here"](media/sa-personal-settings-auto-advance-skip-activity-message.png "For skipping an activity: \"Do you want to go to the next item in your work list or stay here and continue working?\" Options are \"Go to next\" or \"Stay here\"")       
    -	**Automatically go to the next work item**: When an activity is completed or skipped, the next record in the work list queue is automatically displayed.   
    -	**Stay on the same record**: When an activity is completed or skipped, the same record still is displayed, and the **Up next** widget displays the next activity that has been defined in the sequence.    
4.	Save and close the settings page.

## Configure steps and activities

When a step is displayed in the **Up next** widget, a corresponding activity is automatically created on the timeline and linked to the step. When you complete the action, such as sending an email or making a call through the timeline, the step is updated. By configuring the activities and steps, you can choose how the actions you perform on steps will affect the linked activities and sequence steps.     

>[!NOTE]
>Verify that the administrator as enabled the option to configure steps and activities. More information, see [Enable the availability option in sequence settings](customize-sales-accelerator-sellers.md#enable-linking-sequence-steps-and-activities).

1.	Sign in to the Dynamics 365 Sales Hub app, and go to **My work** > **Sales accelerator**.
2.	In the work list, select the settings icon.   
    >[!div class="mx-imgBorder"]
    >![Select settings in the work list to configure steps and activities](media/sa-personal-settings-select-settings-icon-worklist.png "Select settings in the work list to configure steps and activities")     
3.	On the **Personal settings** page, select **Steps and activities**.       
4.	On the **Steps and activities** page, configure the following options as required:     
    -	**When I send an email**: When you select this check box and send an email through the timeline, the sequence step that's related to this activity is automatically marked as complete.     
    -	**When I mark a phone call activity record as complete**: When you select this check box and make a phone call through the timeline, the sequence step that's related to this activity is automatically marked as complete.      
    -	**When I mark a phone call sequence step as complete**: When you complete a phone call activity in the sequence step, you can choose to enter the status of the activity or enter a default value that has been defined for your organization.    
    -	**Link between skip and cancel**: When you turn on this toggle, you mark a sequence step as canceled when you skip the step.     

    >[!div class="mx-imgBorder"]
    >![Configure Steps and activities](media/sa-personal-settings-configure-steps-activities.png "Configure steps and activities")     
 
5.	Save and close the settings page.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also

[Configure sales accelerator settings for sellers to personalize](customize-sales-accelerator-sellers.md)

[Prioritize sales pipeline through work list](prioritize-sales-pipeline-through-work-list.md)   
   

[!INCLUDE[footer-include](../includes/footer-banner.md)]
