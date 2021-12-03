---
title: "Configure sales accelerator settings for sellers to personalize"
description: "Use personal settings to determine how activities are scheduled based on work availability and deciding what happens when an activity is complete."
ms.date: 10/26/2021
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Configure sales accelerator settings for sellers to personalize

The personalize sales accelerator settings allows sellers determine what happens when you complete an activity. 

## License and role requirements

| &nbsp; | &nbsp; |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security Role** | System Administrator <br>  See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## Enable linking sequence steps and activities

As an administrator, you can configure the linking of sequence steps and activities. Before you start using this feature, verify that the **Steps and activities** settings is enabled.

1.	Sign in to the Dynamics 365 Sales Hub app.   
2.	Go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.    
3.	Under **Sales accelerator**, select **Sequence**, and then select **Settings**.    
    >[!div class="mx-imgBorder"]
    >![Select personal settings to enable linking steps and activities](media/sa-personal-settings-select-settings.png "Select personal settings to enable linking steps and activities")     
4.	On the **Sequence settings** page, in the **Linked activities** section, turn on **Pre-create linked activities (recommended)**.    

    >[!NOTE]
    > Select the **Exclude phone call activities** check box to avoid creating a duplicate phone call activity when you're using Dynamics 365 Channel Integration Framework as your phone system. If you don't select this option, a duplicate phone call activity will be created on the timeline and a duplicate activity will be created when the step is waiting to be completed on the record.    

    >[!div class="mx-imgBorder"]
    >![Enable pre-create linked activities](media/sa-personal-settings-enable-precreate-linked-activities.png "Enable pre-create linked activities")     
 
5.	Save and close the settings page.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also

[Personalize sales accelerator](personalize-sales-accelerator.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]

