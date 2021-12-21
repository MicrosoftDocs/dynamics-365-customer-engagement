---
title: "Enable and configure sales accelerator"
description: "Enable and configure the sales accelerator to create sequences and connect records, and view daily work list items."
ms.date: 01/07/2021
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---
# Configure the sales accelerator

Enable and configure the sales accelerator to create sequences and connect records, and view daily work list items.

## License and role requirements

| &nbsp; | &nbsp; |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security Role** | System Administrator <br>  See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## Configuration steps

The sales accelerator feature helps sellers in your organization increase their sales productivity and prioritize activities for the day through the work list available in your sales app. An administrator or a sales manager uses the sequence designer to create a sequence of activities&mdash;separated by time intervals&mdash;including emails, phone calls, and tasks. Sequences are connected to relevant records, so sellers can follow the best practices that have been defined in the sequence for the record types that are assigned to them. The sequence is then applied to record types and assigned to a seller automatically, according to your organization's sales strategies.  

> [!NOTE]
> - To configure sales accelerator for assignment rule with your enterprise license, see [Configure sales accelerator for assignment rules](sales-accelerator-assignment-rules.md).
> - You can also enable sales accelerator through quick setup (with the Dynamics 365 Sales Enterprise license). In this case, you'll get only 1500 sequence-connected records per month. More information: [Lead and opportunity scoring](digital-selling.md#sales-accelerator)

As an administrator, you must enable and configure the sales accelerator in your organization to make it available for sales managers and sellers to use. Follow these steps:

