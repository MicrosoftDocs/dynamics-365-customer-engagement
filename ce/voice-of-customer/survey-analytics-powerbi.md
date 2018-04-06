---
title: "Survey analytics using Power BI | MicrosoftDocs"
description: "Learn how to connect Voice of the Customer instance to Power BI and get insights about the surveys."
keywords: "voice of the customer analytics, voice of the customer analytics app for power BI"
ms.date: 04/06/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 033D39F5-5CB1-436F-966A-74ED90C7E73D
author: sbmjais
ms.author: shjais
manager: sakudes
ms.reviewer: 
topic-status: Drafting
---

# Survey analytics using Power BI

The Voice of the Customer Analytics for Dynamics 365 content pack for Power BI allows you to connect to your Voice of the Customer for Dynamics 365 instance and get insights about the surveys and their responses. As a Survey Administrator or Survey Designer, you can track metrics, such as average NPS, average CSAT score, and response ratio and get visibility into the surveys. The dashboard and reports allow you to explore and analyze the survey data as you need.

## Install and configure content pack for Voice of the Customer

You must install the Voice of the Customer for Dynamics 365 app from Microsoft AppSource.

1. Sign in to [Power BI](https://powerbi.microsoft.com/).
2. Select **Apps** from the left navigation pane.
3. Select **Get apps**. 
4. In AppSource, select the **Apps** tab.
5. Search for the Voice of the Customer Analytics for Dynamics 365 app and select **Get it now**. A wizard opens to connect to the Dynamics 365 instance.
6. Enter the service URL associated to your Dynamics 365 account and select oAuth2 as the authentication method.
7. Enter the credentials and select **Sign in**.

## Uninstall content pack for Voice of the Customer

1. Sign in to [Power BI](https://powerbi.microsoft.com/).
2. Select **Apps** from the left navigation pane.
3. Point to the app and select **Delete**.
4. Select **Delete** in the confirmation dialog box. The app and its related data are deleted.

## Dashboard

Dashboard is an intuitive user interface that graphically represents the survey insights. It consists of various tiles that provides an overview of the metrics, such as average NPS, average CSAT score, and response ratio and get visibility into the surveys. This allows you to explore and analyze the survey data as needed. When you click a tile on the dashboard, the corresponding report opens for further analysis.

More information: [Dashboards in Power BI service](https://docs.microsoft.com/en-us/power-bi/service-dashboards)

To open dashboard:

1. Sign in to [Power BI](https://powerbi.microsoft.com/).
2. Select **Apps** from the left navigation pane.
3. Select the app.

The dashboard contains the following tiles:

- **Total Surveys**: Displays the total number of surveys created. When you click this tile, the **Surveys** page in the report is opened.
- **Survey Invites Sent**: Displays the total number of survey invites sent. When you click this tile, the **Survey Responses** page in the report is opened.
- **Non-anonymous Responses**: Displays the number of non-anonymous survey responses received. When you click this tile, the **Survey Responses** page in the report is opened.
- **Anonymous Responses**: Displays the number of anonymous survey responses received. When you click this tile, the **Survey Responses** page in the report is opened.
- **Average CSAT**: Displays the average CSAT score. When you click this tile, the **Customer Satisfaction** page in the report is opened.
- **Survey Score**: Displays the average survey score percentage. When you click this tile, the **Customer Satisfaction** page in the report is opened.
- **Average NPS**: Displays the average NPS score. When you click this tile, the **Customer Satisfaction** page in the report is opened.
- **NPS Type**: Displays the survey distribution of promotor, passive, and detractor NPS types. If you select a pie, data in other NPS tiles are refreshed accordingly. When you click this tile, the **Customer Satisfaction** page in the report is opened.
- **CSAT Trend**: Displays the trend of average CSAT score over a period of time. The x-axis displays the time period and y-axis displays the average CSAT score. When you click this tile, the **Customer Satisfaction** page in the report is opened.
- **NPS Trend**: Displays the trend of average Net Promoter Scores over a period of time. The x-axis displays the time period and y-axis displays the average NPS. When you click this tile, the **Customer Satisfaction** page in the report is opened.
- **Survey Invite Trend**: Displays the number of survey invites sent over a period of time. The x-axis displays the time period and y-axis displays the count of survey invites sent. To view details, point to a data point on the line graph. When you click this tile, the **Survey Responses** page in the report is opened.
- **Response Time (from Invite Sent to Response Submitted)**: Displays the turnaround time for survey responses in 50th, 95th, and 99th percentile. The x-axis displays the survey name and y-axis displays the percentile. The unit is in seconds. When you click this tile, the **Survey Responses** page in the report is opened.

![Voice of the Customer Analytics for Dynamics 365 dashboard](media/voc-analytics-dashboard.png "Voice of the Customer Analytics for Dynamics 365 dashboard") 

## Report

Report allows you to view detailed survey insights graphically. You can open a report by selecting a tile on the dashboard. The Voice of the Customer Analytics app contains the following pages in the report:
- Surveys
- Survey Responses
- Customer Satisfaction
- Question Responses
- Grid Question Responses

More information: [Reports in Power BI](https://docs.microsoft.com/en-us/power-bi/service-reports)

### Survey Responses

The Survey Responses page in the report displays insights of the survey responses received. The data on the page is displayed in tiles. You can filter the data by using the following filters:

- **Select survey**: Select a survey to display data of the selected survey. By default, all surveys are selected.
- **Date range**: Select a date range to display data in the selected date range. By default, the date range selected is from the earliest date to the latest date of the survey response.

The data is displayed in the following tiles:

- **Survey Invites Sent**: Displays the total number of survey invites sent.
- **Non-anonymous Responses**: Displays the number of non-anonymous survey responses received.
- **Response Ratio**: Displays the ratio of the survey responses received and the survey invites sent. It is calculated as follows:

  `(Number of survey invites with a survey response) / (Total number of survey invites created)`
  
- **Anonymous Responses**: Displays the number of anonymous survey responses received.
- **Non-anonymous Responses Trend**: Displays the number of non-anonymous survey responses received over a period of time. The x-axis displays the time period and y-axis displays the count of survey responses received. To view details, point to a data point on the line graph.
- **Anonymous Responses Trend**: Displays the number of anonymous survey responses received over a period of time. The x-axis displays the time period and y-axis displays the count of survey responses received. To view details, point to a data point on the line graph.
- **Survey Invites Trend**: Displays the number of survey invites sent over a period of time. The x-axis displays the time period and y-axis displays the count of survey invites sent. To view details, point to a data point on the line graph.
- **Response Time (from Invite Sent to Response Submitted)**: Displays the turnaround time for survey responses in 50th, 95th, and 99th percentile. The x-axis displays the survey name and y-axis displays the percentile. The unit is in seconds.

![Survey Responses report in Voice of the Customer Analytics for Dynamics 365](media/voc-analytics-survey-responses.png "Survey Responses report in Voice of the Customer Analytics for Dynamics 365")

### Surveys

The Survey page in the report displays insights of the surveys created in Dynamics 365. The data on the page is displayed in tiles. You can filter the data by using the following filters:

- **Select survey**: Select a survey to display data of the selected survey. By default, all surveys are selected.
- **Date range**: Select a date range to display data in the selected date range. By default, the date range selected is from the earliest date to the latest date of the survey response.

The data is displayed in the following tiles:

- **Total Surveys**: Displays the total number of surveys created.
- **Survey State**: Displays the distribution of surveys states: draft, published, inactive, stopped, and closed.
- **Survey Efficacy by Questions and Page Count**: Displays page count, question count, and response ratio. It displays the variation of response ratio depending on page and question count.
- **Question Types**: Displays the distribution of the number of times a question type has been used in a survey. The x-axis displays the question types and y-axis displays the number of times a question type has been used.

![Surveys report in Voice of the Customer Analytics for Dynamics 365](media/voc-analytics-surveys.png "Surveys report in Voice of the Customer Analytics for Dynamics 365")

### Customer Satisfaction

The Customer Satisfaction page in the report displays insights based on the NPS and CSAT scores received. The data on the page is displayed in tiles. You can filter the data by using the following filters:

- **Select survey**: Select a survey to display data of the selected survey. By default, all surveys are selected.
- **Date range**: Select a date range to display data in the selected date range. By default, the date range selected is from the earliest date to the latest date of the survey response.

The data is displayed in the following tiles:

- **Survey Score**: Displays the average survey score percentage.
- **Net Promoter Score**: Displays the Net Promoter Score of the selected survey. It is calculated by subtracting the percentage of detractors from the percentage of promoters.
- **Average NPS**: Displays the average NPS score.
- **Average CSAT**: Displays the average CSAT score.
- **Survey Score Trend**: Displays the trend of average survey score over a period of time. The x-axis displays the time period and y-axis displays the average score.
- **CSAT Trend**: Displays the trend of average CSAT score over a period of time. The x-axis displays the time period and y-axis displays the average CSAT score.
- **CSAT Score Distribution**: Displays the survey response distribution of the CSAT scores. The x-axis displays the CSAT score and y-axis displays the count of the survey responses.
- **NPS Type**: Displays the survey distribution of promotor, passive, and detractor NPS types. If you select a pie, data in other NPS tiles are refreshed accordingly.
- **NPS Trend**: Displays the trend of average Net Promoter Scores over a period of time. The x-axis displays the time period and y-axis displays the average NPS.
- **NPS Score Distribution**: Displays the survey response distribution of the Net Promoter Scores. The x-axis displays the NPS score and y-axis displays the count of the survey responses.

![Customer Satisfaction report in Voice of the Customer Analytics for Dynamics 365](media/voc-analytics-customer-satisfaction.png "Customer Satisfaction report in Voice of the Customer Analytics for Dynamics 365")

### Question Responses

The Question Responses page in the report displays insights of the questions (other than the grid questions) created in a survey. The data on the page is grouped in tiles based on the question type. You can filter the data by using the following filters:

- **Select survey**: Select a survey to display data of the selected survey. By default, all surveys are selected.
- **Date range**: Select a date range to display data in the selected date range. By default, the date range selected is from the earliest date to the latest date of the survey response.

The data is displayed in the following tiles:

- **Text Questions**: Displays a word cloud based on the question selected from the drop-down list. You can select only the questions of type short answer or long answer.
- **Single Response**: Displays the distribution of the responses in the question of type single response or smilies rating. Select a question from the drop-down list to view its details. The labels displayed on the pie chart are the responses.
- **Multiple Responses**: Displays the distribution of the responses in the question of type multiple responses. Select a question from the drop-down list to view its details. The x-axis displays the responses and the y-axis displays the number of times a response is selected.
- **CSAT**: Displays the average, distribution, and trend of a CSAT question. When you select a question from the drop-down list, the following tiles are refreshed to display the corresponding data:
  - **Average CSAT**: Displays the average CSAT.
  - **CSAT Trend**: Displays the trend of average CSAT score over a period of time. The x-axis displays the time period and y-axis displays the average CSAT score.
  - **CSAT Distribution**: Displays survey response distribution of the CSAT score. The x-axis displays the CSAT score and y-axis displays the count of the survey responses.
- **NPS**: Displays the average, distribution, and trend of an NPS question. When you select a question from the drop-down list, the following tiles are refreshed to display the corresponding data:
  - **Average NPS Score**: Displays the average NPS.
  - **NPS Trend**: Displays the trend of average Net Promoter Scores over a period of time. The x-axis displays the time period and y-axis displays the average NPS.
  - **NPS Distribution**: Displays survey response distribution of the Net Promoter Scores. The x-axis displays the NPS and y-axis displays the count of the survey responses.
- **Rating and CES**: Displays the average, distribution, and trend of a question of type Customer Effort Score and rating. When you select a question from the drop-down list, the following tiles are refreshed to display the corresponding data:
  - **Average CES**: Displays the average customer effort score.
  - **CES Trend**: Displays the trend of average CES score over a period of time. The x-axis displays the time period and y-axis displays the average CES score.
  - **CES Distribution**: Displays survey response distribution of the CES score. The x-axis displays the NPS and y-axis displays the count of the survey responses.

![Question Responses report in Voice of the Customer Analytics for Dynamics 365](media/voc-analytics-question-responses.png "Question Responses report in Voice of the Customer Analytics for Dynamics 365")

### Grid Question Responses

The Grid Question Responses page in the report displays insights of the grid questions created in a survey. The data on the page is displayed in tiles. You can filter the data by using the following filters:

- **Select survey**: Select a survey to display data of the selected survey. By default, all surveys are selected.
- **Date range**: Select a date range to display data in the selected date range. By default, the date range selected is from the earliest date to the latest date of the survey response.

The data is displayed in the following tiles:

- **Fixed Sum Question**: Displays the distribution of the average sum of each response in the question of type fixed sum. Select a question from the drop-down list to view its details. The x-axis displays the questions and the y-axis displays the average.
- **Ranking**: Displays the distribution of the average rank of each response in the question of type ranking. Select a question from the drop-down list to view its details. The x-axis displays the answer options and the y-axis displays the average.
- **Single Rating in Columns**: Displays the distribution of the responses in a question of type single rating in columns. Select a question from the drop-down list to view its details. You can also drill-down the pie chart to view more information.
- **Multiple Ratings in Columns**: Displays the distribution of the responses in a question of type multiple ratings in columns. Select a question from the drop-down list to view its details. You can also drill-down the pie chart to view more information.
- **Numeric Questions**: Displays the average and distribution of a question of type numerical response. When you select a question from the drop-down list, the following tiles are refreshed to display the corresponding data:
  - **Average Numeric Response**: Displays the average numeric response.
  - **Numeric Response Distribution**: Displays the distribution of the score.
- **List of Ratings**: Displays the distribution of the responses in a question of type list of ratings. Select a question from the drop-down list to view its details. You can also drill-down the pie chart to view more information.

![Grid Question Responses report in Voice of the Customer Analytics for Dynamics 365](media/voc-analytics-grid-question-responses.png "Grid Question Responses report in Voice of the Customer Analytics for Dynamics 365")