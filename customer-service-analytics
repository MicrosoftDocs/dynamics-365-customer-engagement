---
title: Customer Service Analytics for Dynamics 365 | Microsoft Docs
description: Dashboard provides historical operational metrics and KPIs to manage contact centers.  
author: lerobbin
ms.author: lerobbin
manager: autumna
ms.date: 10/24/2019
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: dyn365-customerservice
ms.assetid: f5c8e858-c58a-4d7a-88f2-e59fc8eb541b
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Customer Service Analytics for Dynamics 365

The Customer Service Analytics dashboard provides information about the historical operational metrics and key performance indicators (KPIs) to effectively manage contact centers. 

The following is an example of the Customer Service Analytics overview dashboard:  

    > [!div class=mx-imgBorder]
    > ![Customer Service Analytics overview dashboard](../media/cs-analytics-overview-dashboard.png "Customer Service Analytics overview dashboard")
  
This section consists of the following KPIs.  

| KPI                        | Description                                                       |
|----------------------------|-------------------------------------------------------------------|
|Total cases                 |Number of cases created to support customers.                      |
|Active Cases                |Number of cases which are current open.                            |
|Resolved cases              |Number of cases which have been closed by agent.                   |
|Escalated Cases %           |Percentages of cases which have been escalated.                    |
|Average Handle Time (mins)  |Average length of time taken by an agent to resolve the case.      |
|Avg. CSAT                   |Average customer satisfaction score based on the survey submitted by the customer. |
|Case age                    |Average time the case was in open state.                           |
|Total Activities            |Total activities which are created by agents                       |


|Filters/Dimensions          |Description                                                        |
|----------------------------|-------------------------------------------------------------------|
|Duration                    |Filters the date range users would like to see the reporting for.  |
|Queue                       |Provides an ability for the user to filter the queue which they would like to drill deeper and see all metrics related to those queue(s). |
|Agent                       |Provides an ability for the supervisor to filter all their reporting agents to understand how each one of them are performing and can plan to coach/train agents.  |
|Priority                    |Filters the reporting to selected priority of the case. (High, Normal, Low) |
|Subject                     |Filters the reporting to selected subject of the case.  |
|Channel                     |Filters the reporting to the selected omnichannel channels. (Example – Chat, SMS, Facebook etc)  |

## Analytics Reports
The following is an example a of the **Customer Service Analytics** report detail view. 

The Customer Service Analytics report detail view has three views:  

1.	**Summary view**  
    This view provides key KPIs and metrics across customer service with an ability for supervisors to filter the view based on filters:

    > [!div class=mx-imgBorder]
    > ![Customer Service Analytics Summary View](../media/cs-analytics-summary-view.png "Customer Service analytics summary view")
    
This section contains the following visuals/KPIs:

|Visuals/KPI                         |Description                                                                   |
|------------------------------------|------------------------------------------------------------------------------|
|Incoming cases by channel           |This visual shows the volume of cases created in each of the support channel. |
|Incoming cases by priority          |This visual shows the volume of active and resolved cases by priority.        |
|Incoming cases by subject           |This visual shows active and resolved cases by each subject. This considers the last node in the subject hierarchy. |
|Incoming cases by SLA status        |This visual shows the volume of active and resolved cases by SLA status.      |
|Case volume trend                   |This visual shows the trend of active and resolved cases based on the time the case was created. |
|Case by age                         |This visual groups the cases which are currently open and grouped on the number of days/weeks/months they are currently open. |
|Escalated case trend                |This visual shows the trend of cases escalated over the period selected. |
|CSAT trend                          |This visual shows the CSAT trend over the period selected.               |


2.	**Agent/Queue view**
    This view provides key KPIs and metrics across customer service with an ability for supervisors to filter the view based on filters:

    > [!div class=mx-imgBorder]
    > ![Customer Service Analytics Agent/Queue view](../media/cs-analytics-agent-queue-view.png "Customer Service analytics Agent/Queue  view")
    
 This section contains the following visuals/KPIs:
 
 |Visuals/KPI                               |Description                                                            |
 |------------------------------------------|-----------------------------------------------------------------------|
 |Agents with most cases                    |This visual shows the top agents who has handled most cases along with the states of those cases.|
 |Agents with most open activities          |This visual shows the agents with most open activities. This helps supervisor to help agents clear the backlog.|
 |Agents with highest avg. handle time      |This visual shows the agents with most average handle time.|
 |Agents with highest CSAT                  |This visual shows the top agents with high CSAT. |
 |Agents with lowest CSAT                   |This visual shows the agents with low CSAT. Supervisors can use this information to train agents and improve overall customer satisfaction.|
 |Key influences for CSAT                   |The key influencers visual helps you understand the factors that drive CSAT metric. It analyzes your data, ranks the factors that matter, and displays them as key influencers. |
 |Open activities by agent                  |This visual shows the number of open activities by agent and type of activity.|
 
 3.	**Case/Activity list view** 
     This view provides key KPIs and metrics across customer service with an ability for supervisors to filter the view based on filters:
    
    > [!div class=mx-imgBorder]
    > ![Customer Service Analytics Case/Activity list view](../media/cs-analytics-case-activity-list-view.png "Customer Service analytics Case/Activity list view") 
    
