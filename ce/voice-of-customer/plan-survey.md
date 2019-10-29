---
title: "Plan a survey to be created by using Voice of the Customer | MicrosoftDocs"
description: "Plan to create a survey using Voice of the Customer."
keywords: plan a survey; survey best practices; survey question types
ms.date: 07/01/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: ad3388d5-4c50-4005-a067-8498069ead93
author: sbmjais
ms.author: shjais
manager: shujoshi
ms.reviewer: 
topic-status: Drafting
ms.custom:
  - dyn365-VoC
---

# Plan a survey

> [!IMPORTANT]
> Voice of the Customer (VoC) is being deprecated and replaced with Microsoft Forms Pro. [Learn more](https://go.microsoft.com/fwlink/p/?linkid=2097704)

It's important to have a plan for configuring your Voice of the Customer surveys. Here are a few things to think about to help you design the right questions for your survey:

-   What's the purpose of your survey? For example, you might want to interact with your customers, promote new products or services, or measure customer satisfaction. If your goal is to measure something, what and how do you want to measure it?

-   How long do you want the survey to be? Keep in mind that longer surveys tend to have higher abandon rates. A good rule of thumb is to keep surveys shorter than five minutes, or no longer than 10 questions (depending on the type of question you ask).

-   How many mandatory questions are to be included in the survey? We recommend that you ask as few mandatory questions as possible.

-   Can you reuse all or part of an existing survey?

-   Do you want to analyze results from multiple surveys at once? You can do this by linking questions across surveys.

-   How do you want to distribute your survey? For example, you can create an anonymous link for a lead creation survey and broadcast it, or you can send personalized links for case closure surveys to your customers.

-   How do you want to send invitations to your survey? For example, you might want to email them or post an invitation on your website.

-   In addition, consider these recommendations to help you improve survey response rates:

    -   Send the survey with a named contact from your organization, preferably one who your respondents know.

    -   Add an image of this contact to the survey.

## Best practices to create a survey

A few best practices will enable you to create a meaningful survey and gather good responses from your customers. You can then analyze those responses and act on them as best suits your organization. A few of the best practices for designing a survey are:

- **Define an objective**: Having an objective allows you to properly plan for your survey. This also allows you to identify what results you expect from your customers. You must know how you will use the responses to help you pick the right questions for your survey.

- **Keep the survey short**: If you create a survey that takes a long time to complete, you might reduce your response rate.
- **Create a logical flow of questions**: Ensure that your survey has a logical flow of questions to keep the respondents interested in the survey.

- **Organize the survey**: Group the related questions in a section and place the related sections on a single page.

- **Ask one question at a time**: Ensure that you ask only one question at a time to keep your audience focused. Avoid asking questions that are vague or don't communicate your intent. Keep the objective of your questions clear to your respondents. Avoid asking questions that are too narrow, such as "Do you like chocolate and ice cream?"

- **Preview and test the survey**: After creating your survey, always preview it to check the overall flow of the survey and to catch any mistakes. After publishing the survey, test it to ensure that respondents can find and open it easily.

- **Mention expectations in the survey invitation**: In the survey invitation, ensure that you mention the estimated time to complete it and give a brief overview. This will help respondents submit their input within the expected timeframe.

## Decide the question type

Deciding the question types while planning a survey helps you to create an organized survey and maintain a flow between the questions. The following table describes the Voice of the Customer for Dynamics 365 question types.

**Web client**


|   **Question type**   |                                                                  **[!INCLUDE[description](../includes/description.md)]**                                                                   |                                                                                                                                                                                                                                                                                                                 **Preview**                                                                                                                                                                                                                                                                                                                 |
|-----------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|     Short answer      |                                                                            Question that has a one-line answer.                                                                            |                                                                                                                                                                                                                                                                   ![Example of a short answer question](media/short-answer-ques.png "Example of a short answer question")                                                                                                                                                                                                                                                                   |
|      Long answer      |                                                       Question that has multiple lines in the answer, for example verbatim comments.                                                       |                                                                                                                                                                                                                                                                    ![Example of a long answer question](media/long-answer-ques.png "Example of a long answer question")                                                                                                                                                                                                                                                                     |
|        Rating         |                                                  Question that asks a respondent to provide ratings by using stars, emoticons, or flags.                                                   |                                                                                                                                                                                                                                                                            ![Example of a rating question](media/rating-ques.png "Example of a rating question")                                                                                                                                                                                                                                                                            |
|    Single response    | Question that allows a respondent to choose only one answer. <br>**Note**: You can change the response type from the **Single Response Type** list while creating or editing the question. | ![Example of a single response question with big buttons as the response type](media/single-response-ques-big-button.png "Example of a single response question with big buttons as the response type") <br> ![Example of a single response question with radio buttons as the response type](media/single-response-ques-radio-button.png "Example of a single response question with radio buttons as the response type") <br>![Example of a single response question with drop down list as the response type](media/single-response-ques-drop-down.png "Example of a single response question with drop down list as the response type") |
|   Multiple response   |                                                               Question that allows a respondent to choose multiple answers.                                                                |                                                                                                          ![Example of a multiple response question with big buttons as the response type](media/multi-response-ques-big-button.png "Example of a multiple response question with big buttons as the response type") <br> ![Example of a multiple response question with check boxes as the response type](media/multi-response-ques-check-box.png "Example of a multiple response question with check boxes as the response type")                                                                                                          |
|         Date          |                                                                     Question that asks a respondent to select a date.                                                                      |                                                                                                                                                                                                                                                                               ![Example of a date question](media/date-ques.png "Example of a date question")                                                                                                                                                                                                                                                                               |
|   Descriptive text    |                                                              Use to describe elements on the survey page, for example labels.                                                              |                                                                                                                                                                                                                                                                  ![Example of descriptive text](media/descriptive-text-ques.png "Example of a descriptive text question")                                                                                                                                                                                                                                                                   |
|  Numerical response   |                                                                       Question that allows only numerical responses.                                                                       |                                                                                                                                                                                                                                                          ![Example of a numerical response question](media/numerical-response-ques.png "Example of a numerical response question")                                                                                                                                                                                                                                                          |
|        Ranking        |                                                       Question that asks a respondent to rank answers in their order of preference.                                                        |                                                                                                                                                                                                                                                                          ![Example of a ranking question](media/ranking-ques.png "Example of a ranking question")                                                                                                                                                                                                                                                                           |
|  Net Promoter Score   |                        Question that captures the satisfaction of the respondent based on the likelihood of their recommending the product or services to a friend.                        |                                                                                                                                                                                                                                                                 ![Example of a Net Promoter Score question](media/nps-ques.png "Example of a Net Promoter Score question")                                                                                                                                                                                                                                                                  |
| Customer Effort Score |                               Question that captures the satisfaction of the respondent based on the effort spent on doing business, on a five-point scale.                                |                                                                                                                                                                                                                                                              ![Example of a customer effort score question](media/ces-ques.png "Example of a customer effort score question")                                                                                                                                                                                                                                                               |
|         CSAT          |                                    Question that captures the overall satisfaction of the respondent with the product or agent, on a five-point scale.                                     |                                                                                                                                                                                                                                                              ![Example of a customer satisfaction question](media/csat-ques.png "Example of a customer satisfaction question")                                                                                                                                                                                                                                                              |
|       Fixed sum       |                                          List of questions that ask a respondent to distribute ratings for the given criteria that add up to 100.                                          |                                                                                                                                                                                                                                                                       ![Example of a fixed sum question](media/fixed-sum-ques.png "Example of a fixed sum question")                                                                                                                                                                                                                                                                        |
|      Upload file      |           Allow a respondent to upload a file. <br> Supported file types: .png, .jpg, .gif, .doc, .docx, .pdf, .xls, .xlsx, .zip, .txt, .ppt, .pptx <br> Maximum file size: 5 MB           |                                                                                                                                                                                                                                                                    ![Example of a upload file question](media/upload-file-ques.png "Example of a upload file question")                                                                                                                                                                                                                                                                     |
|    Smilies rating     |                                               Question that asks a respondent to express their satisfaction by using emoticons ("smilies").                                                |                                                                                                                                                                                                                                                                ![Example of a smilies rating question](media/smilies-rating-ques.png "Example of a smilies rating question")                                                                                                                                                                                                                                                                |
|                       |                                                                                                                                                                                            |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |

The following table describes the question types to use when you need to address multiple questions that use the same option set.


|      **Question type**      |                   **[!INCLUDE[description](../includes/description.md)]**                    |                                                              **Preview**                                                               |
|-----------------------------|----------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------|
|       List of ratings       |      List of questions that ask a respondent to rate multiple items by using emoticons.      |              ![Example of a list of ratings question](media/list-rating-ques.png "Example of a list of ratings question")              |
|  Single rating in columns   |   List of questions that allow a respondent to select one answer from a column of choices.   |   ![Example of a single rating in column question](media/single-rating-col-ques.png "Example of a single rating in column question")   |
| Multiple ratings in columns | List of questions that ask a respondent to select multiple answers from a column of choices. | ![Example of a multiple ratings in column question](media/multi-rating-col-ques.png "Example of a multiple rating in column question") |
|                             |                                                                                              |                                                                                                                                        |

**Voice of the Customer app**


| **Question type** |                                                     **[!INCLUDE[description](../includes/description.md)]**                                                     |                                                 **Preview**                                                  |
|-------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------|
|     Check box     |   Question that allows a respondent to choose multiple answers.<br>**Note**: You can change the layout of the answer options from the **Option layout** list.   |           ![Example of a check box question](media/checkbox.png "Example of a check box question")           |
|       CSAT        |                       Question that captures the overall satisfaction of the respondent with the product or agent, on a five-point scale.                       | ![Example of a customer satisfaction question](media/csat.png "Example of a customer satisfaction question") |
|  Customer effort  |                  Question that captures the satisfaction of the respondent based on the effort spent on doing business, on a five-point scale.                  | ![Example of a customer effort score question](media/ces.png "Example of a customer effort score question")  |
|       Date        |                                                        Question that asks a respondent to select a date.                                                        |                  ![Example of a date question](media/date.png "Example of a date question")                  |
|     Drop down     |                                          Question that allows a respondent to choose one answer from a drop-down list.                                          |     ![Example of a drop down list question](media/drop-down.png "Example of a drop down list question")      |
|       Email       |                                                     Question that asks a respondent to enter email address.                                                     |               ![Example of an email question](media/email.png "Example of an email question")                |
|       Label       |                                                Use to describe elements on the survey page; for example, labels.                                                |                ![Example of a label question](media/label.png "Example of a label question")                 |
|    Long answer    |                                         Question that has multiple lines in the answer; for example, verbatim comments.                                         |       ![Example of a long answer question](media/long-answer.png "Example of a long answer question")        |
|        NPS        |          Question that captures the satisfaction of the respondent based on the likelihood of their recommending the product or services to a friend.           |    ![Example of a Net Promoter Score question](media/nps.png "Example of a Net Promoter Score question")     |
|      Numeric      |                                                         Question that allows only numerical responses.                                                          |    ![Example of a numeric response question](media/numeric.png "Example of a numeric response question")     |
|   Radio button    |   Question that allows a respondent to choose only one answer.<br>**Note**: You can change the layout of the answer options from the **Option layout** list.    |      ![Example of a radio button question](media/radio-button.png "Example of a radio button question")      |
|   Short answer    |                                                              Question that has a one-line answer.                                                               |      ![Example of a short answer question](media/short-answer.png "Example of a short answer question")      |
|    Star rating    |                                     Question that asks a respondent to provide ratings by using stars, emoticons, or flags.                                     |          ![Example of a star rating question](media/rating.png "Example of a star rating question")          |
|    Upload file    | Allow a respondent to upload a file.<br>Supported file types: .png, .jpg, .gif, .doc, .docx, .pdf, .xls, .xlsx, .zip, .txt, .ppt, .pptx<br>Maximum file size: 5 |       ![Example of a upload file question](media/upload-file.png "Example of a upload file question")        |
|      Website      |                                                     Question that asks a respondent to enter a website URL.                                                     |             ![Example of a website question](media/website.png "Example of a website question")              |

More information about how to add a question to your survey: [Create and add survey questions](design-basic-survey.md#create-and-add-survey-questions)  

> [!NOTE]
> Some of the question types are supported only in web client as of now. They will be added to the Voice of the Customer app in a future release. If you want to use any of those question types, you can continue to use them in web client.

## Available workflows in Voice of the Customer

Voice of the Customer provides the following workflows out-of-the-box.


|                 **Workflow name**                  | **Primary entity** |                   **[!INCLUDE[description](../includes/description.md)]**                   |
|----------------------------------------------------|--------------------|---------------------------------------------------------------------------------------------|
|            VoC - Close Survey Activity             |  Survey Activity   |                Close a survey activity when a closing response is received.                 |
|     VoC - Convert Response To Feedback Entity      |  Survey Response   |            Create a feedback entity record corresponding to the survey response.            |
| VoC - Convert Survey Response To Campaign Response |  Survey Response   |       Create a campaign response based on the survey invitation and survey response.        |
|                 VoC - Create Lead                  |  Survey Response   |                Create a lead corresponding to the anonymous survey response.                |
|            VoC - Process Face Response             |  Survey Response   | Process the survey response and classify the respondent as promoter, detractor, or neutral. |
|             VoC - Process NPS Response             |  Survey Response   | Process the survey response and classify the respondent as promoter, detractor, or neutral. |
|           VoC - Process Survey Response            |  Survey Response   |                      Trigger a workflow based on the survey response.                       |
|            VoC - Unsubscribe respondent            |  Survey Response   |    Unsubscribe the respondent from a channel (for example, email) based on the response.    |
|                                                    |                    |                                                                                             |

You can also create a workflow that sends a survey to a customer, asking for the feedback as soon as a case is closed. More information about creating a new workflow in [!INCLUDE[pn-dynamics-crm](../includes/pn-dynamics-crm.md)]: [Create custom business logic through processes](https://docs.microsoft.com/dynamics365/customer-engagement/customize/guide-staff-through-common-tasks-processes) 

### See also
[Design a basic survey](design-basic-survey.md)   
[Design an advanced survey](design-advanced-survey.md)   
[Distribute a survey](distribute-survey.md)   
[Analyze survey data](analyze-survey-data.md)
