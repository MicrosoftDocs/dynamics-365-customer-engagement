---
title: Frequently asked questions about Sales Premium
description: Find answers to frequently asked questions about the Sales Insights add-in for Dynamics 365 Sales.
ms.date: 08/17/2023
ms.custom: bap-template
ms.topic: faq
author: udaykirang
ms.author: udag
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
---

# Frequently asked questions about Sales Premium


## Digital selling

### What's the capacity limit on using digital selling capabilities?

When you set up Sales Premium features using your Dynamics 365 Sales Enterprise license, the features are available with the following capacity limits:

- Access to the workspace and up to 1,500 records connected to any defined sequence per environment per month. Manual activities not connected to a sequence will also be displayed without a capacity limit.
- Predictive scoring for 1,500 lead or opportunity records scored per environment, per month.

### How can I get the full capacity of digital selling capabilities?

If you need more capacity, upgrade to Dynamics 365 Sales Premium. [Learn more about Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/).

## Sales accelerator

### How do I add the Up next widget to an entity form?

>[!NOTE]
>You can add the **Up next** widget only to managed entity forms.

1.	Go to **Settings** > **Solutions** and then create an empty solution. For example, **AddWidget**.  

2.	Add a **Form** to the solution.  
3.	Save the changes and publish the customizations.   
4.	Export the created **AddWidget** solution as **UnManaged**.    
5.	Delete the solution **AddWidget** from the organization.    
6.	Extract the zip file of the downloaded solution.    
7.	In the file `Solution.xml`, change the `<Managed>` value to 1 and then save.     
    `<Managed>1</Managed>`
8.	In the `customizations.xml` file, remove the parameter `<systemform unmodified="1">`.     
9.	Choose the `<column>` under the **Summary** tab, where you want to add the widget.    
10.	Add the `<section>` tag as follows:    
    ```xml
    <section name="CadenceWidget" showlabel="false" showbar="false" id="{<NEW_GUID_G1>}" IsUserDefined="0" layout="varwidth" columns="1" labelwidth="115" celllabelalignment="Left" celllabelposition="Left" labelid="{<NEW_GUID_G2> }">
      <labels>
          <label description="Cadence Widget" languagecode="1033" />
      </labels>
      <rows>
          <row>
              <cell id="{<NEW_GUID_G3>}" showlabel="false" colspan="1" rowspan="6" labelid="{<NEW_GUID_G4> }">
                  <labels>
                      <label description="Cadence widget" languagecode="1033" />
                  </labels>
                  <control id="CadenceWidgetControl" classid="{F9A8A302-114E-466A-B582-6771B2AE0D92}"  uniqueid="{<NEW_GUID_G5>}" isunbound="true">
                      <parameters />
                  </control>
              </cell>
          </row>
          <row />
          <row />
          <row />
          <row />
          <row />
      </rows>
    </section>
    ```      
11.	Replace all the `<NEW_GUID_G>` occurrences by generating a new GUID for each place.     
12.	For `<controlDescriptions>` node, add a child node as following:    
    ```xml
    <controlDescription forControl="{<GUID_G5>}">
    <customControl formFactor="2" name="MscrmControls.AcceleratedSales.CadenceWidgetControl">
        <parameters />
    </customControl>
    <customControl formFactor="0" name="MscrmControls.AcceleratedSales.CadenceWidgetControl">
        <parameters />
    </customControl>
    <customControl formFactor="1" name="MscrmControls.AcceleratedSales.CadenceWidgetControl">
        <parameters />
    </customControl>
    </controlDescription>
    ```     
13.	Replace the `<GUID_G5>` in `customizations.xml` with the **GUID_G5** generated from **step 11**.  
14.	Save the changes and zip the folder.  
15.	Open Dynamics 365 and go to **Settings** > **Solutions**.  
16.	Import the zipped solution.  
17.	Publish all customizations.  
18.	Verify that the **Up next** widget successfully shows up on the form.

### How to add sales accelerator to the site map in your custom app

Use the site map designer from the app designer to add the sales accelerator site map to your custom app. More information: [Add the sales accelerator site map entry to custom app](add-sales-accelerator-sitemap-entry-custom-app.md).

## Relationship analytics and health

### Which data is used to generate basic relationship insights?

**Basic insights:**

Uses email, phone call, and appointments sent or received in Dynamics 365.

**Enhanced insights:**

Uses email, phone call, and appointments sent or received in Dynamics 365 and Exchange (if configured).

### What is the frequency of KPI updates?

**Basic insights:** 

Updated in near real-time&mdash;as soon as a related activity is marked as completed in Dynamics 365.  

**Enhanced insights:**

Updated every 24 hours. ​  

### What are the signals in relationship health?
​
Relationship health looks at activity, recency, engagement, and sentiment of activities between sellers and customers.

### Is Office 365 consent mandatory for the relationship intelligence feature to work?
 
Office consent isn't mandatory for relationship analytics, health score, and who knows whom. You’ll get basic relationship insights based on the data in Dynamics 365. When you provide consent in Office 365 to use Exchange data, you’ll get more accurate and complete relationship information.

### What happens if I select the Exchange checkbox but the Office 365 admin hasn’t provided the consent?

The data from Exchange isn't collected until the consent is provided. Work with your Office 365 administrator to get the consent. [Learn more about providing consent for collecting Office 365 data](provide-consent-office365.md)

### I see that the Exchange checkbox is selected, though I hadn't selected it or provided the required consent for it in the past.

With the recent changes to the relationship intelligence feature, the Exchange checkbox is selected by default for all the existing customers. However, no data will be collected from Exchange until your Office 365 administrator provides consent. You can clear the checkbox if you aren’t planning to integrate with Exchange.
  