1. [Review the prerequisites and recommendations](#review-the-prerequisites-and-recommendations).
2. [Set up the sales accelerator](#set-up-the-sales-accelerator).

## Review the prerequisites and recommendations

### Prerequisites

Ensure that you meet the following requirement:

- Enable advanced Sales Insights features. More information: [Install and configure premium Sales Insights features](intro-admin-guide-sales-insights.md#install-and-configure-premium-sales-insights-features)

### Recommendations

For the best experience of the sales accelerator, enable and configure [predictive lead scoring](configure-predictive-lead-scoring.md) and [predictive opportunity scoring](configure-predictive-opportunity-scoring.md) to display predictive scores for each record in the work list. Displaying the score helps your sellers to prioritize leads and opportunities based on their predicted likelihood to convert.

## Set up the sales accelerator

1. Sign in to your sales app, and in the lower-left corner of the page, go to **Change area** > **Sales Insights settings**.
2. On the site map, under **Sales accelerator**, select **Setup**.    
    The sales accelerator configuration page opens.      
    For the first-run experience, go to step 3. If the feature has already been configured and you want to update the configuration, go to step 4.    
3. If you're configuring the feature for the first time in your organization, select **Get started**.     
    >[!div class="mx-imgBorder"]
    >![Sales accelerator first-run setup](media/sa-fre-setup.png "Sales accelerator first-run setup")    

    A dialog box appears with the option to install sample data to explore the feature. Installing the sample data is relevant only for your sandbox or trial environments. Adding the sample data might take a few minutes. However, you can choose to ignore the sample data installation and add it later when required. More information: [Manage sample data](manage-sample-data.md)    
    
    >[!IMPORTANT]
    >To prevent unwanted results, sample data is available only for non-production environments.
    
    >[!div class="mx-imgBorder"]
    >![Sample data installation](media/sa-sample-data-popup-message.png "Sample data installation")        

    The configuration page opens.        
 
4. <a name="define-team-access"></a>In the **Define team access** section, select roles to grant permissions to use assignment rules and sales accelerator features.     
    For each section, choose one of the following options to grant permissions:     
       
    | Security roles | Description |
    |----------------|-------------|
    | All security roles | Select this option to give access to view the Sales Hub app to all the security roles in your organization. |
    | Specific security roles | Select this option to specify security roles to give access to view the Sales Hub app to just a few users. Use the lookup box to add the security roles. |    

    >[!div class="mx-imgBorder"]
    >![Select security roles to access the sales accelerator and assignment rules features](media/sa-select-security-role.png "Select security roles to access the sales accelerator and assignment rules features")   

5. In the **Seller availability** section, configure the following options: 
    - Turn on **Seller availability settings** to enable sellers to configure work hours.
    - From the Select a calendar option, choose one of the following calendar types that sellers can use to configure work hours and vacation days. Once configured, leads and opportunities are assigned based on seller availability. 
        - **CRM calendar**: : Allows sellers to configure work hours and vacation days using the Dynamics 365 calendar in personal settings. By default, this option is selected. More information [Configure your work availability](personalize-sales-accelerator.md#configure-your-work-availability). 
        - **Outlook**: Allows sellers to configure work hours and vacation days through the Outlook calendar. Sellers should have an Exchange license to use this option.

    >[!div class="mx-imgBorder"]
    >![Enable the option to allow sellers to set working hours and vacation days](media/sa-enable-seller-availability.png "Enable the option to allow sellers to set working hours and vacation days")   

6. (Optional) In the **Automate lead and opportunity assignment (preview)** section, select the toggle to enable preview for the assignment rules feature. More information: [Manage assignment rules](create-manage-assignment-rules.md).

7. <a name="choose-content-and-layout"></a>In the **Choose content and layout** section, select the record types and their corresponding related forms that are used in your organization, as required.      

   >[!div class="mx-imgBorder"]
   >![Choose content layout](media/sa-choose-content-layout.png "Choose content layout")   

    1. Select **Add record type**, and then select the dropdown list to choose the records that you want to add. The selected record type will display the **Sequence (up next)** widget. Sales managers use the record types to configure the sequence that will be assigned to records to be displayed in the app. You can select record types such as **Accounts**, **Contacts**, **Leads**, **Opportunities**, and custom.    
        >[!NOTE]
        >- To view the custom records types in the list, enable the options **Activities**, **Connections**, and **Sending email (If an email field does not exist, one will be created)** under **Communication & Collaboration** in **Settings > Customizations** > **Customize the System** > **Components** > **Entities**.
        >- To add the **Up next** widget to your custom entity form, see [Add the Up next widget to an entity form](add-upnext-widget-form.md).     
        
    2. Repeat step a to add more record types. In the example, the record types **Contacts**, **Leads**, **Accounts**, and **Orders** are added.   
        
        >[!div class="mx-imgBorder"]
        >![Selected record types](media/sa-selected-record-types.png "Selected record types")         
        
        >[!NOTE]
        >You can remove the records types that are no longer required to have automated activities associated with them. Select the **X** icon corresponding to the record type to remove it from the list. However, if the records in the deleted record type are associated with a sequence, these records will continue to be associated with the sequence.   
     
    3. Select **Next**

8. In the **Automate activity creation** section, choose an option based on your requirements:    
    - Select **Go to sequences** to create sequences and apply them to records. More information: [Create and manage sequences](create-manage-sequences.md)
    - Select **Skip this step** to come back later and create the sequences.
    >[!div class="mx-imgBorder"]
    >![Choose an option to automatically create activities](media/sa-automatic-activity-creation.png "Choose an option to automatically create activities")           
9. In the **Set up integrated calls** section, the status of the phone system that's integrated through Dynamics 365 Channel Integration Framework is displayed under **Channel Provider**. The phone system allows sellers to make calls directly through the sales accelerator feature. The priority of the phone system that's selected for the sales accelerator depends on the ranking that's defined in the Dynamics 365 Channel Integration Framework configuration. More information: [Integrate a sample softphone dialer with Dynamics 365 Sales](integrate-sample-softphone.md)     
    >[!div class="mx-imgBorder"]
    >![Status of the phone system](media/sa-channel-provider-status.png "Status of the phone system")        
    After the phone system is successfully verified, configure the following advanced call settings:    
    - Under **Phone number priority**, select the phone numbers for **Default**, **Fallback1**, and **Fallback2**. When sellers initiate calls through a sequence step or the work list, the softphone chooses the phone numbers in the order they're listed.     
        For example, you can select **Business Phone** in **Default**, **Mobile Phone** in **Fallback1**, and **Home Phone** in **Fallback2**. When sellers initiate a call, the number in the **Default** option is dialed, if it's available. If it isn't available, the call goes to the next option.            
        >[!NOTE]
        >For opportunities, the phone number priority will be applied to the primary contacts.  

    - Under **Call settings**, select the **Create records automatically on click** option to automatically create a phone call activity when sellers initiate a call from a sequence step or from the work list.   
        >[!div class="mx-imgBorder"]
        >![Advanced call settings](media/sa-advance-call-settings.png "Advanced call settings")       
10. <a name="enable-sales-accelerator-reports"></a>Enable the **Sales accelerator reports** option to help your sales manager view and understand their team's historical operational metrics and key performance indicators (KPIs), and sequence stats page.   
    [!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]
    
    >[!div class="mx-imgBorder"]
    >![Enable Sales acceleration reporting preview](media/sa-enable-sales-acceleration-reporting.png "Enable Sales acceleration reporting preview")        

    By default, the users with sales manager and sequence manager roles can view the reports. To grant view access to other roles, provide read access at organizational level for the Sales acceleration reports table. More information: [Security roles and privileges](/power-platform/admin/security-roles-privileges).   

    >[!NOTE]
    >After you enable the option, the application may take up to 24 hours to display the data in the reports. Subsequently, the reports refresh every 24 hours. You can view the last updated date on the top-right corner of the sales acceleration reporting page.

    To know how sales managers use,   
       -	Metrics and KPIs, see [Understand sales acceleration reporting](understand-sales-acceleration-reporting.md).
       -	Sequence stats, see [Understand sequence stats](understand-sequence-stats.md).
    
11. Save and publish the configuration.
    A status message is displayed at the top of the page with details including the time and user who published the configurations.
    >[!div class="mx-imgBorder"]
    >![Sales accelerator setup status message](media/sa-setup-status-message.png "Sales accelerator setup status message")

The sales accelerator is ready to use in your organization for the selected security roles.

## Customizations

By default, the **Up next** widget is displayed on the **Default Main** and **Sales Insight** forms. To add the **Up next** widget to other forms, follow the process specified in [How do I add the Up next widget to an entity form?](faqs-sales-insights.md#sales-accelerator)

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

>[!NOTE]
>To know how to add work list site map to your custom app, see [How to add work list site map to your custom app](faqs-sales-insights.md#how-to-add-work-list-site-map-to-your-custom-app).

### See also

[Create and manage sequences](create-manage-sequences.md)     
[What is the sales accelerator?](sales-accelerator-intro.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
