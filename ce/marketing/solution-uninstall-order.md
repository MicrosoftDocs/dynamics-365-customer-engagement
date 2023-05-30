---
title: "Dynamics 365 Marketing solution uninstall order (Dynamics 365 Marketing)   |   Microsoft Docs"
description: "Lists the correct order in which to remove solutions when uninstalling Dynamics 365 Marketing."
ms.date: 05/19/2023
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Solution uninstall order for removing Dynamics 365 Marketing

> [!NOTE]
> If you want to release your Marketing entitlement to use on a different instance, you **do not** need to uninstall any of the Marketing solutions.

To delete Dynamics 365 from an instance, first open the Marketing setup wizard and run the uninstall command. The uninstall command releases your Dynamics 365 license and disconnects the Marketing services. If you'd also like to remove all of the related solutions from your instance, you must manually delete them in the order listed below. (Some of the items listed here may not be present on your instance, so just skip any missing items.) For complete instructions, see [Uninstall Marketing](uninstall-marketing.md).

Solutions marked as 'Used outside of Marketing' are being outside of Dynamics 365 Marketing (Dynamics 365 Sales, Customer Service Hub, Intelligent Order Management Features and others). It is **not safe to uninstall those shared solutions** as it can break related workloads - so please just skip those.

Moments-based marketing:

| Solution name | Used outside of Marketing |
| -------------- | ------------------------------ |
| DynamicsMKT_AnchorSolution | No |
| ~~DynamicsMKT_CxpAnalytics~~ | Yes |
| DynamicsMKT_Configuration | No |
| DynamicsMKT_OcIntegration | No |
| msdyn_InsightsAnalyticsMKTConfiguration | No |
| msdyn_DataInsightsAndAnalyticsForMKT | No |
| ~~msdyn_DataInsightsAndAnalytics~~ | Yes |
| DynamicsMKT_Sitemap_RTMDefault | No |
| DynamicsMKT_StandaloneSitemap | No |
| DynamicsMKT_Sitemap | No |
| MicrosoftDynamics_EventManagementAppUser | No |
| DynamicsMKT_LandingPageFormsAppUser | No |
| DynamicsMKT_TeamsEventsIntegrationAppUser | No |
| DynamicsMKT_MarketingAppUserRealtimeLink | No |
| DynamicsMKT_CxpGoalUser | No |
| ~~DynamicsMKT_CxpExperimentationUser~~ | Yes |
| DynamicsMKT_CxpAnalyticsConfiguration | No |
| DynamicsMKT_CxpAIConfiguration | No |
| DynamicsMKT_AttachCIApplicationUser | No |
| DynamicsMKT_CxpApplicationUser | No |
| DynamicsMKT_ChannelsAppUser | No |
| DynamicsMKT_ConsentAppUser | No |
| ~~DynamicsMKT_CxpPersonalizationUIAppUser~~ | Yes |
| DynamicsMKT_CIConnection | No |
| DynamicsMKT_BURoles | No |
| DynamicsMKT_Roles | No |
| DynamicsMKT_CxpGdpr | No |
| DynamicsMKT_ConsentFormsLink | No |
| DynamicsMKT_EventManagementRealtimeLinkData | No |
| DynamicsMKT_EventManagementRealtimeLink | No |
| DynamicsMKT_Forms | No |
| DynamicsMKT_FrequencyCapping | No |
| DynamicsMKT_BrandProfiles | No |
| DynamicsMKT_TeamsVEventsApp | No |
| DynamicsMKT_TeamsVEvents | No |
| DynamicsMKT_Fragments | No |
| DynamicsMKT_DomainValidation | No |
| DynamicsMKT_CustomerJourneyManagementRealtimeLink | No |
| DynamicsMKT_FormManagementRealtimeLink | No |
| DynamicsMKT_CxpConditionalContent | No |
| DynamicsMKT_QuotaSolution | No |
| ~~DynamicsMKT_MetadataStore~~ | Yes |
| DynamicsMKT_CxpGetStartedEasyModeBaseSolution | No |
| DynamicsMKT_CxpGetStartedExperience | No |
| DynamicsMKT_PushNotification | No |
| DynamicsMKT_SharedPushChannelsUser | No |
| DynamicsMKT_SharedPushChannels | No |
| DynamicsMKT_EmailChannel | No |
| DynamicsMKT_CxpEmailEditor | No |
| DynamicsMKT_CxpEmailEditorCanvas | No |
| ~~MicrosoftDynamics_EmailEditorModule~~ | Yes |
| ~~MicrosoftDynamics_EmailEditorCanvasModule~~ | Yes |
| ~~DynamicsMKT_EmailEditorCanvasShared~~ | Yes |
| DynamicsMKT_EmailEditorShared | No |
| DynamicsMKT_OrchestrationActions | No |
| DynamicsMKT_ImageGenerator | No |
| DynamicsMKT_Tracking | No |
| ~~DynamicsMKT_PersonalizationUI~~ | Yes |
| DynamicsMKT_CxpCmsIntegration | No |
| DynamicsMKT_SmsChannel | No |
| DynamicsMKT_CustomerVoiceIntegration | No |
| ~~DynamicsMKT_SharedSmsChannelsUser~~ | Yes |
| ~~DynamicsMKT_SharedSmsChannels~~ | Yes |
| DynamicsMKT_ChannelDefinitions | No |
| ~~DynamicsMKT_SharedChannelExtensions~~ | Yes |
| msdyn_D365ChannelDefinitions | No |
| msdyn_D365ChannelDefinitionsUser | No |
| msdyn_OmnichannelSharedSMS | No |
| msdyn_OmnichannelSharedCommunicationBase | No |
| msdyn_OmnichannelSharedBase | No |
| msdyn_OCModernAdminBase | No |
| DynamicsMKT_CxpGoal | No |
| ~~DynamicsMKT_CxpExperimentation~~ | Yes |
| DynamicsMKT_CxpAI | No |
| DynamicsMKT_OrchestrationAnalyticsRealtimeLink | No |
| DynamicsMKT_OrchestrationAnalytics | No |
| DynamicsMKT_OrchestrationTriggers | No |
| DynamicsMKT_CxpOrchestrationUI | No |
| DynamicsMKT_CxpOrchestrationUIControls | No |
| DynamicsMKT_ConsentAttachCI | No |
| DynamicsMKT_Consent | No |
| DynamicsMKT_AssetControlsSolution | No |
| DynamicsMKT_CxpFormControls | No |
| DynamicsMKT_OrchestrationEngineAttachCI | No |
| DynamicsMKT_OrchestrationEngineEvents | No |
| DynamicsMKT_OrchestrationEngine | No |
| DynamicsMKT_CxpSegmentationUI | No |
| ~~DynamicsMKT_FeatureConfiguration~~ | Yes |
| MicrosoftDynamics_HealthChecker | No |
| ~~DynamicsMKT_BaseSolution~~ | Yes |
| DynamicsMKT_Segmentation | No |
| ~~DynamicsMKT_AnalyticsUx~~ | Yes |

