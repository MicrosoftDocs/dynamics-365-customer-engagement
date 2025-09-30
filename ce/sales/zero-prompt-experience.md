---
title: Configure zero prompt experience for Copilot in Dynamics 365 Sales (preview)
description: Learn how to configure the zero prompt experience for Copilot in Dynamics 365 Sales.
ms.date: 09/30/2025
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure zero prompt experience for Copilot in Dynamics 365 Sales (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The zero prompt experience helps you enhance user engagement and streamline interactions at the start of a Copilot chat session. 

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

This experience helps sellers quickly access relevant information and actions related to their work and reduces the need for additional prompts and iterations. The zero prompt experience can be context aware and hence, can be selectively shown for targeted pages.

> [!NOTE]
>- Customizing the zero prompt experience for Copilot in Dynamics 365 Sales involves a different process compared to customizing the experience for the [Power Platform bots](/power-apps/maker/model-driven-apps/copilot-chat-zpe-guide).
>- The customization is only supported for the `Conversation Start` topic in English language.

:::image type="content" source="media/copilot-zero-prompt-experience.png" alt-text="Screenshot of the zero prompt experience card in Copilot in Dynamics 365 Sales.":::

## Configure the zero prompt experience

Follow these steps to customize the zero prompt experience for Copilot in Dynamics 365 Sales:

1. In [Copilot Studio](https://copilotstudio.microsoft.com/), go to **Agents** and select the **Copilot in Dynamics 365 Sales** agent.
1. Go to **Topics** and open **Conversation Start Topic**.
1. Scroll to the bottom of the topic and locate the section where the Adaptive Card is defined.  
   :::image type="content" source="media/topic-adaptive-card.png" alt-text="Screenshot of the section where the Adaptive Card is defined.":::
1. Double-click on the Adaptive Card to open it for editing.

    - Add, update, or remove the `Container` nodes as needed.
    - Ensure that any `Action` nodes follow the same schema as the existing ones.
    - Ensure that all changes adhere to the existing schema for `selectAction` to avoid runtime errors.
1. Save the topic.
1. Select **Test** to verify the changes made to the card.  
    :::image type="content" source="media/test-adaptive-card.png" alt-text="Screenshot of Copilot displaying updated zero prompt experience card.":::
1. Select **Publish** to publish the changes.


## Sample Code for Conversation Start customization

The sample code includes customization to the `Conversation Start` topic for the zero prompt experience. This example adds a new prompt to the card **Redmond Accounts**.

The following changes are made to the existing code:

- A new variable named `Topic.AccountScenario` is added to hold the account scenario.
- A new variable named `Topic.AccountScenarioPayload` is added to hold the payload for the account scenario.
- The Adaptive Card is updated to include the new scenario and its payload.


```yaml
kind: AdaptiveDialog
beginDialog:
  kind: OnConversationStart
  id: main
  actions:
    - kind: SetTextVariable
      id: setTextVariable_uV3wX4
      variable: Topic.GetLatestNewsForAccounts
      value: Get latest news for accounts
    - kind: SetTextVariable
      id: setTextVariable_yZ9aB0
      variable: Topic.WhatsNewlyAassignedToMe
      value: What's newly assigned to me
    - kind: SetTextVariable
      id: setTextVariable_eF5gH6
      variable: Topic.PrepareForSalesAppointments
      value: Prepare for sales meetings
    - kind: SetTextVariable
      id: setTextVariable_yZ5aB6
      variable: Topic.Hi
      value: Hi
    - kind: SetTextVariable
      id: setTextVariable_cD7eF8
      variable: Topic.WelcomeMessage
      value: Welcome to Copilot. Select one of the suggestions below to get started.
    - kind: SetTextVariable
      id: setTextVariable_7buPHx
      variable: Topic.EmptyWelcomeMessage
      value: Welcome to Copilot.
    - kind: SetTextVariable
      id: setTextVariable_gH9iJ0
      variable: Topic.MenuForMoreSuggestions
      value: Use "View Prompts" for more suggestions.
    - kind: SetTextVariable
      id: setTextVariable_sT5uV6
      variable: Topic.GetInfo
      value: Get info
    - kind: SetTextVariable
      id: setTextVariable_wX7yZ8
      variable: Topic.AskQuestions
      value: Ask questions
    - kind: SetVariable
      id: setVariable_x6BNry
      variable: Topic.AccountScenario
      value: "={skillType: \"PromptTextSkill\", optionGroup: \"Redmond Accounts!\", prompt: \"What are the accounts located in Redmond?\" }"
    - kind: SetVariable
      id: setVariable_x33Nry
      variable: Topic.AccountScenarioPayload
      value: "={action: \"MS.PA.SalesAccountNews\", forActivityId: \"\", text: \"\", toolInput: \"{\"\"entity\"\": \"\"account\"\"}\", actionPayload: \"{\"\"entity\"\": \"\"account\"\"}\", type: \"followUpSuggestion\"}"
    - kind: SetTextVariable
      id: setTextVariable_F1eG2
      variable: Topic.StayAhead
      value: Stay ahead
    - kind: SetTextVariable
      id: setTextVariable_F1eGH
      variable: Topic.Prompt
      value: Prompt
    - kind: BeginDialog
      id: 39Xg9b
      input:
        binding:
          DefaultSettingValue: true
          FeatureSetting: EnableMeetingPrepSkill
      dialog: msdyn_salesCopilot.topic.AppCopilot.AppCopilotGetFeatureSetting
      output:
        binding:
          FeatureValue: Topic.EnableMeetingPrepSkillFeatureValue
    - kind: BeginDialog
      id: DEiW2c
      input:
        binding:
          DefaultSettingValue: true
          FeatureSetting: EnableSalesCustomerUpdatesSkill
      dialog: msdyn_salesCopilot.topic.AppCopilot.AppCopilotGetFeatureSetting
      output:
        binding:
          FeatureValue: Topic.EnableSalesCustomerUpdatesSkillFeatureValue
    - kind: BeginDialog
      id: dQiLcc
      input:
        binding:
          DefaultSettingValue: true
          FeatureSetting: EnableSalesNewlyAssignedSkill
      dialog: msdyn_salesCopilot.topic.AppCopilot.AppCopilotGetFeatureSetting
      output:
        binding:
          FeatureValue: Topic.EnableSalesNewlyAssignedSkillFeatureValue
    - kind: BeginDialog
      id: ie6OrC
      input:
        binding:
          DefaultSettingValue: true
          FeatureSetting: EnableSalesOpportunityPipelineSkill
      dialog: msdyn_salesCopilot.topic.AppCopilot.AppCopilotGetFeatureSetting
      output:
        binding:
          FeatureValue: Topic.EnableSalesOpportunityPipelineSkillFeatureValue
    - kind: BeginDialog
      id: T1SHez
      input:
        binding:
          DefaultSettingValue: true
          FeatureSetting: EnableLeadSummary
      dialog: msdyn_salesCopilot.topic.AppCopilot.AppCopilotGetFeatureSetting
      output:
        binding:
          FeatureValue: Topic.EnableLeadSummaryFeatureValue
    - kind: BeginDialog
      id: 8c6FvW
      displayName: Get FCS value for EnableBingNews
      input:
        binding:
          DefaultSettingValue: true
          FeatureSetting: EnableBingNews
      dialog: msdyn_salesCopilot.topic.AppCopilot.AppCopilotGetFeatureSetting
      output:
        binding:
          FeatureValue: Topic.EnableBingNewsFeatureValue
    - kind: BeginDialog
      id: CAeMs4
      displayName: Get feature context value for IsBingSearchEnabled
      input:
        binding:
          DefaultSettingValue: true
          FeatureSetting: IsBingSearchEnabled
      dialog: msdyn_salesCopilot.topic.AppCopilot.AppCopilotGetFeatureSetting
      output:
        binding:
          FeatureValue: Topic.IsBingSearchEnabled_FeatureContextValue
    - kind: SetVariable
      id: setVariable_34cpTI
      displayName: Set variable to check whether Account News can be shown
      variable: Topic.CanShowAccountNews
      value: =(Topic.EnableBingNewsFeatureValue = true) && (Topic.IsBingSearchEnabled_FeatureContextValue = true)
    - kind: ConditionGroup
      id: conditionGroup_PpBfIh
      conditions:
        - id: conditionItem_tpwPNQ
          condition: =Global.PA__Copilot_Model_PageContext.pageContext.pageType = "entityrecord" || Global.PA__Copilot_Model_PageContext.pageContext.pageType = "entitylist"
          actions:
            - kind: SetTextVariable
              id: setTextVariable_qR5sT6
              variable: Topic.ShowMyPipeline
              value: Show my pipeline
            - kind: SetTextVariable
              id: setTextVariable_uV7wX8
              variable: Topic.SummarizeLead
              value: Summarize lead
            - kind: SetTextVariable
              id: setTextVariable_aB3cD4
              variable: Topic.WhatsNewWithMySalesRecords
              value: What's new with my sales records
            - kind: SetVariable
              id: setVariable_qR1sT2
              variable: Topic.GetInfoAction
              value: |-
                =Switch(Global.PA__Copilot_Model_PageContext.pageContext.entityTypeName,"opportunity", Topic.ShowMyPipeline, "lead", Topic.SummarizeLead,"contact", Topic.GetLatestNewsForAccounts,"account", Topic.GetLatestNewsForAccounts, Topic.GetLatestNewsForAccounts)
            - kind: SetVariable
              id: setVariable_TqVEVm
              variable: Topic.ShowGetInfoAction
              value: |-
                =Switch(Global.PA__Copilot_Model_PageContext.pageContext.entityTypeName,"opportunity", Topic.EnableSalesOpportunityPipelineSkillFeatureValue, "lead", Topic.EnableLeadSummaryFeatureValue,"contact", Topic.CanShowAccountNews,"account", Topic.CanShowAccountNews, Topic.CanShowAccountNews)
            - kind: SetVariable
              id: setVariable_63QuOW
              variable: Topic.GetInfoActionPayload
              value: |-
                =Switch(Global.PA__Copilot_Model_PageContext.pageContext.entityTypeName,
                "opportunity", {type: "followUpSuggestion", forActivityId: "", action: "MS.PA.SalesOpportunityPipeline", toolInput: "{""entity"": ""opportunity""}", actionPayload: "{""entity"": ""opportunity""}", text: ""},
                "lead", {type: "followUpSuggestion", forActivityId: "", action: "MS.PA.SalesSummarizeLead", toolInput: "{""entity"": ""lead""}", actionPayload: "{""entity"": ""lead""}", text: ""},
                "contact", {type: "followUpSuggestion", forActivityId: "", action: "MS.PA.SalesAccountNews", toolInput: "{""entity"": ""account""}", actionPayload: "{""entity"": ""account""}", text: ""},
                "account", {type: "followUpSuggestion", forActivityId: "", action: "MS.PA.SalesAccountNews", toolInput: "{""entity"": ""account""}", actionPayload: "{""entity"": ""account""}",  text: ""},
                {type: "followUpSuggestion", forActivityId: "", action: "MS.PA.SalesAccountNews", toolInput: "{""entity"": ""account""}", actionPayload: "{""entity"": ""account""}", text: ""})
            - kind: SetVariable
              id: setVariable_eOzXil
              variable: Topic.AskQuestionsAction
              value: |-
                =Switch(Global.PA__Copilot_Model_PageContext.pageContext.entityTypeName,"opportunity", Topic.WhatsNewlyAassignedToMe, "lead", Topic.WhatsNewlyAassignedToMe,"contact", Topic.WhatsNewWithMySalesRecords,"account", Topic.WhatsNewWithMySalesRecords, Topic.WhatsNewlyAassignedToMe)
            - kind: SetVariable
              id: setVariable_OB1pqa
              variable: Topic.ShowAskQuestionsAction
              value: =Switch(Global.PA__Copilot_Model_PageContext.pageContext.entityTypeName,"opportunity", Topic.EnableSalesNewlyAssignedSkillFeatureValue, "lead", Topic.EnableSalesNewlyAssignedSkillFeatureValue,"contact", Topic.EnableSalesCustomerUpdatesSkillFeatureValue,"account", Topic.EnableSalesCustomerUpdatesSkillFeatureValue, Topic.EnableSalesNewlyAssignedSkillFeatureValue)
            - kind: SetVariable
              id: setVariable_BNMhY1
              variable: Topic.AskQuestionsActionPayload
              value: |-
                =Switch(Global.PA__Copilot_Model_PageContext.pageContext.entityTypeName,
                "opportunity", {type: "followUpSuggestion", forActivityId: "", action: "MS.PA.SalesRecentLeadsAndOpportunities", toolInput: "{""entity"": """"}", actionPayload:  "{""entity"": """"}", text: ""},
                "lead", {type: "followUpSuggestion", forActivityId: "", action: "MS.PA.SalesRecentLeadsAndOpportunities", toolInput: "{""entity"": """"}", actionPayload: "{""entity"": """"}", text: ""},
                "contact", {type: "followUpSuggestion", forActivityId: "", action: "MS.PA.SalesCustomerUpdates", toolInput: "{""entity"": """"}", actionPayload: "{""entity"": """"}", text: ""},
                "account", {type: "followUpSuggestion", forActivityId: "", action: "MS.PA.SalesCustomerUpdates", toolInput: "{""entity"": """"}", actionPayload: "{""entity"": """"}", text: ""},
                {type: "followUpSuggestion", forActivityId: "", action: "MS.PA.SalesRecentLeadsAndOpportunities", toolInput: "{""entity"": """"}", actionPayload: "{""entity"": """"}", text: ""})
          elseActions:
            - kind: ConditionGroup
              id: conditionGroup_yaxGSC
              conditions:
                - id: conditionItem_EfMH5W
                  condition: =Global.PA__Copilot_Model_PageContext.pageContext.pageType = "control" && Global.PA_Copilot_Model_SessionContext.hostMode = "UciHomePage"
                  actions:
                    - kind: SendActivity
                      id: sendActivity_uA4u7D
                      activity:
                        kind: EventActivity
                        value: "={action: \"MS.PA.SalesImmersiveCardEvent\", pageContext: Global.PA__Copilot_Model_PageContext, text: System.Activity.Text, type: \"fromPva\"}"
                        name: MS.PA.SalesImmersiveCardEvent
              elseActions:
                - kind: SetVariable
                  id: setVariable_lUJzZr
                  variable: Topic.GetInfoAction
                  value: =Topic.GetLatestNewsForAccounts
                - kind: SetVariable
                  id: setVariable_qOEIWR
                  variable: Topic.ShowGetInfoAction
                  value: =Topic.CanShowAccountNews
                - kind: SetVariable
                  id: setVariable_qoyuGZ
                  variable: Topic.GetInfoActionPayload
                  value: "={action: \"MS.PA.SalesAccountNews\", forActivityId: \"\", text: \"\", toolInput: \"{\"\"entity\"\": \"\"account\"\"}\", actionPayload: \"{\"\"entity\"\": \"\"account\"\"}\", type: \"followUpSuggestion\"}"
                - kind: SetVariable
                  id: setVariable_0BFYq2
                  variable: Topic.AskQuestionsAction
                  value: =Topic.WhatsNewlyAassignedToMe
                - kind: SetVariable
                  id: setVariable_G2HZ96
                  variable: Topic.ShowAskQuestionsAction
                  value: =Topic.EnableSalesNewlyAssignedSkillFeatureValue
                - kind: SetVariable
                  id: setVariable_8sBhr7
                  variable: Topic.AskQuestionsActionPayload
                  value: "={action: \"MS.PA.SalesRecentLeadsAndOpportunities\", forActivityId: \"\", text: \"\", toolInput: \"{\"\"entity\"\": \"\"\"\"}\", actionPayload: \"{\"\"entity\"\": \"\"\"\"}\", type: \"followUpSuggestion\"}"
    - kind: SetVariable
      id: setVariable_iKtpyX
      variable: Topic.StayAheadAction
      value: =Topic.PrepareForSalesAppointments
    - kind: SetVariable
      id: setVariable_XmQcLA
      variable: Topic.ShowStayAheadAction
      value: =Topic.EnableMeetingPrepSkillFeatureValue
    - kind: SetVariable
      id: setVariable_APDJP6
      variable: Topic.WelcomeMessage
      value: =If((Topic.ShowGetInfoAction || Topic.ShowAskQuestionsAction || Topic.ShowStayAheadAction), Topic.WelcomeMessage, Topic.EmptyWelcomeMessage)
    - kind: SendActivity
      id: sendActivity_lWBv0M
      activity:
        value: "={adaptiveCardType: \"Sales\", doesNotContainAIGeneratedContext: true, cardType: \"ZerothCard\", markMAU: true}"
        attachments:
          - kind: AdaptiveCardTemplate
            cardContent: |-
              ={
                  type: "AdaptiveCard",
                  body: [
                      {
                        type: "ColumnSet",
                        id: "ms-sales-zerothcard-columnsetheader-1e08d8e5-09e2-4b8f-92e3-1c95b3c2d22a",
                        columns: [
                            {
                                type: "Column",
                                items: [
                                {
                                    type: "TextBlock",
                                    wrap: true,
                                    text: ""&Topic.Hi&" "&System.User.FirstName&","
                                },
                                {
                                    type: "TextBlock",
                                    wrap: true,
                                    text: ""&Topic.WelcomeMessage&"",
                                    id: "ms-sales-zerothcard-header-8ea70dd0-c904-4599-9b0e-fa2e7351ce90"
                                },
                                ]
                            }
                        ]
                      },
                      {
                          type: "Container",
                          id: "ms-sales-zerothcard-actionscontainer-95d7ee68-0000-4a9b-aa08-b6a4682f9376",
                          isVisible: "true",
                          selectAction: {
                              type: "Action.Submit",
                              data: {
                                  scenario: "AccountScenario",
                                  value: {
                                      displayName: ""&Topic.AccountScenario.optionGroup&"",
                                      actionPayload: Topic.AccountScenarioPayload,
                                      source: "ZeroPrompt"
                                  }
                                }
                          },
                          items: [
                              {
                                  type: "ColumnSet",
                                  columns: [
                                      {
                                          type: "Column",
                                          width: "auto",
                                          items: [
                                              {
                                                  type: "Image",
                                                  url: "data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iMjAiIGhlaWdodD0iMjAiIHZpZXdCb3g9IjAgMCAyMCAyMCIgZmlsbD0ibm9uZSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj4NCjxwYXRoIGQ9Ik0zLjUgNEMyLjY3MTU3IDQgMiA0LjY3MTU3IDIgNS41VjcuNUMyIDguMzI4NDMgMi42NzE1NyA5IDMuNSA5SDUuNUM2LjMyODQzIDkgNyA4LjMyODQzIDcgNy41VjUuNUM3IDQuNjcxNTcgNi4zMjg0MyA0IDUuNSA0SDMuNVpNMyA1LjVDMyA1LjIyMzg2IDMuMjIzODYgNSAzLjUgNUg1LjVDNS43NzYxNCA1IDYgNS4yMjM4NiA2IDUuNVY3LjVDNiA3Ljc3NjE0IDUuNzc2MTQgOCA1LjUgOEgzLjVDMy4yMjM4NiA4IDMgNy43NzYxNCAzIDcuNVY1LjVaTTkuNSA1QzkuMjIzODYgNSA5IDUuMjIzODYgOSA1LjVDOSA1Ljc3NjE0IDkuMjIzODYgNiA5LjUgNkgxNy41QzE3Ljc3NjEgNiAxOCA1Ljc3NjE0IDE4IDUuNUMxOCA1LjIyMzg2IDE3Ljc3NjEgNSAxNy41IDVIOS41Wk05LjUgN0M5LjIyMzg2IDcgOSA3LjIyMzg2IDkgNy41QzkgNy43NzYxNCA5LjIyMzg2IDggOS41IDhIMTUuNUMxNS43NzYxIDggMTYgNy43NzYxNCAxNiA3LjVDMTYgNy4yMjM4NiAxNS43NzYxIDcgMTUuNSA3SDkuNVpNMy41IDExQzIuNjcxNTcgMTEgMiAxMS42NzE2IDIgMTIuNVYxNC41QzIgMTUuMzI4NCAyLjY3MTU3IDE2IDMuNSAxNkg1LjVDNi4zMjg0MyAxNiA3IDE1LjMyODQgNyAxNC41VjEyLjVDNyAxMS42NzE2IDYuMzI4NDMgMTEgNS41IDExSDMuNVpNMyAxMi41QzMgMTIuMjIzOSAzLjIyMzg2IDEyIDMuNSAxMkg1LjVDNS43NzYxNCAxMiA2IDEyLjIyMzkgNiAxMi41VjE0LjVDNiAxNC43NzYxIDUuNzc2MTQgMTUgNS41IDE1SDMuNUMzLjIyMzg2IDE1IDMgMTQuNzc2MSAzIDE0LjVWMTIuNVpNOS41IDEyQzkuMjIzODYgMTIgOSAxMi4yMjM5IDkgMTIuNUM5IDEyLjc3NjEgOS4yMjM4NiAxMyA5LjUgMTNIMTcuNUMxNy43NzYxIDEzIDE4IDEyLjc3NjEgMTggMTIuNUMxOCAxMi4yMjM5IDE3Ljc3NjEgMTIgMTcuNSAxMkg5LjVaTTkuNSAxNEM5LjIyMzg2IDE0IDkgMTQuMjIzOSA5IDE0LjVDOSAxNC43NzYxIDkuMjIzODYgMTUgOS41IDE1SDE1LjVDMTUuNzc2MSAxNSAxNiAxNC43NzYxIDE2IDE0LjVDMTYgMTQuMjIzOSAxNS43NzYxIDE0IDE1LjUgMTRIOS41WiIgZmlsbD0iIzcwNzA3MCIvPg0KPC9zdmc+",
                                                  altText: ""&Topic.AccountScenario.optionGroup&""
                                              }
                                          ]
                                      },
                                      {
                                          type: "Column",
                                          width: "stretch",
                                          items: [
                                              {
                                                  type: "TextBlock",
                                                  text: ""&Topic.AccountScenario.optionGroup&"",
                                                  weight: "bolder"
                                              },
                                              {
                                                  type: "TextBlock",
                                                  text: ""&Topic.AccountScenario.prompt&""
                                              }
                                          ]
                                      }
                                  ]
                              }
                          ]
                      },
                      {
                          type: "Container",
                          id: "ms-sales-zerothcard-actionscontainer-95d7ee68-660e-4a9b-aa08-b6a4682f9376",
                          isVisible: ""&Topic.ShowGetInfoAction && !IsBlank(Topic.GetInfoAction)&"",
                          selectAction: {
                              type: "Action.Submit",
                              data: {
                                  scenario: "GetInfo",
                                  value: {
                                      displayName: ""&Topic.GetInfoAction&"",
                                      actionPayload: Topic.GetInfoActionPayload,
                                      source: "ZeroPrompt"
                                  }
                              }
                          },
                          items: [
                              {
                                  type: "ColumnSet",
                                  columns: [
                                      {
                                          type: "Column",
                                          width: "auto",
                                          items: [
                                              {
                                                  type: "Image",
                                                  url: "data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iMjAiIGhlaWdodD0iMjAiIHZpZXdCb3g9IjAgMCAyMCAyMCIgZmlsbD0ibm9uZSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj4NCjxwYXRoIGQ9Ik0yIDQuNUMyIDQuMjIzODYgMi4yMjM4NiA0IDIuNSA0SDEzLjVDMTMuNzc2MSA0IDE0IDQuMjIzODYgMTQgNC41QzE0IDQuNzc2MTQgMTMuNzc2MSA1IDEzLjUgNUgyLjVDMi4yMjM4NiA1IDIgNC43NzYxNCAyIDQuNVpNMiA5LjVDMiA5LjIyMzg2IDIuMjIzODYgOSAyLjUgOUgxNy41QzE3Ljc3NjEgOSAxOCA5LjIyMzg2IDE4IDkuNUMxOCA5Ljc3NjE0IDE3Ljc3NjEgMTAgMTcuNSAxMEgyLjVDMi4yMjM4NiAxMCAyIDkuNzc2MTQgMiA5LjVaTTIuNSAxNEMyLjIyMzg2IDE0IDIgMTQuMjIzOSAyIDE0LjVDMiAxNC43NzYxIDIuMjIzODYgMTUgMi41IDE1SDExLjVDMTEuNzc2MSAxNSAxMiAxNC43NzYxIDEyIDE0LjVDMTIgMTQuMjIzOSAxMS43NzYxIDE0IDExLjUgMTRIMi41WiIgZmlsbD0iIzYxNjE2MSIvPg0KPC9zdmc+DQo=",
                                                  altText: ""&Topic.GetInfo&""
                                              }
                                          ]
                                      },
                                      {
                                          type: "Column",
                                          width: "stretch",
                                          items: [
                                              {
                                                  type: "TextBlock",
                                                  text: ""&Topic.GetInfo&"",
                                                  weight: "bolder"
                                              },
                                              {
                                                  type: "TextBlock",
                                                  text: ""&Topic.GetInfoAction&""
                                              }
                                          ]
                                      }
                                  ]
                              }
                          ]
                      },
                      {
                          type: "Container",
                          id: "ms-sales-zerothcard-actionscontainer-a12232c5-ff86-453e-b754-2ddbeb613e0b",
                          isVisible: ""&Topic.ShowAskQuestionsAction && !IsBlank(Topic.AskQuestionsAction)&"",
                          selectAction: {
                              type: "Action.Submit",
                              data: {
                                  scenario: "AskQuestions",
                                  value: {
                                      displayName: ""&Topic.AskQuestionsAction&"",
                                      actionPayload: Topic.AskQuestionsActionPayload,
                                      source: "ZeroPrompt"
                                  }
                              }
                          },
                          items: [
                              {
                                  type: "ColumnSet",
                                  columns: [
                                      {
                                          type: "Column",
                                          width: "auto",
                                          items: [
                                              {
                                                  type: "Image",
                                                  url: "data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iMjAiIGhlaWdodD0iMjAiIHZpZXdCb3g9IjAgMCAyMCAyMCIgZmlsbD0ibm9uZSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj4NCjxwYXRoIGQ9Ik0xMCAyQzE0LjQxODMgMiAxOCA1LjU4MTcyIDE4IDEwQzE4IDE0LjQxODMgMTQuNDE4MyAxOCAxMCAxOEM4LjcyNjc5IDE4IDcuNDk1OTEgMTcuNzAxOCA2LjM4NjY5IDE3LjEzOTNMNi4yNjYgMTcuMDc1TDIuNjIxMDkgMTcuOTg1MUMyLjMxMTI3IDE4LjA2MjUgMi4wMjYyMiAxNy44MzY5IDIuMDAxMzEgMTcuNTQzOEwyLjAwMTE0IDE3LjQ2MjRMMi4wMTQ5MyAxNy4zNzg3TDIuOTI1IDEzLjczNUwyLjg2MTY5IDEzLjYxNTNDMi40MDY2IDEyLjcxODYgMi4xMjQzMyAxMS43NDIyIDIuMDMyNzUgMTAuNzI4M0wyLjAwNzM4IDEwLjM0NjNMMiAxMEMyIDUuNTgxNzIgNS41ODE3MiAyIDEwIDJaTTEwIDNDNi4xMzQwMSAzIDMgNi4xMzQwMSAzIDEwQzMgMTEuMjE3IDMuMzEwNTQgMTIuMzg3OCAzLjg5MzUyIDEzLjQyNDlDMy45NDA0NiAxMy41MDg0IDMuOTYyMSAxMy42MDMgMy45NTY5MiAxMy42OTczTDMuOTQyNzQgMTMuNzkxMkwzLjE4NyAxNi44MTJMNi4yMTEwNCAxNi4wNTgzQzYuMjcyOTQgMTYuMDQyOSA2LjMzNjYyIDE2LjAzOTYgNi4zOTg3MyAxNi4wNDc5TDYuNDkwMyAxNi4wNjkxTDYuNTc3MDEgMTYuMTA3NUM3LjYxMzYyIDE2LjY4OTggOC43ODM3IDE3IDEwIDE3QzEzLjg2NiAxNyAxNyAxMy44NjYgMTcgMTBDMTcgNi4xMzQwMSAxMy44NjYgMyAxMCAzWk0xMC41IDExQzEwLjc3NjEgMTEgMTEgMTEuMjIzOSAxMSAxMS41QzExIDExLjc0NTUgMTAuODIzMSAxMS45NDk2IDEwLjU4OTkgMTEuOTkxOUwxMC41IDEySDcuNUM3LjIyMzg2IDEyIDcgMTEuNzc2MSA3IDExLjVDNyAxMS4yNTQ1IDcuMTc2ODggMTEuMDUwNCA3LjQxMDEyIDExLjAwODFMNy41IDExSDEwLjVaTTEyLjUgOEMxMi43NzYxIDggMTMgOC4yMjM4NiAxMyA4LjVDMTMgOC43NDU0NiAxMi44MjMxIDguOTQ5NjEgMTIuNTg5OSA4Ljk5MTk0TDEyLjUgOUg3LjVDNy4yMjM4NiA5IDcgOC43NzYxNCA3IDguNUM3IDguMjU0NTQgNy4xNzY4OCA4LjA1MDM5IDcuNDEwMTIgOC4wMDgwNkw3LjUgOEgxMi41WiIgZmlsbD0iIzYxNjE2MSIvPg0KPC9zdmc+DQo=",
                                                  altText: ""&Topic.AskQuestions&""
                                              }
                                          ]
                                      },
                                      {
                                          type: "Column",
                                          width: "stretch",
                                          items: [
                                              {
                                                  type: "TextBlock",
                                                  text: ""&Topic.AskQuestions&"",
                                                  weight: "bolder"
                                              },
                                              {
                                                  type: "TextBlock",
                                                  text: ""&Topic.AskQuestionsAction&""
                                              }
                                          ]
                                      }
                                  ]
                              }
                          ]
                      },
                      {
                          type: "Container",
                          id: "ms-sales-zerothcard-actionscontainer-1d5666e6-d9ac-47d9-b70a-809238b2715d",
                          isVisible: ""&Topic.ShowStayAheadAction && !IsBlank(Topic.StayAheadAction)&"",
                          selectAction: {
                              type: "Action.Submit",
                              data: {
                                  scenario: "StayAhead",
                                  value: {
                                      displayName: ""&Topic.StayAheadAction&"",
                                      actionPayload: {
                                        type: "followUpSuggestion",
                                        forActivityId: "",
                                        action: "MS.PA.SalesMeetingPreparation",
                                        actionPayload: "{""entity"": ""appointment""}",
                                        toolInput: "{""entity"": ""appointment""}",
                                        text: ""
                                      },
                                      source: "ZeroPrompt"
                                  }
                              }
                          },
                          items: [
                              {
                                  type: "ColumnSet",
                                  columns: [
                                      {
                                          type: "Column",
                                          width: "auto",
                                          items: [
                                              {
                                                  type: "Image",
                                                  url: "data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iMjEiIGhlaWdodD0iMjEiIHZpZXdCb3g9IjAgMCAyMSAyMSIgZmlsbD0ibm9uZSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj4KPHBhdGggZD0iTTE2Ljk2NTQgOS43ODU5NEwxMy41NzYyIDEzLjE3NTdDMTMuMzgwOSAxMy4zNzA5IDEzLjM4MDkgMTMuNjg3NSAxMy41NzYyIDEzLjg4MjhDMTMuNzQ5NyAxNC4wNTYzIDE0LjAxOTIgMTQuMDc1NiAxNC4yMTQgMTMuOTQwNkwxNC4yODMzIDEzLjg4MjhMMTguNTI1OSA5LjY0MDE0QzE4LjY5OTUgOS40NjY1NyAxOC43MTg4IDkuMTk3MTUgMTguNTgzOCA5LjAwMjI4TDE4LjUyNTkgOC45MzMwM0wxNC4yODMzIDQuNjkwMzlDMTQuMDg4IDQuNDk1MTMgMTMuNzcxNCA0LjQ5NTEzIDEzLjU3NjIgNC42OTAzOUMxMy40MDI2IDQuODYzOTYgMTMuMzgzMyA1LjEzMzM4IDEzLjUxODMgNS4zMjgyNUwxMy41NzYyIDUuMzk3NUwxNi45NjU0IDguNzg1OTRMMTAuNjcyNCA4Ljc4NjU5QzYuNjExNDUgOC43ODY1OSAzLjMwNDM1IDEyLjAxNDEgMy4xNzYyMiAxNi4wNDM5TDMuMTcyMzYgMTYuMjg2NkMzLjE3MjM2IDE2LjU2MjcgMy4zOTYyMiAxNi43ODY2IDMuNjcyMzYgMTYuNzg2NkMzLjk0ODUxIDE2Ljc4NjYgNC4xNzIzNiAxNi41NjI3IDQuMTcyMzYgMTYuMjg2NkM0LjE3MjM2IDEyLjc3NDggNi45NTczNiA5LjkxMzQzIDEwLjQzOTIgOS43OTA2OUwxMC42NzI0IDkuNzg2NTlMMTYuOTY1NCA5Ljc4NTk0WiIgZmlsbD0iIzYxNjE2MSIvPgo8L3N2Zz4K",
                                                  altText: ""&Topic.StayAhead&""
                                              }
                                          ]
                                      },
                                      {
                                          type: "Column",
                                          width: "stretch",
                                          items: [
                                              {
                                                  type: "TextBlock",
                                                  text: ""&Topic.StayAhead&"",
                                                  weight: "bolder"
                                              },
                                              {
                                                  type: "TextBlock",
                                                  text: ""&Topic.StayAheadAction&""
                                              }
                                          ]
                                      }
                                  ]
                              }
                          ]
                      },
                      {
                        type: "ColumnSet",
                        id: "ms-sales-zerothcard-footer-d59e3421-629d-42b1-9d4a-bc3b280bf826",
                        columns: [
                            {
                                type: "Column",
                                width: "21px",
                                items: [
                                    {
                                        type: "Image",
                                        url: "data:image/svg+xml;base64,PHN2ZyB3aWR0aD0iMjEiIGhlaWdodD0iMjAiIHZpZXdCb3g9IjAgMCAyMSAyMCIgZmlsbD0ibm9uZSIgeG1sbnM9Imh0dHA6Ly93d3cudzMub3JnLzIwMDAvc3ZnIj4KPHBhdGggZD0iTTguNjQ2IDVDOC4wOTM3MSA1IDcuNjQ2IDUuNDQ3NzIgNy42NDYgNlY3QzcuNjQ2IDcuNTUyMjkgOC4wOTM3MSA4IDguNjQ2IDhIMTIuNjQ2QzEzLjE5ODMgOCAxMy42NDYgNy41NTIyOCAxMy42NDYgN1Y2QzEzLjY0NiA1LjQ0NzcyIDEzLjE5ODMgNSAxMi42NDYgNUg4LjY0NlpNOC42NDYgNkgxMi42NDZWN0g4LjY0NlY2WiIgZmlsbD0iIzI0MjQyNCIvPgo8cGF0aCBkPSJNMTMuNjQ2IDNINy42NDZDNi41NDE0MyAzIDUuNjQ2IDMuODk1NDMgNS42NDYgNVYxNUM1LjY0NiAxNi4xMDQ2IDYuNTQxNDMgMTcgNy42NDYgMTdIMTUuMTQ2QzE1LjQyMjEgMTcgMTUuNjQ2IDE2Ljc3NjEgMTUuNjQ2IDE2LjVDMTUuNjQ2IDE2LjIyMzkgMTUuNDIyMSAxNiAxNS4xNDYgMTZINy42NDZDNy4wOTM3MSAxNiA2LjY0NiAxNS41NTIzIDYuNjQ2IDE1VjE0Ljk5NjlIMTUuMTQ2QzE1LjQyMjEgMTQuOTk2OSAxNS42NDYgMTQuNzczMSAxNS42NDYgMTQuNDk2OVY1QzE1LjY0NiAzLjg5NTQzIDE0Ljc1MDYgMyAxMy42NDYgM1pNNi42NDYgMTMuOTk2OVY1QzYuNjQ2IDQuNDQ3NzEgNy4wOTM3MSA0IDcuNjQ2IDRIMTMuNjQ2QzE0LjE5ODMgNCAxNC42NDYgNC40NDc3MiAxNC42NDYgNVYxMy45OTY5SDYuNjQ2WiIgZmlsbD0iIzI0MjQyNCIvPgo8L3N2Zz4K",
                                        altText: ""&Topic.Prompt&""
                                    }
                                ]
                            },
                            {
                                type: "Column",
                                width: "auto",
                                items: [
                                    {
                                        type: "TextBlock",
                                        wrap: true,
                                        text: ""&Topic.MenuForMoreSuggestions&""
                                    }
                                ]
                            },
                        ]
                    }
                  ],
                  '$schema': "http://adaptivecards.io/schemas/adaptive-card.json",
                  version: "1.6"
              }
```