### Can I influence the relationship health score?​

An administrator can influence the relationship health score by changing the weight of activity types and the expected level of communications with customers. More information: [Configure relationship analytics and health](configure-relationship-analytics.md)

### How are similar won deals identified? <a name="similar-won-deals-fields"></a> 
 
AI models identify the factors that affect the identification of similar won deals. The factors may differ from organization to organization based on the custom and out-of-the-box fields. To view the fields that determined the similar won deals at that point in time, select the information icon corresponding to any section heading.

:::image type="content" source="media/faq-sa-about-relationship-analytics-side-pane-fields.png" alt-text="Screenshot of the relationship analytics side pane.":::

## Notes analysis

### What does Notes analysis look at for the intent?​  

Notes analysis looks at notes and posts on the timeline for the intent that may indicate a record should be created. Notes analysis looks for meeting requests, meetings, tasks, and contacts.

## Auto capture

### How long does the application take to display captured suggestions?

For activities, the suggestions are displayed immediately.  


## Who knows whom

### Why am I not seeing some of my colleagues in the who knows whom suggestions?

If you know that a colleague has interacted with a customer but their information is not shown in Who Knows Whom widget, it could be due to the following reasons:

**Basic insights:**

Displays only the top five users who contacted the customer the most through emails and appointments in Dynamics 365. So, colleagues who have contacted through phone calls and those who had fewer interactions through emails and appointments will not be listed.

**Enhanced insights:**

- Those colleagues are not a part of your Dynamics 365 organization.
- Those colleagues are not a part of the security role that's [enabled for relationship intelligence](enable-ri.md).  
- Those colleagues are a part of the security group that your Office 365 admin has [opted out](provide-consent-office365.md).
- Those colleagues have explicitly [opted out of sharing their data](who-knows-whom.md#turn-off-data-sharing-with-dynamics-365-applications).

See also [Which colleagues show up as connections?](#which-colleagues-show-up-as-connections)

### How long does it take for suggestions to appear?

**Basic insights:**
 
 Who knows whom suggestions are available out-of-the-box if the email and appointment data is available in Dynamics 365.

**Enhanced insights:**

After your Microsoft 365 admin provides consent, you'll start seeing the results within a day. However, the suggestions may not be complete right away as the data will be processed in batches over a period of four days.  

### Which colleagues show up as connections?

**Basic insights:**

Users who have contacted the customer the most through emails and appointments in Dynamics 365.

**Enhanced insights:**

Users in your organization who have frequently and recently interacted with the contact or lead show up as connections, unless they have opted out. Administrators have the option to [opt out groups](provide-consent-office365.md) such as C-suite, M&A, finance, and so on. Users can opt out by [turning off data sharing with Dynamics 365 applications](who-knows-whom.md#turn-off-data-sharing-with-dynamics-365-applications).

### How are the connections weighted?

**Basic insights:**  
Uses only frequency. The connections are weighted based on the number of interactions through emails and appointments in Dynamics 365. Top five users who have interacted the most with the contact or lead are displayed.  

**Enhanced insights:**  
Uses frequency and recency. If your administrator has enabled Exchange integration, the connections are weighted based on recent and frequent interactions through emails or appointments. 

Every seller will see the same set of introducers for a contact or lead. 


### How frequently is the data collected?

**Basic insights:**

Collected in near real-time&mdash;as soon as a related activity is marked as completed in Dynamics 365.  

**Enhanced insights:**  ​  

When you enable who knows whom and provide the required consent, Exchange data for the past year is collected and insights are generated based on that data. After this, Exchange data is collected daily and insights are updated based on the latest data.  

### What is the source for who knows whom data?

**Basic insights:**

Emails and appointments sent and received in Dynamics 365.

**Enhanced insights**
 ​  
Emails and meeting information in Exchange Online is the source data. [Learn more about how connections weighted](#how-are-the-connections-weighted)

### Where are the insights from Exchange generated?

After the Microsoft 365 admin provides consent, the Exchange data is collected and stored in Dynamics 365. Insights are generated from the stored data in Dynamics 365.  

> [!IMPORTANT]
> Microsoft 365 and Dynamics 365 each have their own service-specific licensing terms. The service-specific terms that apply depend on which service processes your data. For example, when a copy of your Microsoft 365 data is transferred to Dynamics 365, your Microsoft 365 data in that copy becomes Dynamics 365 data and the Dynamics 365 service-specific terms apply.


### When will my data be removed after I opt out of data sharing in Exchange?

If you're part of a security group that has been opted out by your administrator, the system can take up to 24 hours to remove data from all apps. It can take up to 30 days to remove backed-up data from Microsoft 365 storage accounts.  

If you've [opted out on your own](who-knows-whom.md#turn-off-data-sharing-with-dynamics-365-applications), the data is removed immediately.  

### How can an administrator opt out users?

The following administrators can opt out users at different levels:

- **Microsoft 365 Global administrator** can opt out users of a Microsoft 365 security group. For example, opt out groups such as C-suite, M&A, finance, and so on. More information: [Provide consent to collect data from Microsoft 365](provide-consent-office365.md)

- **Dynamics 365 administrator** can enable who knows whom for specific security roles to avoid opting in all Dynamics 365 users automatically. When you enable it for a specific role, the Exchange data is collected only from users who are part of the security role. More information: [Enable relationship intelligence](enable-ri.md)

### See also

[Overview of Dynamics 365 Sales](overview.md)  
[Introduction to administering Sales Insights features](intro-admin-guide-sales-insights.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