## View and filter report  
You can filter information by viewing the reports and selecting: Duration, Queue, Agent, Priority, Subject and case status. 
    
    > [!div class=mx-imgBorder]
    > ![Customer Service Analytics View and Filter Report](../media/cs-analytics-view-filer report.png "Customer Service analytics view and filter report") 
    
Select: Queue, Agent, Priority, Subject or Date as required, and information is filtered according to selection. This helps to quickly analyze KPIs and take necessary steps to improve outcomes. 

## Configure Customer Service Analytics dashboard
You must perform the following steps to configure the historical customer service analytics dashboards to display in customer service Hub app:  
Step 1: Review the prerequisites 
Step 2: Install Dynamics 365 Customer Service Analytics app 
Step 3: Connect Dynamics 365 organization to Customer Service Analytics app 
Step 4: Configure refresh frequency on Power BI Dataset 
Step 5: Publish application within your organization 
Step 6: Enable Power BI reporting in Dynamics 365 for Customer Engagement 
Step 7: Add Power BI Dashboard to Customer Service Hub 

## Step 1: Prerequisites 

Review the following prerequisites before configuring the supervisor dashboard: 
•	You have administrative privileges for Dynamics 365 and Power BI. 
•	You have a Power BI Pro license for all supervisors. 

## Step 2: Install Dynamics 365 Customer Service Analytics app 