Segment-based marketing:

| Solution name | Used outside of Marketing |
| -------------- | ------------------------------ |
| MicrosoftDynamics_SegmentationDataLakeTIP | No |
| MicrosoftDynamics_SegmentationDataLake | No |
| LeadGenAppUser | No |
| MicrosoftDynamics_MarketingAppUser | No |
| MicrosoftDynamics_MarketingAppBURoles | No |
| MicrosoftDynamics_MarketingAppRoles | No |
| MicrosoftDynamics_SubscriptionList | No |
| MicrosoftDynamics_OrgCleanup | No |
| MicrosoftDynamics_PackageUpgrade | No |
| MicrosoftDynamics_PersonalizedPages | No |
| MicrosoftDynamics_MarketableContactSupport | No |
| MicrosoftDynamics_MarketingFormsProLink | No |
| MicrosoftDynamics_MktEmailEditor | No |
| MicrosoftDynamics_EvtMgmtPortalsLink | No |
| MicrosoftDynamics_MktContentSuggestions | No |
| MicrosoftDynamics_EmailEditorModule | No |
| MicrosoftDynamics_EmailEditorCanvasModule | No |
| MicrosoftDynamics_QuickSend | No |
| MicrosoftDynamics_ABTesting | No |
| MicrosoftDynamics_GwennolFeatureConfiguration | No |
| MicrosoftDynamics_GwennolSpamScore | No |
| MicrosoftDynamics_GwennolOESTPrediction | No |
| MicrosoftDynamics_GwennolOptimalEmailSendingTime | No |
| MicrosoftDynamics_MktIntegration | No |
| MicrosoftDynamics_SocialPosting | No |
| MicrosoftDynamics_LinkedInMatchedAudiences | No |
| MicrosoftDynamics_MktLeadGenLink | No |
| MicrosoftDynamics_MktConsentManagement | No |
| MicrosoftDynamics_FeatureConfiguration | No |
| MicrosoftDynamics_MktQuotaInfo | No |
| MicrosoftDynamics_MktPageTemplates | No |
| MicrosoftDynamics_MktEvtMgmtLink | No |
| MicrosoftDynamics_MktOrchestrationCompatModule | No |
| MicrosoftDynamics_MarketingOrchestrationModule | No |
| LinkedInLeadGenIntegration | No |
| MicrosoftDynamics_MktLeadManagement | No |
| MicrosoftDynamics_MktEmailTemplates | No |
| MicrosoftDynamics_Marketing | No |
| MicrosoftDynamics_EventManagement | No |
| DynamicsMKT_EmailEditorCanvasShared | No |
| DynamicsMKT_EmailEditorShared | No |
| ~~MicrosoftDynamics_ContentEditor~~ | Yes |
| MicrosoftDynamics_Orchestration | No |
| MicrosoftDynamics_ReusableBlocks | No |
| DynamicsMKT_SharedMarketingSettings | No |
| MicrosoftDynamics_DigitalAssets | No |
| ~~DynamicsMKT_SharedMarketingControls~~ | Yes |
| MicrosoftDynamics_Calendar | No |
| MicrosoftDynamics_DsfSdkAppUser | No |
| MicrosoftDynamics_ManagedIdentityTIP | No |
| MicrosoftDynamics_ManagedIdentity | No |
| MicrosoftDynamics_PreImport | No |

If you see any other "anchor" solutions that start with "MicrosoftDynamics_", you can delete those too. They are likely left over from an earlier version that you upgraded. You can remove these in any order after you've uninstalled the other solutions.

Marketing application dependencies are installed alongside the Marketing application. The following dependencies can only be uninstalled if they are not used by other solutions:

1. msdyn_DataInsightsAndAnalytics: Enables analytics capabilities for Dynamics 365 applications like Customer Service, Field Service, and Universal Resource Scheduling.
1. DynamicsMKT_Segmentation: Standard entity of segment representation and segment metadata.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