1.	Sign in to [Power BI](https://app.powerbi.com/) app as an administrator. 
2.	As a Power BI admin, browse to this link: [http://aka.ms/cs-insights](http://aka.ms/cs-insights) 
3.	Install **Dynamics 365 Customer Service Analytics** app. 
4.	After **Dynamics 365 Customer Service Analytics** app is installed, the app configuration options page displays. 
    
    > [!div class=mx-imgBorder]
    > ![Customer Service app install](../media/cs-service-app-install.png "Customer Service app install view") 
    
Now you can proceed to configure the app by connecting your Dynamics 365 organization. 

## Step 3: Connect Dynamics 365 organization to Customer Service Analytics app
 
1.	On the **Dynamics 365 Customer Service Analytics** app configuration options page, select **Connect data**. 
    
    > [!div class=mx-imgBorder]
    > ![Customer Service app install - connect data](../media/cs-app-get-started.png "Customer Service app install connect data") 
    
2.	On the connect data page, enter your organization's Dynamics 365 Service Root URL and select **Next**. 
    
    > [!div class=mx-imgBorder]
    > ![Customer Service app install - root url](../media/cs-analytics-root-url.png "Customer Service app install - root url") 

3.	(Optional) To find the Microsoft Dynamics 365 OData URL, follow these steps: 
    a.	Sign into Dynamics 365 for Customer Engagement. 
    b.	Go to **Settings** and then select **Developer Resources**.  
    c.	Find the OData URL under **Service Root URL**. 
    
    > [!div class=mx-imgBorder]
    > ![Customer Service app install - odata url](../media/cs-analytics-odata-url.png "Customer Service app install - odata url") 

4.	Select **Authentication method** as **OAuth2** and **Privacy level** as **Organizational**. Select **Sign in**. 
    
    > [!div class=mx-imgBorder]
    > ![Customer Service app install](../media/cs-analytics-install.png "Customer Service app install") 
    
5.	Enter your Dynamics 365 organization credentials and press **Enter**. 

When you are successfully signed in, the existing report will be updated with the data from your organization. 
Now configure the refresh frequency for the reports and dashboards. 

## Step 4: Configure refresh frequency on Power BI Dataset 
After you connect Dynamics 365 Customer Service Analytics app with Dynamics 365 organization, you need to configure the refresh frequency on the Power BI dataset to refresh the report and dashboards properly. 

1.	Sign into Power BI app as administrator
2.	Go to the **Dynamics 365 Customer Service Analytics** app **workspace**
    
    > [!div class=mx-imgBorder]
    > ![Customer Service app install - refresh frequency](../media/cs-analytics-refresh-frequency.png "Customer Service app install - refresh frequency")
    
 3.	Go to **Datasets** tab and select **Settings**
     
    > [!div class=mx-imgBorder]
    > ![Customer Service app install - data settings](../media/cs-analytics-data-settings.png "Customer Service app install - data settings")
 
4.	Turn **on** the **Scheduled refresh**
     
    > [!div class=mx-imgBorder]
    > ![Customer Service app install - Scheduled refresh](../media/cs-analytics-schedule-refresh.png "Customer Service app install - Scheduled refresh")

Now, publish the application in your organization. 

> [!NOTE]
> We recommend you configure the refresh frequency to **Daily**. 

## Step 5: Publish application within your organization 
You must share the configured application with your entire organization so supervisors can view **Customer Service Analytics** dashboards and reports with their own **Power BI Pro** accounts. 

1.	On the App workspace, select **Update app**
     
    > [!div class=mx-imgBorder]
    > ![Customer Service app install - Publish application](../media/cs-analytics-publish-application.png "Customer Service app install - Publish application")
    
2.	In the Update app wizard, go to the **Access** tab 
3.	Choose **Entire organization** and select **Update app**
     
    > [!div class=mx-imgBorder]
    > ![Customer Service app install - application](../media/cs-analytics-update-app.png "Customer Service app install - application")

The app is now available to install for all individuals in your organization. 
 
> [!NOTE]
> Verify your administrator has allowed users in your organization to have read/write data permissions in Omnichannel Engagement Hub. T To learn more, see [Provide data access consent](https://review.docs.microsoft.com/en-us/dynamics365/omnichannel/administrator/omnichannel-provision-license#provide-data-access-consent) 

## Step 6: Enable Power BI reporting in Dynamics 365 for Customer Engagement 
As an administrator, you must enable Power BI reporting in the Dynamics 365 for Customer Engagement organization for supervisors to view the dashboards in the Omni-channel Administration app. 

1.	**Sign In** to Dynamics 365 for Customer Engagement and go to **Settings** 
2.	Select **Administration, System Settings**
3.	Go to the **Reporting** tab and enable **Allow Power BI visualization embedding**
     
    > [!div class=mx-imgBorder]
    > ![Customer Service app install - enable pbi](../media/cs-analytics-enable-pbi.png "Customer Service app install - enable pbi")

Now, supervisors can configure the dashboards in Dynamics 365. 
 
## Step 7: Add Power BI Dashboards to Customer Service Hub 
Each supervisor must configure their Dynamics 365 for Customer Engagement environment to integrate the Customer Service Analytics dashboard. 

1.	Sign in to Dynamics 365 for Customer Engagement and open the **Customer Service Hub** app 
     
    > [!div class=mx-imgBorder]
    > ![Customer Service app install](../media/cs-analytics-cs-hub.png "Customer Service app install")

2.	Open **Supervisor Dashboards**
     
    > [!div class=mx-imgBorder]
    > ![Customer Service app install](../media/cs-analytics-supervisor-dashboard.png "Customer Service app install")

3.	Select **New, Power BI Dashboard**
 
4.	Choose **Workspace** as **Dynamics 365 Customer Service Analytics** and **Dashboard** as **Customer Service Analytics Dashboard**. 
5.	Save and close. 
6.	Repeat Step 3 to step 5 to add Omni-channel Sentiment Insights app. 

Customer Service Analytics dashboard is now available in Dynamics 365.  

## Add users to supervisor configuration  
You must add users in the supervisor configuration to access any supervisor dashboard in Unified Service Desk. To add users in supervisor configuration, follow these steps: 
 
1.	Log in to Dynamics 365.  
2.	Go to **Settings, Unified Service Desk** and then select **Configuration**.  
3.	On the configuration page, select **Supervisor Configuration**.   
4.	On the **Users** section, select **+ Add User record** and enter the user name to add the user.  
5.	Save and close the configuration.   

Users are added to the supervisor dashboard and when they log in to Omni-channel Engagement Hub on Unified Service Desk, the supervisor dashboard tabs are available. 
 
## Customize Customer Service Analytics 
You must perform the below steps if you would like to enhance/customize the PowerBI template app for your organization needs.  
 
Please be aware that you will not be able to get future updates to the PowerBI template app if you customize it and customized solution will not be supported by Microsoft.  

## See Also 
[Introduction to Omnichannel Insights dashboard](https://docs.microsoft.com/en-us/dynamics365/omnichannel/supervisor/intro-dynamics-365-omnichannel-insights-dashboard) 
[Configure Omnichannel Insights dashboards](https://docs.microsoft.com/en-us/dynamics365/omnichannel/administrator/configure-historical-sentiment-dashboard-supervisor) 
[View and understand Omnichannel Insights dashboards](https://docs.microsoft.com/en-us/dynamics365/omnichannel/supervisor/omnichannel-insights-dashboard) 
     

    


