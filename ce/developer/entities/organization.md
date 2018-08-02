---
title: "Organization Entity Reference (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Includes schema information and supported messages for the Organization entity."
ms.date: 12/05/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3948cc48-07c8-7f60-0608-71c37158ad7c
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Organization Entity Reference

Top level of the Microsoft Dynamics 365 business hierarchy. The organization can be a specific business, holding company, or corporation.


## Messages

|Message|Web API Operation|SDK Assembly|
|-|-|-|
|Retrieve|GET [*org URI*]/api/data/v9.0/organizations(*organizationid*)<br />See [Retrieve](../webapi/retrieve-entity-using-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Retrieve*>|
|RetrieveMultiple|GET [*org URI*]/api/data/v9.0/organizations<br />See [Query Data](../webapi/query-data-web-api.md)|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.RetrieveMultiple*>|
|Update|PATCH [*org URI*]/api/data/v9.0/organizations(*organizationid*)<br />See [Update](../webapi/update-delete-entities-using-web-api.md#basic-update)|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> or <br /><xref:Microsoft.Xrm.Sdk.IOrganizationService.Update*>|

## Entity Properties

|Property|Value|
|--------|-----|
|CollectionSchemaName|Organizations|
|DisplayCollectionName|Organizations|
|DisplayName|Organization|
|EntitySetName|organizations|
|IsBPFEntity|False|
|LogicalCollectionName|organizations|
|LogicalName|organization|
|OwnershipType|OrganizationOwned|
|PrimaryIdAttribute|organizationid|
|PrimaryNameAttribute|name|
|SchemaName|Organization|

<a name="writable-attributes"></a>

## Writable attributes

These attributes return true for either **IsValidForCreate** or **IsValidForUpdate** (usually both). Listed by **SchemaName**.

- [ACIWebEndpointUrl](#BKMK_ACIWebEndpointUrl)
- [AcknowledgementTemplateId](#BKMK_AcknowledgementTemplateId)
- [AllowAddressBookSyncs](#BKMK_AllowAddressBookSyncs)
- [AllowAutoResponseCreation](#BKMK_AllowAutoResponseCreation)
- [AllowAutoUnsubscribe](#BKMK_AllowAutoUnsubscribe)
- [AllowAutoUnsubscribeAcknowledgement](#BKMK_AllowAutoUnsubscribeAcknowledgement)
- [AllowClientMessageBarAd](#BKMK_AllowClientMessageBarAd)
- [AllowEntityOnlyAudit](#BKMK_AllowEntityOnlyAudit)
- [AllowMarketingEmailExecution](#BKMK_AllowMarketingEmailExecution)
- [AllowOfflineScheduledSyncs](#BKMK_AllowOfflineScheduledSyncs)
- [AllowOutlookScheduledSyncs](#BKMK_AllowOutlookScheduledSyncs)
- [AllowUnresolvedPartiesOnEmailSend](#BKMK_AllowUnresolvedPartiesOnEmailSend)
- [AllowUserFormModePreference](#BKMK_AllowUserFormModePreference)
- [AllowUsersSeeAppdownloadMessage](#BKMK_AllowUsersSeeAppdownloadMessage)
- [AllowWebExcelExport](#BKMK_AllowWebExcelExport)
- [AMDesignator](#BKMK_AMDesignator)
- [AppDesignerExperienceEnabled](#BKMK_AppDesignerExperienceEnabled)
- [AutoApplyDefaultonCaseCreate](#BKMK_AutoApplyDefaultonCaseCreate)
- [AutoApplyDefaultonCaseUpdate](#BKMK_AutoApplyDefaultonCaseUpdate)
- [AutoApplySLA](#BKMK_AutoApplySLA)
- [AzureSchedulerJobCollectionName](#BKMK_AzureSchedulerJobCollectionName)
- [BaseCurrencyId](#BKMK_BaseCurrencyId)
- [BingMapsApiKey](#BKMK_BingMapsApiKey)
- [BlockedAttachments](#BKMK_BlockedAttachments)
- [BoundDashboardDefaultCardExpanded](#BKMK_BoundDashboardDefaultCardExpanded)
- [BulkOperationPrefix](#BKMK_BulkOperationPrefix)
- [BusinessClosureCalendarId](#BKMK_BusinessClosureCalendarId)
- [CalendarType](#BKMK_CalendarType)
- [CampaignPrefix](#BKMK_CampaignPrefix)
- [CascadeStatusUpdate](#BKMK_CascadeStatusUpdate)
- [CasePrefix](#BKMK_CasePrefix)
- [CategoryPrefix](#BKMK_CategoryPrefix)
- [ContractPrefix](#BKMK_ContractPrefix)
- [CortanaProactiveExperienceEnabled](#BKMK_CortanaProactiveExperienceEnabled)
- [CreateProductsWithoutParentInActiveState](#BKMK_CreateProductsWithoutParentInActiveState)
- [CurrencyDecimalPrecision](#BKMK_CurrencyDecimalPrecision)
- [CurrencyDisplayOption](#BKMK_CurrencyDisplayOption)
- [CurrencyFormatCode](#BKMK_CurrencyFormatCode)
- [CurrencySymbol](#BKMK_CurrencySymbol)
- [CurrentBulkOperationNumber](#BKMK_CurrentBulkOperationNumber)
- [CurrentCampaignNumber](#BKMK_CurrentCampaignNumber)
- [CurrentCaseNumber](#BKMK_CurrentCaseNumber)
- [CurrentCategoryNumber](#BKMK_CurrentCategoryNumber)
- [CurrentContractNumber](#BKMK_CurrentContractNumber)
- [CurrentInvoiceNumber](#BKMK_CurrentInvoiceNumber)
- [CurrentKaNumber](#BKMK_CurrentKaNumber)
- [CurrentKbNumber](#BKMK_CurrentKbNumber)
- [CurrentOrderNumber](#BKMK_CurrentOrderNumber)
- [CurrentQuoteNumber](#BKMK_CurrentQuoteNumber)
- [DateFormatCode](#BKMK_DateFormatCode)
- [DateFormatString](#BKMK_DateFormatString)
- [DateSeparator](#BKMK_DateSeparator)
- [DecimalSymbol](#BKMK_DecimalSymbol)
- [DefaultCountryCode](#BKMK_DefaultCountryCode)
- [DefaultCrmCustomName](#BKMK_DefaultCrmCustomName)
- [DefaultEmailServerProfileId](#BKMK_DefaultEmailServerProfileId)
- [DefaultEmailSettings](#BKMK_DefaultEmailSettings)
- [DefaultMobileOfflineProfileId](#BKMK_DefaultMobileOfflineProfileId)
- [DefaultRecurrenceEndRangeType](#BKMK_DefaultRecurrenceEndRangeType)
- [DefaultThemeData](#BKMK_DefaultThemeData)
- [DelegatedAdminUserId](#BKMK_DelegatedAdminUserId)
- [DisableSocialCare](#BKMK_DisableSocialCare)
- [DiscountCalculationMethod](#BKMK_DiscountCalculationMethod)
- [DisplayNavigationTour](#BKMK_DisplayNavigationTour)
- [EmailConnectionChannel](#BKMK_EmailConnectionChannel)
- [EmailCorrelationEnabled](#BKMK_EmailCorrelationEnabled)
- [EmailSendPollingPeriod](#BKMK_EmailSendPollingPeriod)
- [EnableBingMapsIntegration](#BKMK_EnableBingMapsIntegration)
- [EnableImmersiveSkypeIntegration](#BKMK_EnableImmersiveSkypeIntegration)
- [EnableLPAuthoring](#BKMK_EnableLPAuthoring)
- [EnableMicrosoftFlowIntegration](#BKMK_EnableMicrosoftFlowIntegration)
- [EnablePricingOnCreate](#BKMK_EnablePricingOnCreate)
- [EnableSmartMatching](#BKMK_EnableSmartMatching)
- [EnforceReadOnlyPlugins](#BKMK_EnforceReadOnlyPlugins)
- [EntityImage](#BKMK_EntityImage)
- [ExpireChangeTrackingInDays](#BKMK_ExpireChangeTrackingInDays)
- [ExpireSubscriptionsInDays](#BKMK_ExpireSubscriptionsInDays)
- [ExternalBaseUrl](#BKMK_ExternalBaseUrl)
- [ExternalPartyCorrelationKeys](#BKMK_ExternalPartyCorrelationKeys)
- [ExternalPartyEntitySettings](#BKMK_ExternalPartyEntitySettings)
- [FeatureSet](#BKMK_FeatureSet)
- [FiscalCalendarStart](#BKMK_FiscalCalendarStart)
- [FiscalPeriodFormat](#BKMK_FiscalPeriodFormat)
- [FiscalPeriodFormatPeriod](#BKMK_FiscalPeriodFormatPeriod)
- [FiscalPeriodType](#BKMK_FiscalPeriodType)
- [FiscalYearDisplayCode](#BKMK_FiscalYearDisplayCode)
- [FiscalYearFormat](#BKMK_FiscalYearFormat)
- [FiscalYearFormatPrefix](#BKMK_FiscalYearFormatPrefix)
- [FiscalYearFormatSuffix](#BKMK_FiscalYearFormatSuffix)
- [FiscalYearFormatYear](#BKMK_FiscalYearFormatYear)
- [FiscalYearPeriodConnect](#BKMK_FiscalYearPeriodConnect)
- [FullNameConventionCode](#BKMK_FullNameConventionCode)
- [FutureExpansionWindow](#BKMK_FutureExpansionWindow)
- [GenerateAlertsForErrors](#BKMK_GenerateAlertsForErrors)
- [GenerateAlertsForInformation](#BKMK_GenerateAlertsForInformation)
- [GenerateAlertsForWarnings](#BKMK_GenerateAlertsForWarnings)
- [GetStartedPaneContentEnabled](#BKMK_GetStartedPaneContentEnabled)
- [GlobalAppendUrlParametersEnabled](#BKMK_GlobalAppendUrlParametersEnabled)
- [GlobalHelpUrl](#BKMK_GlobalHelpUrl)
- [GlobalHelpUrlEnabled](#BKMK_GlobalHelpUrlEnabled)
- [GoalRollupExpiryTime](#BKMK_GoalRollupExpiryTime)
- [GoalRollupFrequency](#BKMK_GoalRollupFrequency)
- [GrantAccessToNetworkService](#BKMK_GrantAccessToNetworkService)
- [HashDeltaSubjectCount](#BKMK_HashDeltaSubjectCount)
- [HashFilterKeywords](#BKMK_HashFilterKeywords)
- [HashMaxCount](#BKMK_HashMaxCount)
- [HashMinAddressCount](#BKMK_HashMinAddressCount)
- [HighContrastThemeData](#BKMK_HighContrastThemeData)
- [IgnoreInternalEmail](#BKMK_IgnoreInternalEmail)
- [InactivityTimeoutEnabled](#BKMK_InactivityTimeoutEnabled)
- [InactivityTimeoutInMins](#BKMK_InactivityTimeoutInMins)
- [InactivityTimeoutReminderInMins](#BKMK_InactivityTimeoutReminderInMins)
- [IncomingEmailExchangeEmailRetrievalBatchSize](#BKMK_IncomingEmailExchangeEmailRetrievalBatchSize)
- [InitialVersion](#BKMK_InitialVersion)
- [IntegrationUserId](#BKMK_IntegrationUserId)
- [InvoicePrefix](#BKMK_InvoicePrefix)
- [IsActionCardEnabled](#BKMK_IsActionCardEnabled)
- [IsActionSupportFeatureEnabled](#BKMK_IsActionSupportFeatureEnabled)
- [IsActivityAnalysisEnabled](#BKMK_IsActivityAnalysisEnabled)
- [IsAppMode](#BKMK_IsAppMode)
- [IsAppointmentAttachmentSyncEnabled](#BKMK_IsAppointmentAttachmentSyncEnabled)
- [IsAssignedTasksSyncEnabled](#BKMK_IsAssignedTasksSyncEnabled)
- [IsAuditEnabled](#BKMK_IsAuditEnabled)
- [IsAutoDataCaptureEnabled](#BKMK_IsAutoDataCaptureEnabled)
- [IsAutoSaveEnabled](#BKMK_IsAutoSaveEnabled)
- [IsBPFEntityCustomizationFeatureEnabled](#BKMK_IsBPFEntityCustomizationFeatureEnabled)
- [IsConflictDetectionEnabledForMobileClient](#BKMK_IsConflictDetectionEnabledForMobileClient)
- [IsContactMailingAddressSyncEnabled](#BKMK_IsContactMailingAddressSyncEnabled)
- [IsDefaultCountryCodeCheckEnabled](#BKMK_IsDefaultCountryCodeCheckEnabled)
- [IsDelegateAccessEnabled](#BKMK_IsDelegateAccessEnabled)
- [IsDelveActionHubIntegrationEnabled](#BKMK_IsDelveActionHubIntegrationEnabled)
- [IsDuplicateDetectionEnabled](#BKMK_IsDuplicateDetectionEnabled)
- [IsDuplicateDetectionEnabledForImport](#BKMK_IsDuplicateDetectionEnabledForImport)
- [IsDuplicateDetectionEnabledForOfflineSync](#BKMK_IsDuplicateDetectionEnabledForOfflineSync)
- [IsDuplicateDetectionEnabledForOnlineCreateUpdate](#BKMK_IsDuplicateDetectionEnabledForOnlineCreateUpdate)
- [IsEmailMonitoringAllowed](#BKMK_IsEmailMonitoringAllowed)
- [IsEmailServerProfileContentFilteringEnabled](#BKMK_IsEmailServerProfileContentFilteringEnabled)
- [IsEnabledForAllRoles](#BKMK_IsEnabledForAllRoles)
- [IsExternalSearchIndexEnabled](#BKMK_IsExternalSearchIndexEnabled)
- [IsFiscalPeriodMonthBased](#BKMK_IsFiscalPeriodMonthBased)
- [IsFolderAutoCreatedonSP](#BKMK_IsFolderAutoCreatedonSP)
- [IsFolderBasedTrackingEnabled](#BKMK_IsFolderBasedTrackingEnabled)
- [IsFullTextSearchEnabled](#BKMK_IsFullTextSearchEnabled)
- [IsHierarchicalSecurityModelEnabled](#BKMK_IsHierarchicalSecurityModelEnabled)
- [IsMailboxForcedUnlockingEnabled](#BKMK_IsMailboxForcedUnlockingEnabled)
- [IsMailboxInactiveBackoffEnabled](#BKMK_IsMailboxInactiveBackoffEnabled)
- [IsMobileClientOnDemandSyncEnabled](#BKMK_IsMobileClientOnDemandSyncEnabled)
- [IsMobileOfflineEnabled](#BKMK_IsMobileOfflineEnabled)
- [IsOfficeGraphEnabled](#BKMK_IsOfficeGraphEnabled)
- [IsOneDriveEnabled](#BKMK_IsOneDriveEnabled)
- [IsPresenceEnabled](#BKMK_IsPresenceEnabled)
- [IsPreviewEnabledForActionCard](#BKMK_IsPreviewEnabledForActionCard)
- [IsPreviewForAutoCaptureEnabled](#BKMK_IsPreviewForAutoCaptureEnabled)
- [IsPreviewForEmailMonitoringAllowed](#BKMK_IsPreviewForEmailMonitoringAllowed)
- [IsRelationshipInsightsEnabled](#BKMK_IsRelationshipInsightsEnabled)
- [IsResourceBookingExchangeSyncEnabled](#BKMK_IsResourceBookingExchangeSyncEnabled)
- [IsSOPIntegrationEnabled](#BKMK_IsSOPIntegrationEnabled)
- [IsTextWrapEnabled](#BKMK_IsTextWrapEnabled)
- [IsUserAccessAuditEnabled](#BKMK_IsUserAccessAuditEnabled)
- [ISVIntegrationCode](#BKMK_ISVIntegrationCode)
- [KaPrefix](#BKMK_KaPrefix)
- [KbPrefix](#BKMK_KbPrefix)
- [KMSettings](#BKMK_KMSettings)
- [LanguageCode](#BKMK_LanguageCode)
- [LocaleId](#BKMK_LocaleId)
- [LongDateFormatCode](#BKMK_LongDateFormatCode)
- [MailboxIntermittentIssueMinRange](#BKMK_MailboxIntermittentIssueMinRange)
- [MailboxPermanentIssueMinRange](#BKMK_MailboxPermanentIssueMinRange)
- [MaxActionStepsInBPF](#BKMK_MaxActionStepsInBPF)
- [MaxAppointmentDurationDays](#BKMK_MaxAppointmentDurationDays)
- [MaxConditionsForMobileOfflineFilters](#BKMK_MaxConditionsForMobileOfflineFilters)
- [MaxDepthForHierarchicalSecurityModel](#BKMK_MaxDepthForHierarchicalSecurityModel)
- [MaxFolderBasedTrackingMappings](#BKMK_MaxFolderBasedTrackingMappings)
- [MaximumActiveBusinessProcessFlowsAllowedPerEntity](#BKMK_MaximumActiveBusinessProcessFlowsAllowedPerEntity)
- [MaximumDynamicPropertiesAllowed](#BKMK_MaximumDynamicPropertiesAllowed)
- [MaximumEntitiesWithActiveSLA](#BKMK_MaximumEntitiesWithActiveSLA)
- [MaximumSLAKPIPerEntityWithActiveSLA](#BKMK_MaximumSLAKPIPerEntityWithActiveSLA)
- [MaximumTrackingNumber](#BKMK_MaximumTrackingNumber)
- [MaxProductsInBundle](#BKMK_MaxProductsInBundle)
- [MaxRecordsForExportToExcel](#BKMK_MaxRecordsForExportToExcel)
- [MaxRecordsForLookupFilters](#BKMK_MaxRecordsForLookupFilters)
- [MaxUploadFileSize](#BKMK_MaxUploadFileSize)
- [MicrosoftFlowEnvironment](#BKMK_MicrosoftFlowEnvironment)
- [MinAddressBookSyncInterval](#BKMK_MinAddressBookSyncInterval)
- [MinOfflineSyncInterval](#BKMK_MinOfflineSyncInterval)
- [MinOutlookSyncInterval](#BKMK_MinOutlookSyncInterval)
- [MobileOfflineSyncInterval](#BKMK_MobileOfflineSyncInterval)
- [Name](#BKMK_Name)
- [NegativeCurrencyFormatCode](#BKMK_NegativeCurrencyFormatCode)
- [NegativeFormatCode](#BKMK_NegativeFormatCode)
- [NextTrackingNumber](#BKMK_NextTrackingNumber)
- [NotifyMailboxOwnerOfEmailServerLevelAlerts](#BKMK_NotifyMailboxOwnerOfEmailServerLevelAlerts)
- [NumberFormat](#BKMK_NumberFormat)
- [NumberGroupFormat](#BKMK_NumberGroupFormat)
- [NumberSeparator](#BKMK_NumberSeparator)
- [OfficeAppsAutoDeploymentEnabled](#BKMK_OfficeAppsAutoDeploymentEnabled)
- [OfficeGraphDelveUrl](#BKMK_OfficeGraphDelveUrl)
- [OOBPriceCalculationEnabled](#BKMK_OOBPriceCalculationEnabled)
- [OrderPrefix](#BKMK_OrderPrefix)
- [OrgDbOrgSettings](#BKMK_OrgDbOrgSettings)
- [OrgInsightsEnabled](#BKMK_OrgInsightsEnabled)
- [PastExpansionWindow](#BKMK_PastExpansionWindow)
- [Picture](#BKMK_Picture)
- [PinpointLanguageCode](#BKMK_PinpointLanguageCode)
- [PluginTraceLogSetting](#BKMK_PluginTraceLogSetting)
- [PMDesignator](#BKMK_PMDesignator)
- [PostMessageWhitelistDomains](#BKMK_PostMessageWhitelistDomains)
- [PowerBiFeatureEnabled](#BKMK_PowerBiFeatureEnabled)
- [PricingDecimalPrecision](#BKMK_PricingDecimalPrecision)
- [PrivacyStatementUrl](#BKMK_PrivacyStatementUrl)
- [PrivilegeUserGroupId](#BKMK_PrivilegeUserGroupId)
- [PrivReportingGroupId](#BKMK_PrivReportingGroupId)
- [PrivReportingGroupName](#BKMK_PrivReportingGroupName)
- [ProductRecommendationsEnabled](#BKMK_ProductRecommendationsEnabled)
- [QuickFindRecordLimitEnabled](#BKMK_QuickFindRecordLimitEnabled)
- [QuotePrefix](#BKMK_QuotePrefix)
- [RecurrenceDefaultNumberOfOccurrences](#BKMK_RecurrenceDefaultNumberOfOccurrences)
- [RecurrenceExpansionJobBatchInterval](#BKMK_RecurrenceExpansionJobBatchInterval)
- [RecurrenceExpansionJobBatchSize](#BKMK_RecurrenceExpansionJobBatchSize)
- [RecurrenceExpansionSynchCreateMax](#BKMK_RecurrenceExpansionSynchCreateMax)
- [ReferenceSiteMapXml](#BKMK_ReferenceSiteMapXml)
- [RenderSecureIFrameForEmail](#BKMK_RenderSecureIFrameForEmail)
- [ReportingGroupId](#BKMK_ReportingGroupId)
- [ReportingGroupName](#BKMK_ReportingGroupName)
- [ReportScriptErrors](#BKMK_ReportScriptErrors)
- [RequireApprovalForQueueEmail](#BKMK_RequireApprovalForQueueEmail)
- [RequireApprovalForUserEmail](#BKMK_RequireApprovalForUserEmail)
- [ResolveSimilarUnresolvedEmailAddress](#BKMK_ResolveSimilarUnresolvedEmailAddress)
- [RestrictStatusUpdate](#BKMK_RestrictStatusUpdate)
- [RiErrorStatus](#BKMK_RiErrorStatus)
- [SampleDataImportId](#BKMK_SampleDataImportId)
- [SchemaNamePrefix](#BKMK_SchemaNamePrefix)
- [ServeStaticResourcesFromAzureCDN](#BKMK_ServeStaticResourcesFromAzureCDN)
- [SessionTimeoutEnabled](#BKMK_SessionTimeoutEnabled)
- [SessionTimeoutInMins](#BKMK_SessionTimeoutInMins)
- [SessionTimeoutReminderInMins](#BKMK_SessionTimeoutReminderInMins)
- [SharePointDeploymentType](#BKMK_SharePointDeploymentType)
- [ShareToPreviousOwnerOnAssign](#BKMK_ShareToPreviousOwnerOnAssign)
- [ShowKBArticleDeprecationNotification](#BKMK_ShowKBArticleDeprecationNotification)
- [ShowWeekNumber](#BKMK_ShowWeekNumber)
- [SignupOutlookDownloadFWLink](#BKMK_SignupOutlookDownloadFWLink)
- [SiteMapXml](#BKMK_SiteMapXml)
- [SlaPauseStates](#BKMK_SlaPauseStates)
- [SocialInsightsEnabled](#BKMK_SocialInsightsEnabled)
- [SocialInsightsInstance](#BKMK_SocialInsightsInstance)
- [SocialInsightsTermsAccepted](#BKMK_SocialInsightsTermsAccepted)
- [SortId](#BKMK_SortId)
- [SqlAccessGroupId](#BKMK_SqlAccessGroupId)
- [SqlAccessGroupName](#BKMK_SqlAccessGroupName)
- [SQMEnabled](#BKMK_SQMEnabled)
- [SupportUserId](#BKMK_SupportUserId)
- [SuppressSLA](#BKMK_SuppressSLA)
- [SyncOptInSelection](#BKMK_SyncOptInSelection)
- [SyncOptInSelectionStatus](#BKMK_SyncOptInSelectionStatus)
- [SystemUserId](#BKMK_SystemUserId)
- [TagMaxAggressiveCycles](#BKMK_TagMaxAggressiveCycles)
- [TagPollingPeriod](#BKMK_TagPollingPeriod)
- [TaskBasedFlowEnabled](#BKMK_TaskBasedFlowEnabled)
- [TextAnalyticsEnabled](#BKMK_TextAnalyticsEnabled)
- [TimeFormatCode](#BKMK_TimeFormatCode)
- [TimeFormatString](#BKMK_TimeFormatString)
- [TimeSeparator](#BKMK_TimeSeparator)
- [TimeZoneRuleVersionNumber](#BKMK_TimeZoneRuleVersionNumber)
- [TokenExpiry](#BKMK_TokenExpiry)
- [TokenKey](#BKMK_TokenKey)
- [TrackingPrefix](#BKMK_TrackingPrefix)
- [TrackingTokenIdBase](#BKMK_TrackingTokenIdBase)
- [TrackingTokenIdDigits](#BKMK_TrackingTokenIdDigits)
- [UniqueSpecifierLength](#BKMK_UniqueSpecifierLength)
- [UnresolveEmailAddressIfMultipleMatch](#BKMK_UnresolveEmailAddressIfMultipleMatch)
- [UseInbuiltRuleForDefaultPricelistSelection](#BKMK_UseInbuiltRuleForDefaultPricelistSelection)
- [UseLegacyRendering](#BKMK_UseLegacyRendering)
- [UsePositionHierarchy](#BKMK_UsePositionHierarchy)
- [UserAccessAuditingInterval](#BKMK_UserAccessAuditingInterval)
- [UseReadForm](#BKMK_UseReadForm)
- [UserGroupId](#BKMK_UserGroupId)
- [UseSkypeProtocol](#BKMK_UseSkypeProtocol)
- [UTCConversionTimeZoneCode](#BKMK_UTCConversionTimeZoneCode)
- [WebResourceHash](#BKMK_WebResourceHash)
- [WeekStartDayCode](#BKMK_WeekStartDayCode)
- [WidgetProperties](#BKMK_WidgetProperties)
- [YammerGroupId](#BKMK_YammerGroupId)
- [YammerNetworkPermalink](#BKMK_YammerNetworkPermalink)
- [YammerOAuthAccessTokenExpired](#BKMK_YammerOAuthAccessTokenExpired)
- [YammerPostMethod](#BKMK_YammerPostMethod)
- [YearStartWeekCode](#BKMK_YearStartWeekCode)


### <a name="BKMK_ACIWebEndpointUrl"></a> ACIWebEndpointUrl

|Property|Value|
|--------|-----|
|Description|ACI Web Endpoint URL.|
|DisplayName|ACI Tenant URL.|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|aciwebendpointurl|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_AcknowledgementTemplateId"></a> AcknowledgementTemplateId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the template to be used for acknowledgement when a user unsubscribes.|
|DisplayName|Acknowledgement Template|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|acknowledgementtemplateid|
|RequiredLevel|None|
|Targets|template|
|Type|Lookup|


### <a name="BKMK_AllowAddressBookSyncs"></a> AllowAddressBookSyncs

|Property|Value|
|--------|-----|
|Description|Indicates whether background address book synchronization in Microsoft Office Outlook is allowed.|
|DisplayName|Allow Address Book Synchronization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|allowaddressbooksyncs|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### AllowAddressBookSyncs Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_AllowAutoResponseCreation"></a> AllowAutoResponseCreation

|Property|Value|
|--------|-----|
|Description|Indicates whether automatic response creation is allowed.|
|DisplayName|Allow Automatic Response Creation|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|allowautoresponsecreation|
|RequiredLevel|None|
|Type|Boolean|

#### AllowAutoResponseCreation Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_AllowAutoUnsubscribe"></a> AllowAutoUnsubscribe

|Property|Value|
|--------|-----|
|Description|Indicates whether automatic unsubscribe is allowed.|
|DisplayName|Allow Automatic Unsubscribe|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|allowautounsubscribe|
|RequiredLevel|None|
|Type|Boolean|

#### AllowAutoUnsubscribe Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_AllowAutoUnsubscribeAcknowledgement"></a> AllowAutoUnsubscribeAcknowledgement

|Property|Value|
|--------|-----|
|Description|Indicates whether automatic unsubscribe acknowledgement email is allowed to send.|
|DisplayName|Allow Automatic Unsubscribe Acknowledgement|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|allowautounsubscribeacknowledgement|
|RequiredLevel|None|
|Type|Boolean|

#### AllowAutoUnsubscribeAcknowledgement Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_AllowClientMessageBarAd"></a> AllowClientMessageBarAd

|Property|Value|
|--------|-----|
|Description|Indicates whether Outlook Client message bar advertisement is allowed.|
|DisplayName|Allow Outlook Client Message Bar Advertisement|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|allowclientmessagebarad|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### AllowClientMessageBarAd Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_AllowEntityOnlyAudit"></a> AllowEntityOnlyAudit

|Property|Value|
|--------|-----|
|Description|Indicates whether auditing of changes to entity is allowed when no attributes have changed.|
|DisplayName|Allow Entity Level Auditing|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|allowentityonlyaudit|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### AllowEntityOnlyAudit Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_AllowMarketingEmailExecution"></a> AllowMarketingEmailExecution

|Property|Value|
|--------|-----|
|Description|Indicates whether marketing emails execution is allowed.|
|DisplayName|Allow Marketing Email Execution|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|allowmarketingemailexecution|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### AllowMarketingEmailExecution Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_AllowOfflineScheduledSyncs"></a> AllowOfflineScheduledSyncs

|Property|Value|
|--------|-----|
|Description|Indicates whether background offline synchronization in Microsoft Office Outlook is allowed.|
|DisplayName|Allow Offline Scheduled Synchronization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|allowofflinescheduledsyncs|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### AllowOfflineScheduledSyncs Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_AllowOutlookScheduledSyncs"></a> AllowOutlookScheduledSyncs

|Property|Value|
|--------|-----|
|Description|Indicates whether scheduled synchronizations to Outlook are allowed.|
|DisplayName|Allow Scheduled Synchronization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|allowoutlookscheduledsyncs|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### AllowOutlookScheduledSyncs Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_AllowUnresolvedPartiesOnEmailSend"></a> AllowUnresolvedPartiesOnEmailSend

|Property|Value|
|--------|-----|
|Description|Indicates whether users are allowed to send email to unresolved parties (parties must still have an email address).|
|DisplayName|Allow Unresolved Address Email Send|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|allowunresolvedpartiesonemailsend|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### AllowUnresolvedPartiesOnEmailSend Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_AllowUserFormModePreference"></a> AllowUserFormModePreference

|Property|Value|
|--------|-----|
|Description|Indicates whether individuals can select their form mode preference in their personal options.|
|DisplayName|Allow User Form Mode Preference|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|allowuserformmodepreference|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### AllowUserFormModePreference Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_AllowUsersSeeAppdownloadMessage"></a> AllowUsersSeeAppdownloadMessage

|Property|Value|
|--------|-----|
|Description|Indicates whether the showing tablet application notification bars in a browser is allowed.|
|DisplayName|Allow the showing tablet application notification bars in a browser.|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|allowusersseeappdownloadmessage|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### AllowUsersSeeAppdownloadMessage Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_AllowWebExcelExport"></a> AllowWebExcelExport

|Property|Value|
|--------|-----|
|Description|Indicates whether Web-based export of grids to Microsoft Office Excel is allowed.|
|DisplayName|Allow Export to Excel|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|allowwebexcelexport|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### AllowWebExcelExport Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_AMDesignator"></a> AMDesignator

|Property|Value|
|--------|-----|
|Description|AM designator to use throughout Microsoft Dynamics CRM.|
|DisplayName|AM Designator|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|amdesignator|
|MaxLength|25|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_AppDesignerExperienceEnabled"></a> AppDesignerExperienceEnabled

|Property|Value|
|--------|-----|
|Description|Indicates whether the appDesignerExperience is enabled for the organization.|
|DisplayName|Enable App Designer Experience for this Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|appdesignerexperienceenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### AppDesignerExperienceEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_AutoApplyDefaultonCaseCreate"></a> AutoApplyDefaultonCaseCreate

|Property|Value|
|--------|-----|
|Description|Select whether to auto apply the default customer entitlement on case creation.|
|DisplayName|Auto Apply Default Entitlement on Case Create|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|autoapplydefaultoncasecreate|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### AutoApplyDefaultonCaseCreate Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_AutoApplyDefaultonCaseUpdate"></a> AutoApplyDefaultonCaseUpdate

|Property|Value|
|--------|-----|
|Description|Select whether to auto apply the default customer entitlement on case update.|
|DisplayName|Auto Apply Default Entitlement on Case Update|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|autoapplydefaultoncaseupdate|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### AutoApplyDefaultonCaseUpdate Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_AutoApplySLA"></a> AutoApplySLA

|Property|Value|
|--------|-----|
|Description|Indicates whether to Auto-apply SLA on case record update after SLA was manually applied.|
|DisplayName|Is Auto-apply SLA After Manually Over-riding|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|autoapplysla|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### AutoApplySLA Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_AzureSchedulerJobCollectionName"></a> AzureSchedulerJobCollectionName

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|For internal use only.|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|azureschedulerjobcollectionname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BaseCurrencyId"></a> BaseCurrencyId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the base currency of the organization.|
|DisplayName|Currency|
|IsValidForForm|True|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|basecurrencyid|
|RequiredLevel|None|
|Targets|transactioncurrency|
|Type|Lookup|


### <a name="BKMK_BingMapsApiKey"></a> BingMapsApiKey

|Property|Value|
|--------|-----|
|Description|Api Key to be used in requests to Bing Maps services.|
|DisplayName|Bing Maps API Key|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|bingmapsapikey|
|MaxLength|1024|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BlockedAttachments"></a> BlockedAttachments

|Property|Value|
|--------|-----|
|Description|Prevent upload or download of certain attachment types that are considered dangerous.|
|DisplayName|Block Attachments|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|blockedattachments|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BoundDashboardDefaultCardExpanded"></a> BoundDashboardDefaultCardExpanded

|Property|Value|
|--------|-----|
|Description|Display cards in expanded state for interactive dashboard|
|DisplayName|Display cards in expanded state for Interactive Dashboard|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|bounddashboarddefaultcardexpanded|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### BoundDashboardDefaultCardExpanded Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_BulkOperationPrefix"></a> BulkOperationPrefix

|Property|Value|
|--------|-----|
|Description|Prefix used for bulk operation numbering.|
|DisplayName|Bulk Operation Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|bulkoperationprefix|
|MaxLength|20|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_BusinessClosureCalendarId"></a> BusinessClosureCalendarId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the business closure calendar of organization.|
|DisplayName|Business Closure Calendar|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|businessclosurecalendarid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_CalendarType"></a> CalendarType

|Property|Value|
|--------|-----|
|Description|Calendar type for the system. Set to Gregorian US by default.|
|DisplayName|Calendar Type|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|calendartype|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_CampaignPrefix"></a> CampaignPrefix

|Property|Value|
|--------|-----|
|Description|Prefix used for campaign numbering.|
|DisplayName|Campaign Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|campaignprefix|
|MaxLength|20|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CascadeStatusUpdate"></a> CascadeStatusUpdate

|Property|Value|
|--------|-----|
|Description|Flag to cascade Update on incident.|
|DisplayName|Cascade Status Update|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|cascadestatusupdate|
|RequiredLevel|None|
|Type|Boolean|

#### CascadeStatusUpdate Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_CasePrefix"></a> CasePrefix

|Property|Value|
|--------|-----|
|Description|Prefix to use for all cases throughout Microsoft Dynamics 365.|
|DisplayName|Case Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|caseprefix|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CategoryPrefix"></a> CategoryPrefix

|Property|Value|
|--------|-----|
|Description|Type the prefix to use for all categories in Microsoft Dynamics 365.|
|DisplayName|Category Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|categoryprefix|
|MaxLength|20|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ContractPrefix"></a> ContractPrefix

|Property|Value|
|--------|-----|
|Description|Prefix to use for all contracts throughout Microsoft Dynamics 365.|
|DisplayName|Contract Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|contractprefix|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CortanaProactiveExperienceEnabled"></a> CortanaProactiveExperienceEnabled

|Property|Value|
|--------|-----|
|Description|Indicates whether the feature CortanaProactiveExperience Flow processes should be enabled for the organization.|
|DisplayName|Enable Cortana Proactive Experience Flow processes for this Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|cortanaproactiveexperienceenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### CortanaProactiveExperienceEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_CreateProductsWithoutParentInActiveState"></a> CreateProductsWithoutParentInActiveState

|Property|Value|
|--------|-----|
|Description|Enable Initial state of newly created products to be Active instead of Draft|
|DisplayName|Enable Active Initial Product State|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createproductswithoutparentinactivestate|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### CreateProductsWithoutParentInActiveState Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_CurrencyDecimalPrecision"></a> CurrencyDecimalPrecision

|Property|Value|
|--------|-----|
|Description|Number of decimal places that can be used for currency.|
|DisplayName|Currency Decimal Precision|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|currencydecimalprecision|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_CurrencyDisplayOption"></a> CurrencyDisplayOption

|Property|Value|
|--------|-----|
|Description|Indicates whether to display money fields with currency code or currency symbol.|
|DisplayName|Display Currencies Using|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|currencydisplayoption|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### CurrencyDisplayOption Options

|Value|Label|
|-----|-----|
|0|Currency symbol|
|1|Currency code|



### <a name="BKMK_CurrencyFormatCode"></a> CurrencyFormatCode

|Property|Value|
|--------|-----|
|Description|Information about how currency symbols are placed throughout Microsoft Dynamics CRM.|
|DisplayName|Currency Format Code|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|currencyformatcode|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### CurrencyFormatCode Options

|Value|Label|
|-----|-----|
|0|$123|
|1|123$|
|2|$ 123|
|3|123 $|



### <a name="BKMK_CurrencySymbol"></a> CurrencySymbol

|Property|Value|
|--------|-----|
|Description|Symbol used for currency throughout Microsoft Dynamics 365.|
|DisplayName|Currency Symbol|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|currencysymbol|
|MaxLength|13|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CurrentBulkOperationNumber"></a> CurrentBulkOperationNumber

|Property|Value|
|--------|-----|
|Description|Current bulk operation number. Deprecated. Use SetAutoNumberSeed message.|
|DisplayName|Current Bulk Operation Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|currentbulkoperationnumber|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_CurrentCampaignNumber"></a> CurrentCampaignNumber

|Property|Value|
|--------|-----|
|Description|Current campaign number. Deprecated. Use SetAutoNumberSeed message.|
|DisplayName|Current Campaign Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|currentcampaignnumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_CurrentCaseNumber"></a> CurrentCaseNumber

|Property|Value|
|--------|-----|
|Description|First case number to use. Deprecated. Use SetAutoNumberSeed message.|
|DisplayName|Current Case Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|currentcasenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_CurrentCategoryNumber"></a> CurrentCategoryNumber

|Property|Value|
|--------|-----|
|Description|Enter the first number to use for Categories. Deprecated. Use SetAutoNumberSeed message.|
|DisplayName|Current Category Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|currentcategorynumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_CurrentContractNumber"></a> CurrentContractNumber

|Property|Value|
|--------|-----|
|Description|First contract number to use. Deprecated. Use SetAutoNumberSeed message.|
|DisplayName|Current Contract Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|currentcontractnumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_CurrentInvoiceNumber"></a> CurrentInvoiceNumber

|Property|Value|
|--------|-----|
|Description|First invoice number to use. Deprecated. Use SetAutoNumberSeed message.|
|DisplayName|Current Invoice Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|currentinvoicenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_CurrentKaNumber"></a> CurrentKaNumber

|Property|Value|
|--------|-----|
|Description|Enter the first number to use for knowledge articles. Deprecated. Use SetAutoNumberSeed message.|
|DisplayName|Current Knowledge Article Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|currentkanumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_CurrentKbNumber"></a> CurrentKbNumber

|Property|Value|
|--------|-----|
|Description|First article number to use. Deprecated. Use SetAutoNumberSeed message.|
|DisplayName|Current Article Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|currentkbnumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_CurrentOrderNumber"></a> CurrentOrderNumber

|Property|Value|
|--------|-----|
|Description|First order number to use. Deprecated. Use SetAutoNumberSeed message.|
|DisplayName|Current Order Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|currentordernumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_CurrentQuoteNumber"></a> CurrentQuoteNumber

|Property|Value|
|--------|-----|
|Description|First quote number to use. Deprecated. Use SetAutoNumberSeed message.|
|DisplayName|Current Quote Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|currentquotenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_DateFormatCode"></a> DateFormatCode

|Property|Value|
|--------|-----|
|Description|Information about how the date is displayed throughout Microsoft CRM.|
|DisplayName|Date Format Code|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|dateformatcode|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### DateFormatCode Options

| Value | Label |
|-------|-------|
|       |       |

### <a name="BKMK_DateFormatString"></a> DateFormatString

|Property|Value|
|--------|-----|
|Description|String showing how the date is displayed throughout Microsoft CRM.|
|DisplayName|Date Format String|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|dateformatstring|
|MaxLength|255|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_DateSeparator"></a> DateSeparator

|Property|Value|
|--------|-----|
|Description|Character used to separate the month, the day, and the year in dates throughout Microsoft Dynamics 365.|
|DisplayName|Date Separator|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|dateseparator|
|MaxLength|5|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_DecimalSymbol"></a> DecimalSymbol

|Property|Value|
|--------|-----|
|Description|Symbol used for decimal in Microsoft Dynamics 365.|
|DisplayName|Decimal Symbol|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|decimalsymbol|
|MaxLength|5|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_DefaultCountryCode"></a> DefaultCountryCode

|Property|Value|
|--------|-----|
|Description|Text area to enter default country code.|
|DisplayName|Default Country Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|defaultcountrycode|
|MaxLength|30|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_DefaultCrmCustomName"></a> DefaultCrmCustomName

|Property|Value|
|--------|-----|
|Description|Name of the default crm custom.|
|DisplayName|Name of the default app|
|FormatName|Text|
|IsLocalizable|True|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|defaultcrmcustomname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_DefaultEmailServerProfileId"></a> DefaultEmailServerProfileId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the default email server profile.|
|DisplayName|Email Server Profile|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|defaultemailserverprofileid|
|RequiredLevel|None|
|Targets|emailserverprofile|
|Type|Lookup|


### <a name="BKMK_DefaultEmailSettings"></a> DefaultEmailSettings

|Property|Value|
|--------|-----|
|Description|XML string containing the default email settings that are applied when a user or queue is created.|
|DisplayName|Default Email Settings|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|defaultemailsettings|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_DefaultMobileOfflineProfileId"></a> DefaultMobileOfflineProfileId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the default mobile offline profile.|
|DisplayName|Default Mobile Offline Profile|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|defaultmobileofflineprofileid|
|RequiredLevel|None|
|Targets|mobileofflineprofile|
|Type|Lookup|


### <a name="BKMK_DefaultRecurrenceEndRangeType"></a> DefaultRecurrenceEndRangeType

|Property|Value|
|--------|-----|
|Description|Type of default recurrence end range date.|
|DisplayName|Default Recurrence End Range Type|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|defaultrecurrenceendrangetype|
|RequiredLevel|None|
|Type|Picklist|

#### DefaultRecurrenceEndRangeType Options

|Value|Label|
|-----|-----|
|1|No End Date|
|2|Number of Occurrences|
|3|End By Date|



### <a name="BKMK_DefaultThemeData"></a> DefaultThemeData

|Property|Value|
|--------|-----|
|Description|Default theme data for the organization.|
|DisplayName|Default Theme Data|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|defaultthemedata|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_DelegatedAdminUserId"></a> DelegatedAdminUserId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegated admin user for the organization.|
|DisplayName|Delegated Admin|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|delegatedadminuserid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_DisableSocialCare"></a> DisableSocialCare

|Property|Value|
|--------|-----|
|Description|Indicates whether Social Care is disabled.|
|DisplayName|Is Social Care disabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|disablesocialcare|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### DisableSocialCare Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_DiscountCalculationMethod"></a> DiscountCalculationMethod

|Property|Value|
|--------|-----|
|Description|Discount calculation method for the QOOI product.|
|DisplayName|Discount calculation method|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|discountcalculationmethod|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### DiscountCalculationMethod Options

|Value|Label|
|-----|-----|
|0|Line item|
|1|Per unit|



### <a name="BKMK_DisplayNavigationTour"></a> DisplayNavigationTour

|Property|Value|
|--------|-----|
|Description|Indicates whether or not navigation tour is displayed.|
|DisplayName|Display Navigation Tour|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|displaynavigationtour|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### DisplayNavigationTour Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_EmailConnectionChannel"></a> EmailConnectionChannel

|Property|Value|
|--------|-----|
|Description|Select if you want to use the Email Router or server-side synchronization for email processing.|
|DisplayName|Email Connection Channel|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|emailconnectionchannel|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### EmailConnectionChannel Options

|Value|Label|
|-----|-----|
|0|Server-Side Synchronization|
|1|Microsoft Dynamics 365 Email Router|



### <a name="BKMK_EmailCorrelationEnabled"></a> EmailCorrelationEnabled

|Property|Value|
|--------|-----|
|Description|Flag to turn email correlation on or off.|
|DisplayName|Use Email Correlation|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|emailcorrelationenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### EmailCorrelationEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_EmailSendPollingPeriod"></a> EmailSendPollingPeriod

|Property|Value|
|--------|-----|
|Description|Normal polling frequency used for sending email in Microsoft Office Outlook.|
|DisplayName|Email Send Polling Frequency|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|emailsendpollingperiod|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_EnableBingMapsIntegration"></a> EnableBingMapsIntegration

|Property|Value|
|--------|-----|
|Description|Enable Integration with Bing Maps|
|DisplayName|Enable Integration with Bing Maps|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|enablebingmapsintegration|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### EnableBingMapsIntegration Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_EnableImmersiveSkypeIntegration"></a> EnableImmersiveSkypeIntegration

|Property|Value|
|--------|-----|
|Description|Enable Integration with Immersive Skype|
|DisplayName|Enable Integration with Immersive Skype|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|enableimmersiveskypeintegration|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### EnableImmersiveSkypeIntegration Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_EnableLPAuthoring"></a> EnableLPAuthoring

|Property|Value|
|--------|-----|
|Description|Select to enable learning path auhtoring.|
|DisplayName|Enable Learning Path Authoring|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|enablelpauthoring|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### EnableLPAuthoring Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_EnableMicrosoftFlowIntegration"></a> EnableMicrosoftFlowIntegration

|Property|Value|
|--------|-----|
|Description|Enable Integration with Microsoft Flow|
|DisplayName|Enable Integration with Microsoft Flow|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|enablemicrosoftflowintegration|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### EnableMicrosoftFlowIntegration Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_EnablePricingOnCreate"></a> EnablePricingOnCreate

|Property|Value|
|--------|-----|
|Description|Enable pricing calculations on a Create call.|
|DisplayName|Enable Pricing On Create|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|enablepricingoncreate|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### EnablePricingOnCreate Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_EnableSmartMatching"></a> EnableSmartMatching

|Property|Value|
|--------|-----|
|Description|Use Smart Matching.|
|DisplayName|Enable Smart Matching|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|enablesmartmatching|
|RequiredLevel|None|
|Type|Boolean|

#### EnableSmartMatching Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_EnforceReadOnlyPlugins"></a> EnforceReadOnlyPlugins

|Property|Value|
|--------|-----|
|Description|Organization setting to enforce read only plugins.|
|DisplayName|Organization setting to enforce read only plugins.|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|enforcereadonlyplugins|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### EnforceReadOnlyPlugins Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_EntityImage"></a> EntityImage

|Property|Value|
|--------|-----|
|Description|The default image for the entity.|
|DisplayName|Entity Image|
|IsPrimaryImage|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage|
|MaxHeight|144|
|MaxWidth|144|
|RequiredLevel|None|
|Type|Image|


### <a name="BKMK_ExpireChangeTrackingInDays"></a> ExpireChangeTrackingInDays

|Property|Value|
|--------|-----|
|Description|Maximum number of days to keep change tracking deleted records|
|DisplayName|Days to Expire Change Tracking Deleted Records|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|expirechangetrackingindays|
|MaxValue|365|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_ExpireSubscriptionsInDays"></a> ExpireSubscriptionsInDays

|Property|Value|
|--------|-----|
|Description|Maximum number of days before deleting inactive subscriptions.|
|DisplayName|Days to Expire Subscriptions|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|expiresubscriptionsindays|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_ExternalBaseUrl"></a> ExternalBaseUrl

|Property|Value|
|--------|-----|
|Description|Specify the base URL to use to look for external document suggestions.|
|DisplayName|External Base URL|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|externalbaseurl|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExternalPartyCorrelationKeys"></a> ExternalPartyCorrelationKeys

|Property|Value|
|--------|-----|
|Description|XML string containing the ExternalPartyEnabled entities correlation keys for association of existing External Party instance entities to newly created IsExternalPartyEnabled entities.For internal use only|
|DisplayName|ExternalPartyEnabled Entities correlation Keys|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|externalpartycorrelationkeys|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ExternalPartyEntitySettings"></a> ExternalPartyEntitySettings

|Property|Value|
|--------|-----|
|Description|XML string containing the ExternalPartyEnabled entities settings.|
|DisplayName|ExternalPartyEnabled Entities Settings.For internal use only|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|externalpartyentitysettings|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_FeatureSet"></a> FeatureSet

|Property|Value|
|--------|-----|
|Description|Features to be enabled as an XML BLOB.|
|DisplayName|Feature Set|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|featureset|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_FiscalCalendarStart"></a> FiscalCalendarStart

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Start date for the fiscal period that is to be used throughout Microsoft CRM.|
|DisplayName|Fiscal Calendar Start|
|Format|DateOnly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|fiscalcalendarstart|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_FiscalPeriodFormat"></a> FiscalPeriodFormat

|Property|Value|
|--------|-----|
|Description|Information that specifies how the name of the fiscal period is displayed throughout Microsoft CRM.|
|DisplayName|Fiscal Period Format|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|fiscalperiodformat|
|MaxLength|25|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_FiscalPeriodFormatPeriod"></a> FiscalPeriodFormatPeriod

|Property|Value|
|--------|-----|
|Description|Format in which the fiscal period will be displayed.|
|DisplayName|Format for Fiscal Period|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|fiscalperiodformatperiod|
|RequiredLevel|None|
|Type|Picklist|

#### FiscalPeriodFormatPeriod Options

|Value|Label|
|-----|-----|
|1|Quarter {0}|
|2|Q{0}|
|3|P{0}|
|4|Month {0}|
|5|M{0}|
|6|Semester {0}|
|7|Month Name|



### <a name="BKMK_FiscalPeriodType"></a> FiscalPeriodType

|Property|Value|
|--------|-----|
|Description|Type of fiscal period used throughout Microsoft CRM.|
|DisplayName|Fiscal Period Type|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|fiscalperiodtype|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_FiscalYearDisplayCode"></a> FiscalYearDisplayCode

|Property|Value|
|--------|-----|
|Description|Information that specifies whether the fiscal year should be displayed based on the start date or the end date of the fiscal year.|
|DisplayName|Fiscal Year Display|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|fiscalyeardisplaycode|
|MaxValue||
|MinValue||
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_FiscalYearFormat"></a> FiscalYearFormat

|Property|Value|
|--------|-----|
|Description|Information that specifies how the name of the fiscal year is displayed throughout Microsoft CRM.|
|DisplayName|Fiscal Year Format|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|fiscalyearformat|
|MaxLength|25|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_FiscalYearFormatPrefix"></a> FiscalYearFormatPrefix

|Property|Value|
|--------|-----|
|Description|Prefix for the display of the fiscal year.|
|DisplayName|Prefix for Fiscal Year|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|fiscalyearformatprefix|
|RequiredLevel|None|
|Type|Picklist|

#### FiscalYearFormatPrefix Options

|Value|Label|
|-----|-----|
|1|FY|
|2||



### <a name="BKMK_FiscalYearFormatSuffix"></a> FiscalYearFormatSuffix

|Property|Value|
|--------|-----|
|Description|Suffix for the display of the fiscal year.|
|DisplayName|Suffix for Fiscal Year|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|fiscalyearformatsuffix|
|RequiredLevel|None|
|Type|Picklist|

#### FiscalYearFormatSuffix Options

|Value|Label|
|-----|-----|
|1|FY|
|2| Fiscal Year|
|3||



### <a name="BKMK_FiscalYearFormatYear"></a> FiscalYearFormatYear

|Property|Value|
|--------|-----|
|Description|Format for the year.|
|DisplayName|Fiscal Year Format Year|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|fiscalyearformatyear|
|RequiredLevel|None|
|Type|Picklist|

#### FiscalYearFormatYear Options

|Value|Label|
|-----|-----|
|1|YYYY|
|2|YY|
|3|GGYY|



### <a name="BKMK_FiscalYearPeriodConnect"></a> FiscalYearPeriodConnect

|Property|Value|
|--------|-----|
|Description|Information that specifies how the names of the fiscal year and the fiscal period should be connected when displayed together.|
|DisplayName|Fiscal Year Period Connector|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|fiscalyearperiodconnect|
|MaxLength|5|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_FullNameConventionCode"></a> FullNameConventionCode

|Property|Value|
|--------|-----|
|Description|Order in which names are to be displayed throughout Microsoft CRM.|
|DisplayName|Full Name Display Order|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|fullnameconventioncode|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### FullNameConventionCode Options

|Value|Label|
|-----|-----|
|0|Last Name, First Name|
|1|First Name|
|2|Last Name, First Name, Middle Initial|
|3|First Name, Middle Initial, Last Name|
|4|Last Name, First Name, Middle Name|
|5|First Name, Middle Name, Last Name|
|6|Last Name, space, First Name|
|7|Last Name, no space, First Name|



### <a name="BKMK_FutureExpansionWindow"></a> FutureExpansionWindow

|Property|Value|
|--------|-----|
|Description|Specifies the maximum number of months in future for which the recurring activities can be created.|
|DisplayName|Future Expansion Window|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|futureexpansionwindow|
|MaxValue|140|
|MinValue|1|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_GenerateAlertsForErrors"></a> GenerateAlertsForErrors

|Property|Value|
|--------|-----|
|Description|Indicates whether alerts will be generated for errors.|
|DisplayName|Generate Alerts For Errors|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|generatealertsforerrors|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### GenerateAlertsForErrors Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_GenerateAlertsForInformation"></a> GenerateAlertsForInformation

|Property|Value|
|--------|-----|
|Description|Indicates whether alerts will be generated for information.|
|DisplayName|Generate Alerts For Information|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|generatealertsforinformation|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### GenerateAlertsForInformation Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_GenerateAlertsForWarnings"></a> GenerateAlertsForWarnings

|Property|Value|
|--------|-----|
|Description|Indicates whether alerts will be generated for warnings.|
|DisplayName|Generate Alerts For Warnings|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|generatealertsforwarnings|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### GenerateAlertsForWarnings Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_GetStartedPaneContentEnabled"></a> GetStartedPaneContentEnabled

|Property|Value|
|--------|-----|
|Description|Indicates whether Get Started content is enabled for this organization.|
|DisplayName|Is Get Started Pane Content Enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|getstartedpanecontentenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### GetStartedPaneContentEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_GlobalAppendUrlParametersEnabled"></a> GlobalAppendUrlParametersEnabled

|Property|Value|
|--------|-----|
|Description|Indicates whether the append URL parameters is enabled.|
|DisplayName|Is AppendUrl Parameters enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|globalappendurlparametersenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### GlobalAppendUrlParametersEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_GlobalHelpUrl"></a> GlobalHelpUrl

|Property|Value|
|--------|-----|
|Description|URL for the web page global help.|
|DisplayName|Global Help URL.|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|globalhelpurl|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_GlobalHelpUrlEnabled"></a> GlobalHelpUrlEnabled

|Property|Value|
|--------|-----|
|Description|Indicates whether the customizable global help is enabled.|
|DisplayName|Is Customizable Global Help enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|globalhelpurlenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### GlobalHelpUrlEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_GoalRollupExpiryTime"></a> GoalRollupExpiryTime

|Property|Value|
|--------|-----|
|Description|Number of days after the goal's end date after which the rollup of the goal stops automatically.|
|DisplayName|Rollup Expiration Time for Goal|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|goalrollupexpirytime|
|MaxValue|400|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_GoalRollupFrequency"></a> GoalRollupFrequency

|Property|Value|
|--------|-----|
|Description|Number of hours between automatic rollup jobs .|
|DisplayName|Automatic Rollup Frequency for Goal|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|goalrollupfrequency|
|MaxValue|2147483647|
|MinValue|1|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_GrantAccessToNetworkService"></a> GrantAccessToNetworkService

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Grant Access To Network Service|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|grantaccesstonetworkservice|
|RequiredLevel|None|
|Type|Boolean|

#### GrantAccessToNetworkService Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_HashDeltaSubjectCount"></a> HashDeltaSubjectCount

|Property|Value|
|--------|-----|
|Description|Maximum difference allowed between subject keywords count of the email messaged to be correlated|
|DisplayName|Hash Delta Subject Count|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|hashdeltasubjectcount|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_HashFilterKeywords"></a> HashFilterKeywords

|Property|Value|
|--------|-----|
|Description|Filter Subject Keywords|
|DisplayName|Hash Filter Keywords|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|hashfilterkeywords|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_HashMaxCount"></a> HashMaxCount

|Property|Value|
|--------|-----|
|Description|Maximum number of subject keywords or recipients used for correlation|
|DisplayName|Hash Max Count|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|hashmaxcount|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_HashMinAddressCount"></a> HashMinAddressCount

|Property|Value|
|--------|-----|
|Description|Minimum number of recipients required to match for email messaged to be correlated|
|DisplayName|Hash Min Address Count|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|hashminaddresscount|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_HighContrastThemeData"></a> HighContrastThemeData

|Property|Value|
|--------|-----|
|Description|High contrast theme data for the organization.|
|DisplayName|High contrast Theme Data|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|highcontrastthemedata|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_IgnoreInternalEmail"></a> IgnoreInternalEmail

|Property|Value|
|--------|-----|
|Description|Indicates whether incoming email sent by internal Microsoft Dynamics 365 users or queues should be tracked.|
|DisplayName|Ignore Internal Email|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ignoreinternalemail|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IgnoreInternalEmail Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_InactivityTimeoutEnabled"></a> InactivityTimeoutEnabled

|Property|Value|
|--------|-----|
|Description|Information that specifies whether Inactivity timeout is enabled|
|DisplayName|Inactivity timeout enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|inactivitytimeoutenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### InactivityTimeoutEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_InactivityTimeoutInMins"></a> InactivityTimeoutInMins

|Property|Value|
|--------|-----|
|Description|Inactivity timeout in minutes|
|DisplayName|Inactivity timeout in minutes|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|inactivitytimeoutinmins|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_InactivityTimeoutReminderInMins"></a> InactivityTimeoutReminderInMins

|Property|Value|
|--------|-----|
|Description|Inactivity timeout reminder in minutes|
|DisplayName|Inactivity timeout reminder in minutes|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|inactivitytimeoutreminderinmins|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_IncomingEmailExchangeEmailRetrievalBatchSize"></a> IncomingEmailExchangeEmailRetrievalBatchSize

|Property|Value|
|--------|-----|
|Description|Setting for the Async Service Mailbox Queue. Defines the retrieval batch size of exchange server.|
|DisplayName|Exchange Email Retrieval Batch Size|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|incomingemailexchangeemailretrievalbatchsize|
|MaxValue|2147483647|
|MinValue|1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_InitialVersion"></a> InitialVersion

|Property|Value|
|--------|-----|
|Description|Initial version of the organization.|
|DisplayName|Initial Version|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|initialversion|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_IntegrationUserId"></a> IntegrationUserId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the integration user for the organization.|
|DisplayName|Integration User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|integrationuserid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_InvoicePrefix"></a> InvoicePrefix

|Property|Value|
|--------|-----|
|Description|Prefix to use for all invoice numbers throughout Microsoft Dynamics 365.|
|DisplayName|Invoice Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|invoiceprefix|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_IsActionCardEnabled"></a> IsActionCardEnabled

|Property|Value|
|--------|-----|
|Description|Indicates whether the feature Action Card should be enabled for the organization.|
|DisplayName|Enable Action Card for this Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isactioncardenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsActionCardEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsActionSupportFeatureEnabled"></a> IsActionSupportFeatureEnabled

|Property|Value|
|--------|-----|
|Description|Information that specifies whether Action Support Feature is enabled|
|DisplayName|Action Support Feature enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isactionsupportfeatureenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsActionSupportFeatureEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsActivityAnalysisEnabled"></a> IsActivityAnalysisEnabled

|Property|Value|
|--------|-----|
|Description|Indicates whether the feature Relationship Analytics should be enabled for the organization.|
|DisplayName|Enable Relationship Analytics for this Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isactivityanalysisenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsActivityAnalysisEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsAppMode"></a> IsAppMode

|Property|Value|
|--------|-----|
|Description|Indicates whether loading of Microsoft Dynamics 365 in a browser window that does not have address, tool, and menu bars is enabled.|
|DisplayName|Is Application Mode Enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isappmode|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsAppMode Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsAppointmentAttachmentSyncEnabled"></a> IsAppointmentAttachmentSyncEnabled

|Property|Value|
|--------|-----|
|Description|Enable or disable attachments sync for outlook and exchange.|
|DisplayName|Is Attachment Sync Enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isappointmentattachmentsyncenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsAppointmentAttachmentSyncEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsAssignedTasksSyncEnabled"></a> IsAssignedTasksSyncEnabled

|Property|Value|
|--------|-----|
|Description|Enable or disable assigned tasks sync for outlook and exchange.|
|DisplayName|Is Assigned Tasks Sync Enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isassignedtaskssyncenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsAssignedTasksSyncEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsAuditEnabled"></a> IsAuditEnabled

|Property|Value|
|--------|-----|
|Description|Enable or disable auditing of changes.|
|DisplayName|Is Auditing Enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isauditenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsAuditEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsAutoDataCaptureEnabled"></a> IsAutoDataCaptureEnabled

|Property|Value|
|--------|-----|
|Description|Indicates whether the feature Auto Capture should be enabled for the organization.|
|DisplayName|Enable Auto Capture for this Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isautodatacaptureenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsAutoDataCaptureEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsAutoSaveEnabled"></a> IsAutoSaveEnabled

|Property|Value|
|--------|-----|
|Description|Information on whether auto save is enabled.|
|DisplayName|Auto Save Enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isautosaveenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsAutoSaveEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_IsBPFEntityCustomizationFeatureEnabled"></a> IsBPFEntityCustomizationFeatureEnabled

|Property|Value|
|--------|-----|
|Description|Information that specifies whether BPF Entity Customization Feature is enabled|
|DisplayName|BPF Entity Customization Feature enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isbpfentitycustomizationfeatureenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsBPFEntityCustomizationFeatureEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsConflictDetectionEnabledForMobileClient"></a> IsConflictDetectionEnabledForMobileClient

|Property|Value|
|--------|-----|
|Description|Information that specifies whether conflict detection for mobile client is enabled.|
|DisplayName|Is Conflict Detection for Mobile Client enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isconflictdetectionenabledformobileclient|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsConflictDetectionEnabledForMobileClient Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsContactMailingAddressSyncEnabled"></a> IsContactMailingAddressSyncEnabled

|Property|Value|
|--------|-----|
|Description|Enable or disable mailing address sync for outlook and exchange.|
|DisplayName|Is Mailing Address Sync Enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|iscontactmailingaddresssyncenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsContactMailingAddressSyncEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_IsDefaultCountryCodeCheckEnabled"></a> IsDefaultCountryCodeCheckEnabled

|Property|Value|
|--------|-----|
|Description|Enable or disable country code selection.|
|DisplayName|Enable or disable country code selection|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isdefaultcountrycodecheckenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsDefaultCountryCodeCheckEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_IsDelegateAccessEnabled"></a> IsDelegateAccessEnabled

|Property|Value|
|--------|-----|
|Description|Enable Delegation Access content|
|DisplayName|Is Delegation Access Enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isdelegateaccessenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsDelegateAccessEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsDelveActionHubIntegrationEnabled"></a> IsDelveActionHubIntegrationEnabled

|Property|Value|
|--------|-----|
|Description|Indicates whether the feature Action Hub should be enabled for the organization.|
|DisplayName|Enable Action Hub for this Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isdelveactionhubintegrationenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsDelveActionHubIntegrationEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsDuplicateDetectionEnabled"></a> IsDuplicateDetectionEnabled

|Property|Value|
|--------|-----|
|Description|Indicates whether duplicate detection of records is enabled.|
|DisplayName|Is Duplicate Detection Enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isduplicatedetectionenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsDuplicateDetectionEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsDuplicateDetectionEnabledForImport"></a> IsDuplicateDetectionEnabledForImport

|Property|Value|
|--------|-----|
|Description|Indicates whether duplicate detection of records during import is enabled.|
|DisplayName|Is Duplicate Detection Enabled For Import|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isduplicatedetectionenabledforimport|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsDuplicateDetectionEnabledForImport Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsDuplicateDetectionEnabledForOfflineSync"></a> IsDuplicateDetectionEnabledForOfflineSync

|Property|Value|
|--------|-----|
|Description|Indicates whether duplicate detection of records during offline synchronization is enabled.|
|DisplayName|Is Duplicate Detection Enabled For Offline Synchronization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isduplicatedetectionenabledforofflinesync|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsDuplicateDetectionEnabledForOfflineSync Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsDuplicateDetectionEnabledForOnlineCreateUpdate"></a> IsDuplicateDetectionEnabledForOnlineCreateUpdate

|Property|Value|
|--------|-----|
|Description|Indicates whether duplicate detection during online create or update is enabled.|
|DisplayName|Is Duplicate Detection Enabled for Online Create/Update|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isduplicatedetectionenabledforonlinecreateupdate|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsDuplicateDetectionEnabledForOnlineCreateUpdate Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsEmailMonitoringAllowed"></a> IsEmailMonitoringAllowed

|Property|Value|
|--------|-----|
|Description|Allow tracking recipient activity on sent emails.|
|DisplayName|Allow tracking recipient activity on sent emails|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isemailmonitoringallowed|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsEmailMonitoringAllowed Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_IsEmailServerProfileContentFilteringEnabled"></a> IsEmailServerProfileContentFilteringEnabled

|Property|Value|
|--------|-----|
|Description|Enable Email Server Profile content filtering|
|DisplayName|Is Email Server Profile Content Filtering Enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isemailserverprofilecontentfilteringenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsEmailServerProfileContentFilteringEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsEnabledForAllRoles"></a> IsEnabledForAllRoles

|Property|Value|
|--------|-----|
|Description|Indicates whether appmodule is enabled for all roles|
|DisplayName|option set values for isenabledforallroles|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isenabledforallroles|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsEnabledForAllRoles Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_IsExternalSearchIndexEnabled"></a> IsExternalSearchIndexEnabled

|Property|Value|
|--------|-----|
|Description|Select whether data can be synchronized with an external search index.|
|DisplayName|Enable external search data syncing|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isexternalsearchindexenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsExternalSearchIndexEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsFiscalPeriodMonthBased"></a> IsFiscalPeriodMonthBased

|Property|Value|
|--------|-----|
|Description|Indicates whether the fiscal period is displayed as the month number.|
|DisplayName|Is Fiscal Period Monthly|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isfiscalperiodmonthbased|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsFiscalPeriodMonthBased Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsFolderAutoCreatedonSP"></a> IsFolderAutoCreatedonSP

|Property|Value|
|--------|-----|
|Description|Select whether folders should be automatically created on SharePoint.|
|DisplayName|Automatically create folders|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isfolderautocreatedonsp|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsFolderAutoCreatedonSP Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsFolderBasedTrackingEnabled"></a> IsFolderBasedTrackingEnabled

|Property|Value|
|--------|-----|
|Description|Enable or disable folder based tracking for Server Side Sync.|
|DisplayName|Is Folder Based Tracking Enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isfolderbasedtrackingenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsFolderBasedTrackingEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsFullTextSearchEnabled"></a> IsFullTextSearchEnabled

|Property|Value|
|--------|-----|
|Description|Indicates whether full-text search for Quick Find entities should be enabled for the organization.|
|DisplayName|Enable Full-text search for Quick Find|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isfulltextsearchenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsFullTextSearchEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_IsHierarchicalSecurityModelEnabled"></a> IsHierarchicalSecurityModelEnabled

|Property|Value|
|--------|-----|
|Description|Enable Hierarchical Security Model|
|DisplayName|Enable Hierarchical Security Model|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ishierarchicalsecuritymodelenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsHierarchicalSecurityModelEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_IsMailboxForcedUnlockingEnabled"></a> IsMailboxForcedUnlockingEnabled

|Property|Value|
|--------|-----|
|Description|Enable or disable forced unlocking for Server Side Sync mailboxes.|
|DisplayName|Is Mailbox Forced Unlocking Enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ismailboxforcedunlockingenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsMailboxForcedUnlockingEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsMailboxInactiveBackoffEnabled"></a> IsMailboxInactiveBackoffEnabled

|Property|Value|
|--------|-----|
|Description|Enable or disable mailbox keep alive for Server Side Sync.|
|DisplayName|Is Mailbox Keep Alive Enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ismailboxinactivebackoffenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsMailboxInactiveBackoffEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsMobileClientOnDemandSyncEnabled"></a> IsMobileClientOnDemandSyncEnabled

|Property|Value|
|--------|-----|
|Description|Information that specifies whether mobile client on demand sync is enabled.|
|DisplayName|Is Mobile Client On Demand Sync enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ismobileclientondemandsyncenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsMobileClientOnDemandSyncEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsMobileOfflineEnabled"></a> IsMobileOfflineEnabled

|Property|Value|
|--------|-----|
|Description|Indicates whether the feature MobileOffline should be enabled for the organization.|
|DisplayName|Enable MobileOffline for this Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ismobileofflineenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsMobileOfflineEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsOfficeGraphEnabled"></a> IsOfficeGraphEnabled

|Property|Value|
|--------|-----|
|Description|Indicates whether the feature OfficeGraph should be enabled for the organization.|
|DisplayName|Enable OfficeGraph for this Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isofficegraphenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsOfficeGraphEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsOneDriveEnabled"></a> IsOneDriveEnabled

|Property|Value|
|--------|-----|
|Description|Indicates whether the feature One Drive should be enabled for the organization.|
|DisplayName|Enable One Drive for this Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isonedriveenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsOneDriveEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsPresenceEnabled"></a> IsPresenceEnabled

|Property|Value|
|--------|-----|
|Description|Information on whether IM presence is enabled.|
|DisplayName|Presence Enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ispresenceenabled|
|RequiredLevel|None|
|Type|Boolean|

#### IsPresenceEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_IsPreviewEnabledForActionCard"></a> IsPreviewEnabledForActionCard

|Property|Value|
|--------|-----|
|Description|Indicates whether the Preview feature for Action Card should be enabled for the organization.|
|DisplayName|Enable Preview Action Card feature for this Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ispreviewenabledforactioncard|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsPreviewEnabledForActionCard Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsPreviewForAutoCaptureEnabled"></a> IsPreviewForAutoCaptureEnabled

|Property|Value|
|--------|-----|
|Description|Indicates whether the feature Auto Capture should be enabled for the organization at Preview Settings.|
|DisplayName|Enable Auto Capture for this Organization at Preview Settings|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ispreviewforautocaptureenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsPreviewForAutoCaptureEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsPreviewForEmailMonitoringAllowed"></a> IsPreviewForEmailMonitoringAllowed

|Property|Value|
|--------|-----|
|Description|Is Preview For Email Monitoring Allowed.|
|DisplayName|Allows Preview For Email Monitoring|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|ispreviewforemailmonitoringallowed|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsPreviewForEmailMonitoringAllowed Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_IsRelationshipInsightsEnabled"></a> IsRelationshipInsightsEnabled

|Property|Value|
|--------|-----|
|Description|Indicates whether the feature Relationship Insights should be enabled for the organization.|
|DisplayName|Enable Relationship Insights for this Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isrelationshipinsightsenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsRelationshipInsightsEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsResourceBookingExchangeSyncEnabled"></a> IsResourceBookingExchangeSyncEnabled

|Property|Value|
|--------|-----|
|Description|Indicates if the synchronization of user resource booking with Exchange is enabled at organization level.|
|DisplayName|Resource booking synchronization enabled|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isresourcebookingexchangesyncenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsResourceBookingExchangeSyncEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsSOPIntegrationEnabled"></a> IsSOPIntegrationEnabled

|Property|Value|
|--------|-----|
|Description|Enable sales order processing integration.|
|DisplayName|Is Sales Order Integration Enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|issopintegrationenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsSOPIntegrationEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsTextWrapEnabled"></a> IsTextWrapEnabled

|Property|Value|
|--------|-----|
|Description|Information on whether text wrap is enabled.|
|DisplayName|Enable Text Wrap|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|istextwrapenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsTextWrapEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_IsUserAccessAuditEnabled"></a> IsUserAccessAuditEnabled

|Property|Value|
|--------|-----|
|Description|Enable or disable auditing of user access.|
|DisplayName|Is User Access Auditing Enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isuseraccessauditenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### IsUserAccessAuditEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_ISVIntegrationCode"></a> ISVIntegrationCode

|Property|Value|
|--------|-----|
|Description|Indicates whether loading of Microsoft Dynamics 365 in a browser window that does not have address, tool, and menu bars is enabled.|
|DisplayName|ISV Integration Mode|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isvintegrationcode|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### ISVIntegrationCode Options

|Value|Label|
|-----|-----|
|0|None|
|1|Web|
|2|Outlook Workstation Client|
|3|Web; Outlook Workstation Client|
|4|Outlook Laptop Client|
|5|Web; Outlook Laptop Client|
|6|Outlook|
|7|All|



### <a name="BKMK_KaPrefix"></a> KaPrefix

|Property|Value|
|--------|-----|
|Description|Type the prefix to use for all knowledge articles in Microsoft Dynamics 365.|
|DisplayName|Knowledge Article Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|kaprefix|
|MaxLength|20|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_KbPrefix"></a> KbPrefix

|Property|Value|
|--------|-----|
|Description|Prefix to use for all articles in Microsoft Dynamics 365.|
|DisplayName|Article Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|kbprefix|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_KMSettings"></a> KMSettings

|Property|Value|
|--------|-----|
|Description|XML string containing the Knowledge Management settings that are applied in Knowledge Management Wizard.|
|DisplayName|Knowledge Management Settings|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|kmsettings|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_LanguageCode"></a> LanguageCode

|Property|Value|
|--------|-----|
|Description|Preferred language for the organization.|
|DisplayName|Language|
|Format|Locale|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|languagecode|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_LocaleId"></a> LocaleId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the locale of the organization.|
|DisplayName|Locale|
|Format|Locale|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|localeid|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_LongDateFormatCode"></a> LongDateFormatCode

|Property|Value|
|--------|-----|
|Description|Information that specifies how the Long Date format is displayed in Microsoft Dynamics 365.|
|DisplayName|Long Date Format|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|longdateformatcode|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_MailboxIntermittentIssueMinRange"></a> MailboxIntermittentIssueMinRange

|Property|Value|
|--------|-----|
|Description|Lower Threshold For Mailbox Intermittent Issue.|
|DisplayName|Lower Threshold For Mailbox Intermittent Issue|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|mailboxintermittentissueminrange|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_MailboxPermanentIssueMinRange"></a> MailboxPermanentIssueMinRange

|Property|Value|
|--------|-----|
|Description|Lower Threshold For Mailbox Permanent Issue.|
|DisplayName|Lower Threshold For Mailbox Permanent Issue.|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|mailboxpermanentissueminrange|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_MaxActionStepsInBPF"></a> MaxActionStepsInBPF

|Property|Value|
|--------|-----|
|Description|Maximum number of actionsteps allowed in a BPF|
|DisplayName|Maximum number of actionsteps allowed in a BPF|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|maxactionstepsinbpf|
|MaxValue|100|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_MaxAppointmentDurationDays"></a> MaxAppointmentDurationDays

|Property|Value|
|--------|-----|
|Description|Maximum number of days an appointment can last.|
|DisplayName|Max Appointment Duration|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|maxappointmentdurationdays|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_MaxConditionsForMobileOfflineFilters"></a> MaxConditionsForMobileOfflineFilters

|Property|Value|
|--------|-----|
|Description|Maximum number of conditions allowed for mobile offline filters|
|DisplayName|Maximum number of conditions allowed for mobile offline filters|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|maxconditionsformobileofflinefilters|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_MaxDepthForHierarchicalSecurityModel"></a> MaxDepthForHierarchicalSecurityModel

|Property|Value|
|--------|-----|
|Description|Maximum depth for hierarchy security propagation.|
|DisplayName|Maximum depth for hierarchy security propagation.|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|maxdepthforhierarchicalsecuritymodel|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_MaxFolderBasedTrackingMappings"></a> MaxFolderBasedTrackingMappings

|Property|Value|
|--------|-----|
|Description|Maximum number of Folder Based Tracking mappings user can add|
|DisplayName|Max Folder Based Tracking Mappings|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|maxfolderbasedtrackingmappings|
|MaxValue|25|
|MinValue|1|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_MaximumActiveBusinessProcessFlowsAllowedPerEntity"></a> MaximumActiveBusinessProcessFlowsAllowedPerEntity

|Property|Value|
|--------|-----|
|Description|Maximum number of active business process flows allowed per entity|
|DisplayName|Maximum active business process flows per entity|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|maximumactivebusinessprocessflowsallowedperentity|
|MaxValue|2147483647|
|MinValue|1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_MaximumDynamicPropertiesAllowed"></a> MaximumDynamicPropertiesAllowed

|Property|Value|
|--------|-----|
|Description|Restrict the maximum number of product properties for a product family/bundle|
|DisplayName|Product Properties Item Limit|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|maximumdynamicpropertiesallowed|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_MaximumEntitiesWithActiveSLA"></a> MaximumEntitiesWithActiveSLA

|Property|Value|
|--------|-----|
|Description|Maximum number of active SLA allowed per entity in online|
|DisplayName|Maximum number of active SLA allowed per entity in online|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|maximumentitieswithactivesla|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_MaximumSLAKPIPerEntityWithActiveSLA"></a> MaximumSLAKPIPerEntityWithActiveSLA

|Property|Value|
|--------|-----|
|Description|Maximum number of SLA KPI per active SLA allowed for entity in online|
|DisplayName|Maximum number of active SLA KPI allowed per entity in online|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|maximumslakpiperentitywithactivesla|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_MaximumTrackingNumber"></a> MaximumTrackingNumber

|Property|Value|
|--------|-----|
|Description|Maximum tracking number before recycling takes place.|
|DisplayName|Max Tracking Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|maximumtrackingnumber|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_MaxProductsInBundle"></a> MaxProductsInBundle

|Property|Value|
|--------|-----|
|Description|Restrict the maximum no of items in a bundle|
|DisplayName|Bundle Item Limit|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|maxproductsinbundle|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_MaxRecordsForExportToExcel"></a> MaxRecordsForExportToExcel

|Property|Value|
|--------|-----|
|Description|Maximum number of records that will be exported to a static Microsoft Office Excel worksheet when exporting from the grid.|
|DisplayName|Max Records For Excel Export|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|maxrecordsforexporttoexcel|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_MaxRecordsForLookupFilters"></a> MaxRecordsForLookupFilters

|Property|Value|
|--------|-----|
|Description|Maximum number of lookup and picklist records that can be selected by user for filtering.|
|DisplayName|Max Records Filter Selection|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|maxrecordsforlookupfilters|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_MaxUploadFileSize"></a> MaxUploadFileSize

|Property|Value|
|--------|-----|
|Description|Maximum allowed size of an attachment.|
|DisplayName|Max Upload File Size|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|maxuploadfilesize|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_MicrosoftFlowEnvironment"></a> MicrosoftFlowEnvironment

|Property|Value|
|--------|-----|
|Description|Environment selected for Integration with Microsoft Flow|
|DisplayName|Environment selected for Integration with Microsoft Flow|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|microsoftflowenvironment|
|MaxLength|1024|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_MinAddressBookSyncInterval"></a> MinAddressBookSyncInterval

|Property|Value|
|--------|-----|
|Description|Normal polling frequency used for address book synchronization in Microsoft Office Outlook.|
|DisplayName|Min Address Synchronization Frequency|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|minaddressbooksyncinterval|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_MinOfflineSyncInterval"></a> MinOfflineSyncInterval

|Property|Value|
|--------|-----|
|Description|Normal polling frequency used for background offline synchronization in Microsoft Office Outlook.|
|DisplayName|Min Offline Synchronization Frequency|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|minofflinesyncinterval|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_MinOutlookSyncInterval"></a> MinOutlookSyncInterval

|Property|Value|
|--------|-----|
|Description|Minimum allowed time between scheduled Outlook synchronizations.|
|DisplayName|Min Synchronization Frequency|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|minoutlooksyncinterval|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_MobileOfflineSyncInterval"></a> MobileOfflineSyncInterval

|Property|Value|
|--------|-----|
|Description|Sync interval for mobile offline.|
|DisplayName|Sync interval for mobile offline.|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|mobileofflinesyncinterval|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_Name"></a> Name

|Property|Value|
|--------|-----|
|Description|Name of the organization. The name is set when Microsoft CRM is installed and should not be changed.|
|DisplayName|Organization Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|name|
|MaxLength|160|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_NegativeCurrencyFormatCode"></a> NegativeCurrencyFormatCode

|Property|Value|
|--------|-----|
|Description|Information that specifies how negative currency numbers are displayed throughout Microsoft Dynamics 365.|
|DisplayName|Negative Currency Format|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|negativecurrencyformatcode|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_NegativeFormatCode"></a> NegativeFormatCode

|Property|Value|
|--------|-----|
|Description|Information that specifies how negative numbers are displayed throughout Microsoft CRM.|
|DisplayName|Negative Format|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|negativeformatcode|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### NegativeFormatCode Options

|Value|Label|
|-----|-----|
|0|Brackets|
|1|Dash|
|2|Dash plus Space|
|3|Trailing Dash|
|4|Space plus Trailing Dash|



### <a name="BKMK_NextTrackingNumber"></a> NextTrackingNumber

|Property|Value|
|--------|-----|
|Description|Next token to be placed on the subject line of an email message.|
|DisplayName|Next Tracking Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|nexttrackingnumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_NotifyMailboxOwnerOfEmailServerLevelAlerts"></a> NotifyMailboxOwnerOfEmailServerLevelAlerts

|Property|Value|
|--------|-----|
|Description|Indicates whether mailbox owners will be notified of email server profile level alerts.|
|DisplayName|Notify Mailbox Owner Of Email Server Level Alerts|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|notifymailboxownerofemailserverlevelalerts|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### NotifyMailboxOwnerOfEmailServerLevelAlerts Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_NumberFormat"></a> NumberFormat

|Property|Value|
|--------|-----|
|Description|Specification of how numbers are displayed throughout Microsoft CRM.|
|DisplayName|Number Format|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|numberformat|
|MaxLength|2|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_NumberGroupFormat"></a> NumberGroupFormat

|Property|Value|
|--------|-----|
|Description|Specifies how numbers are grouped in Microsoft Dynamics 365.|
|DisplayName|Number Grouping Format|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|numbergroupformat|
|MaxLength|50|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_NumberSeparator"></a> NumberSeparator

|Property|Value|
|--------|-----|
|Description|Symbol used for number separation in Microsoft Dynamics 365.|
|DisplayName|Number Separator|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|numberseparator|
|MaxLength|5|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_OfficeAppsAutoDeploymentEnabled"></a> OfficeAppsAutoDeploymentEnabled

|Property|Value|
|--------|-----|
|Description|Indicates whether the Office Apps auto deployment is enabled for the organization.|
|DisplayName|Enable Office Apps Auto Deployment for this Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|officeappsautodeploymentenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### OfficeAppsAutoDeploymentEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_OfficeGraphDelveUrl"></a> OfficeGraphDelveUrl

|Property|Value|
|--------|-----|
|Description|The url to open the Delve for the organization.|
|DisplayName|The url to open the Delve|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|officegraphdelveurl|
|MaxLength|1000|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OOBPriceCalculationEnabled"></a> OOBPriceCalculationEnabled

|Property|Value|
|--------|-----|
|Description|Enable OOB pricing calculation logic for Opportunity, Quote, Order and Invoice entities.|
|DisplayName|Enable OOB Price calculation|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|oobpricecalculationenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### OOBPriceCalculationEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_OrderPrefix"></a> OrderPrefix

|Property|Value|
|--------|-----|
|Description|Prefix to use for all orders throughout Microsoft Dynamics 365.|
|DisplayName|Order Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|orderprefix|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrgDbOrgSettings"></a> OrgDbOrgSettings

|Property|Value|
|--------|-----|
|Description|Organization settings stored in Organization Database.|
|DisplayName|Organization Database Organization Settings|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|orgdborgsettings|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_OrgInsightsEnabled"></a> OrgInsightsEnabled

|Property|Value|
|--------|-----|
|Description|Select whether to turn on OrgInsights for the organization.|
|DisplayName|Enable OrgInsights for this Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|orginsightsenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### OrgInsightsEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_PastExpansionWindow"></a> PastExpansionWindow

|Property|Value|
|--------|-----|
|Description|Specifies the maximum number of months in past for which the recurring activities can be created.|
|DisplayName|Past Expansion Window|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|pastexpansionwindow|
|MaxValue|120|
|MinValue|1|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_Picture"></a> Picture

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Picture|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|picture|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_PinpointLanguageCode"></a> PinpointLanguageCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|Format|Locale|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|pinpointlanguagecode|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_PluginTraceLogSetting"></a> PluginTraceLogSetting

|Property|Value|
|--------|-----|
|Description|Plug-in Trace Log Setting for the Organization.|
|DisplayName|Plug-in Trace Log Setting|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|plugintracelogsetting|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### PluginTraceLogSetting Options

|Value|Label|
|-----|-----|
|0|Off|
|1|Exception|
|2|All|



### <a name="BKMK_PMDesignator"></a> PMDesignator

|Property|Value|
|--------|-----|
|Description|PM designator to use throughout Microsoft Dynamics 365.|
|DisplayName|PM Designator|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|pmdesignator|
|MaxLength|25|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_PostMessageWhitelistDomains"></a> PostMessageWhitelistDomains

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|For internal use only.|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|postmessagewhitelistdomains|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PowerBiFeatureEnabled"></a> PowerBiFeatureEnabled

|Property|Value|
|--------|-----|
|Description|Indicates whether the Power BI feature should be enabled for the organization.|
|DisplayName|Enable Power BI feature for this Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|powerbifeatureenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### PowerBiFeatureEnabled Options

|Value|Label|
|-----|-----|
|1|Enable|
|0|Disable|

**DefaultValue**: False



### <a name="BKMK_PricingDecimalPrecision"></a> PricingDecimalPrecision

|Property|Value|
|--------|-----|
|Description|Number of decimal places that can be used for prices.|
|DisplayName|Pricing Decimal Precision|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|pricingdecimalprecision|
|MaxValue|4|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_PrivacyStatementUrl"></a> PrivacyStatementUrl

|Property|Value|
|--------|-----|
|Description|Privacy Statement URL|
|DisplayName|Privacy Statement URL|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|privacystatementurl|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_PrivilegeUserGroupId"></a> PrivilegeUserGroupId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the default privilege for users in the organization.|
|DisplayName|Privilege User Group|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|privilegeusergroupid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_PrivReportingGroupId"></a> PrivReportingGroupId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Privilege Reporting Group|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|privreportinggroupid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_PrivReportingGroupName"></a> PrivReportingGroupName

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Privilege Reporting Group Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|privreportinggroupname|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ProductRecommendationsEnabled"></a> ProductRecommendationsEnabled

|Property|Value|
|--------|-----|
|Description|Select whether to turn on product recommendations for the organization.|
|DisplayName|Enable Product Recommendations for this Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|productrecommendationsenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### ProductRecommendationsEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_QuickFindRecordLimitEnabled"></a> QuickFindRecordLimitEnabled

|Property|Value|
|--------|-----|
|Description|Indicates whether a quick find record limit should be enabled for this organization (allows for faster Quick Find queries but prevents overly broad searches).|
|DisplayName|Quick Find Record Limit Enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|quickfindrecordlimitenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### QuickFindRecordLimitEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_QuotePrefix"></a> QuotePrefix

|Property|Value|
|--------|-----|
|Description|Prefix to use for all quotes throughout Microsoft Dynamics 365.|
|DisplayName|Quote Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|quoteprefix|
|MaxLength|20|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RecurrenceDefaultNumberOfOccurrences"></a> RecurrenceDefaultNumberOfOccurrences

|Property|Value|
|--------|-----|
|Description|Specifies the default value for number of occurrences field in the recurrence dialog.|
|DisplayName|Recurrence Default Number of Occurrences|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|recurrencedefaultnumberofoccurrences|
|MaxValue|999|
|MinValue|1|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_RecurrenceExpansionJobBatchInterval"></a> RecurrenceExpansionJobBatchInterval

|Property|Value|
|--------|-----|
|Description|Specifies the interval (in seconds) for pausing expansion job.|
|DisplayName|Recurrence Expansion Job Batch Interval|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|recurrenceexpansionjobbatchinterval|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_RecurrenceExpansionJobBatchSize"></a> RecurrenceExpansionJobBatchSize

|Property|Value|
|--------|-----|
|Description|Specifies the value for number of instances created in on demand job in one shot.|
|DisplayName|Recurrence Expansion On Demand Job Batch Size|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|recurrenceexpansionjobbatchsize|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_RecurrenceExpansionSynchCreateMax"></a> RecurrenceExpansionSynchCreateMax

|Property|Value|
|--------|-----|
|Description|Specifies the maximum number of instances to be created synchronously after creating a recurring appointment.|
|DisplayName|Recurrence Expansion Synchronization Create Maximum|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|recurrenceexpansionsynchcreatemax|
|MaxValue|1000|
|MinValue|1|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_ReferenceSiteMapXml"></a> ReferenceSiteMapXml

|Property|Value|
|--------|-----|
|Description|XML string that defines the navigation structure for the application. This is the site map from the previously upgraded build and is used in a 3-way merge during upgrade.|
|DisplayName|Reference SiteMap XML|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|referencesitemapxml|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_RenderSecureIFrameForEmail"></a> RenderSecureIFrameForEmail

|Property|Value|
|--------|-----|
|Description|Flag to render the body of email in the Web form in an IFRAME with the security='restricted' attribute set. This is additional security but can cause a credentials prompt.|
|DisplayName|Render Secure Frame For Email|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|rendersecureiframeforemail|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### RenderSecureIFrameForEmail Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_ReportingGroupId"></a> ReportingGroupId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Reporting Group|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|reportinggroupid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_ReportingGroupName"></a> ReportingGroupName

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Reporting Group Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|reportinggroupname|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ReportScriptErrors"></a> ReportScriptErrors

|Property|Value|
|--------|-----|
|Description|Picklist for selecting the organization preference for reporting scripting errors.|
|DisplayName|Report Script Errors|
|IsValidForForm|True|
|IsValidForRead|True|
|LogicalName|reportscripterrors|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### ReportScriptErrors Options

|Value|Label|
|-----|-----|
|0|No preference for sending an error report to Microsoft about Microsoft Dynamics 365|
|1|Ask me for permission to send an error report to Microsoft|
|2|Automatically send an error report to Microsoft without asking me for permission|
|3|Never send an error report to Microsoft about Microsoft Dynamics 365|



### <a name="BKMK_RequireApprovalForQueueEmail"></a> RequireApprovalForQueueEmail

|Property|Value|
|--------|-----|
|Description|Indicates whether Send As Other User privilege is enabled.|
|DisplayName|Is Approval For Queue Email Required|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|requireapprovalforqueueemail|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### RequireApprovalForQueueEmail Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_RequireApprovalForUserEmail"></a> RequireApprovalForUserEmail

|Property|Value|
|--------|-----|
|Description|Indicates whether Send As Other User privilege is enabled.|
|DisplayName|Is Approval For User Email Required|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|requireapprovalforuseremail|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### RequireApprovalForUserEmail Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_ResolveSimilarUnresolvedEmailAddress"></a> ResolveSimilarUnresolvedEmailAddress

|Property|Value|
|--------|-----|
|Description|Apply same email address to all unresolved matches when you manually resolve it for one|
|DisplayName|Apply same email address to all unresolved matches when you manually resolve it for one|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|resolvesimilarunresolvedemailaddress|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### ResolveSimilarUnresolvedEmailAddress Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_RestrictStatusUpdate"></a> RestrictStatusUpdate

|Property|Value|
|--------|-----|
|Description|Flag to restrict Update on incident.|
|DisplayName|Restrict Status Update|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|restrictstatusupdate|
|RequiredLevel|None|
|Type|Boolean|

#### RestrictStatusUpdate Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_RiErrorStatus"></a> RiErrorStatus

|Property|Value|
|--------|-----|
|Description|Error status of Relationship Insights provisioning.|
|DisplayName|Error status of Relationship Insights provisioning.|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|rierrorstatus|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_SampleDataImportId"></a> SampleDataImportId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the sample data import job.|
|DisplayName|Sample Data Import|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sampledataimportid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_SchemaNamePrefix"></a> SchemaNamePrefix

|Property|Value|
|--------|-----|
|Description|Prefix used for custom entities and attributes.|
|DisplayName|Customization Name Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|schemanameprefix|
|MaxLength|8|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ServeStaticResourcesFromAzureCDN"></a> ServeStaticResourcesFromAzureCDN

|Property|Value|
|--------|-----|
|Description|Serve Static Content From CDN|
|DisplayName|Serve Static Content From CDN|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|servestaticresourcesfromazurecdn|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### ServeStaticResourcesFromAzureCDN Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_SessionTimeoutEnabled"></a> SessionTimeoutEnabled

|Property|Value|
|--------|-----|
|Description|Information that specifies whether session timeout is enabled|
|DisplayName|Session timeout enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sessiontimeoutenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### SessionTimeoutEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_SessionTimeoutInMins"></a> SessionTimeoutInMins

|Property|Value|
|--------|-----|
|Description|Session timeout in minutes|
|DisplayName|Session timeout in minutes|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sessiontimeoutinmins|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_SessionTimeoutReminderInMins"></a> SessionTimeoutReminderInMins

|Property|Value|
|--------|-----|
|Description|Session timeout reminder in minutes|
|DisplayName|Session timeout reminder in minutes|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sessiontimeoutreminderinmins|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_SharePointDeploymentType"></a> SharePointDeploymentType

|Property|Value|
|--------|-----|
|Description|Indicates which SharePoint deployment type is configured for Server to Server. (Online or On-Premises)|
|DisplayName|Choose SharePoint Deployment Type|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sharepointdeploymenttype|
|RequiredLevel|None|
|Type|Picklist|

#### SharePointDeploymentType Options

|Value|Label|
|-----|-----|
|0|Online|
|1|On-Premises|



### <a name="BKMK_ShareToPreviousOwnerOnAssign"></a> ShareToPreviousOwnerOnAssign

|Property|Value|
|--------|-----|
|Description|Information that specifies whether to share to previous owner on assign.|
|DisplayName|Share To Previous Owner On Assign|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sharetopreviousowneronassign|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### ShareToPreviousOwnerOnAssign Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_ShowKBArticleDeprecationNotification"></a> ShowKBArticleDeprecationNotification

|Property|Value|
|--------|-----|
|Description|Select whether to display a KB article deprecation notification to the user.|
|DisplayName|Show KBArticle deprecation message to user|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|showkbarticledeprecationnotification|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### ShowKBArticleDeprecationNotification Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_ShowWeekNumber"></a> ShowWeekNumber

|Property|Value|
|--------|-----|
|Description|Information that specifies whether to display the week number in calendar displays throughout Microsoft CRM.|
|DisplayName|Show Week Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|showweeknumber|
|RequiredLevel|None|
|Type|Boolean|

#### ShowWeekNumber Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_SignupOutlookDownloadFWLink"></a> SignupOutlookDownloadFWLink

|Property|Value|
|--------|-----|
|Description|CRM for Outlook Download URL|
|DisplayName|CRMForOutlookDownloadURL|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|signupoutlookdownloadfwlink|
|MaxLength|200|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_SiteMapXml"></a> SiteMapXml

|Property|Value|
|--------|-----|
|Description|XML string that defines the navigation structure for the application.|
|DisplayName|SiteMap XML|
|Format|TextArea|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sitemapxml|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|Memo|


### <a name="BKMK_SlaPauseStates"></a> SlaPauseStates

|Property|Value|
|--------|-----|
|Description|Contains the on hold case status values.|
|DisplayName|SLA pause states|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|slapausestates|
|MaxLength|1073741823|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SocialInsightsEnabled"></a> SocialInsightsEnabled

|Property|Value|
|--------|-----|
|Description|Flag for whether the organization is using Social Insights.|
|DisplayName|Social Insights Enabled|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|socialinsightsenabled|
|RequiredLevel|None|
|Type|Boolean|

#### SocialInsightsEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_SocialInsightsInstance"></a> SocialInsightsInstance

|Property|Value|
|--------|-----|
|Description|Identifier for the Social Insights instance for the organization.|
|DisplayName|Social Insights instance identifier|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|socialinsightsinstance|
|MaxLength|2048|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SocialInsightsTermsAccepted"></a> SocialInsightsTermsAccepted

|Property|Value|
|--------|-----|
|Description|Flag for whether the organization has accepted the Social Insights terms of use.|
|DisplayName|Social Insights Terms of Use|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|socialinsightstermsaccepted|
|RequiredLevel|None|
|Type|Boolean|

#### SocialInsightsTermsAccepted Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_SortId"></a> SortId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Sort|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sortid|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_SqlAccessGroupId"></a> SqlAccessGroupId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|SQL Access Group|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sqlaccessgroupid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_SqlAccessGroupName"></a> SqlAccessGroupName

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|SQL Access Group Name|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sqlaccessgroupname|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_SQMEnabled"></a> SQMEnabled

|Property|Value|
|--------|-----|
|Description|Setting for SQM data collection, 0 no, 1 yes enabled|
|DisplayName|Is SQM Enabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|sqmenabled|
|RequiredLevel|None|
|Type|Boolean|

#### SQMEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_SupportUserId"></a> SupportUserId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the support user for the organization.|
|DisplayName|Support User|
|IsValidForForm|False|
|IsValidForRead|True|
|IsValidForUpdate|False|
|LogicalName|supportuserid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_SuppressSLA"></a> SuppressSLA

|Property|Value|
|--------|-----|
|Description|Indicates whether SLA is suppressed.|
|DisplayName|Is SLA suppressed|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|suppresssla|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### SuppressSLA Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_SyncOptInSelection"></a> SyncOptInSelection

|Property|Value|
|--------|-----|
|Description|Indicates the selection to use the dynamics 365 azure sync framework or server side sync.|
|DisplayName|Enable dynamics 365 azure sync framework for this organization.|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|syncoptinselection|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### SyncOptInSelection Options

|Value|Label|
|-----|-----|
|1|Enable|
|0|Disable|

**DefaultValue**: False



### <a name="BKMK_SyncOptInSelectionStatus"></a> SyncOptInSelectionStatus

|Property|Value|
|--------|-----|
|Description|Indicates the status of the opt-in or opt-out operation for dynamics 365 azure sync.|
|DisplayName|Status of opt-in or opt-out operation for dynamics 365 azure sync.|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|syncoptinselectionstatus|
|RequiredLevel|None|
|Type|Picklist|

#### SyncOptInSelectionStatus Options

|Value|Label|
|-----|-----|
|1|Processing|
|2|Passed|
|3|Failed|



### <a name="BKMK_SystemUserId"></a> SystemUserId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the system user for the organization.|
|DisplayName|System User|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|systemuserid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_TagMaxAggressiveCycles"></a> TagMaxAggressiveCycles

|Property|Value|
|--------|-----|
|Description|Maximum number of aggressive polling cycles executed for email auto-tagging when a new email is received.|
|DisplayName|Auto-Tag Max Cycles|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|tagmaxaggressivecycles|
|MaxValue||
|MinValue||
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_TagPollingPeriod"></a> TagPollingPeriod

|Property|Value|
|--------|-----|
|Description|Normal polling frequency used for email receive auto-tagging in outlook.|
|DisplayName|Auto-Tag Interval|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|tagpollingperiod|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_TaskBasedFlowEnabled"></a> TaskBasedFlowEnabled

|Property|Value|
|--------|-----|
|Description|Select whether to turn on task flows for the organization.|
|DisplayName|Enable Task Flow processes for this Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|taskbasedflowenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### TaskBasedFlowEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_TextAnalyticsEnabled"></a> TextAnalyticsEnabled

|Property|Value|
|--------|-----|
|Description|Select whether to turn on text analytics for the organization.|
|DisplayName|Enable Text Analytics for this Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|textanalyticsenabled|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### TextAnalyticsEnabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_TimeFormatCode"></a> TimeFormatCode

|Property|Value|
|--------|-----|
|Description|Information that specifies how the time is displayed throughout Microsoft CRM.|
|DisplayName|Time Format Code|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timeformatcode|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### TimeFormatCode Options

| Value | Label |
|-------|-------|
|       |       |

### <a name="BKMK_TimeFormatString"></a> TimeFormatString

|Property|Value|
|--------|-----|
|Description|Text for how time is displayed in Microsoft Dynamics 365.|
|DisplayName|Time Format String|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timeformatstring|
|MaxLength|255|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TimeSeparator"></a> TimeSeparator

|Property|Value|
|--------|-----|
|Description|Text for how the time separator is displayed throughout Microsoft Dynamics 365.|
|DisplayName|Time Separator|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timeseparator|
|MaxLength|5|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TimeZoneRuleVersionNumber"></a> TimeZoneRuleVersionNumber

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Time Zone Rule Version Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|timezoneruleversionnumber|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_TokenExpiry"></a> TokenExpiry

|Property|Value|
|--------|-----|
|Description|Duration used for token expiration.|
|DisplayName|Token Expiration Duration|
|Format|None|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|tokenexpiry|
|MaxValue||
|MinValue||
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_TokenKey"></a> TokenKey

|Property|Value|
|--------|-----|
|Description|Token key.|
|DisplayName|Token Key|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|tokenkey|
|MaxLength|90|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TrackingPrefix"></a> TrackingPrefix

|Property|Value|
|--------|-----|
|Description|History list of tracking token prefixes.|
|DisplayName|Tracking Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|trackingprefix|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_TrackingTokenIdBase"></a> TrackingTokenIdBase

|Property|Value|
|--------|-----|
|Description|Base number used to provide separate tracking token identifiers to users belonging to different deployments.|
|DisplayName|Tracking Token Base|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|trackingtokenidbase|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_TrackingTokenIdDigits"></a> TrackingTokenIdDigits

|Property|Value|
|--------|-----|
|Description|Number of digits used to represent a tracking token identifier.|
|DisplayName|Tracking Token Digits|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|trackingtokeniddigits|
|MaxValue||
|MinValue||
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_UniqueSpecifierLength"></a> UniqueSpecifierLength

|Property|Value|
|--------|-----|
|Description|Number of characters appended to invoice, quote, and order numbers.|
|DisplayName|Unique String Length|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|uniquespecifierlength|
|MaxValue|6|
|MinValue|4|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_UnresolveEmailAddressIfMultipleMatch"></a> UnresolveEmailAddressIfMultipleMatch

|Property|Value|
|--------|-----|
|Description|Indicates whether email address should be unresolved if multiple matches are found|
|DisplayName|Set To,cc,bcc fields as unresolved if multiple matches are found|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|unresolveemailaddressifmultiplematch|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### UnresolveEmailAddressIfMultipleMatch Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_UseInbuiltRuleForDefaultPricelistSelection"></a> UseInbuiltRuleForDefaultPricelistSelection

|Property|Value|
|--------|-----|
|Description|Flag indicates whether to Use Inbuilt Rule For DefaultPricelist.|
|DisplayName|Use Inbuilt Rule For Default Pricelist Selection|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|useinbuiltrulefordefaultpricelistselection|
|RequiredLevel|None|
|Type|Boolean|

#### UseInbuiltRuleForDefaultPricelistSelection Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_UseLegacyRendering"></a> UseLegacyRendering

|Property|Value|
|--------|-----|
|Description|Select whether to use legacy form rendering.|
|DisplayName|Legacy Form Rendering|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|uselegacyrendering|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### UseLegacyRendering Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_UsePositionHierarchy"></a> UsePositionHierarchy

|Property|Value|
|--------|-----|
|Description|Use position hierarchy|
|DisplayName|Use position hierarchy|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|usepositionhierarchy|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### UsePositionHierarchy Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_UserAccessAuditingInterval"></a> UserAccessAuditingInterval

|Property|Value|
|--------|-----|
|Description|The interval at which user access is checked for auditing.|
|DisplayName|User Authentication Auditing Interval|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|useraccessauditinginterval|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_UseReadForm"></a> UseReadForm

|Property|Value|
|--------|-----|
|Description|Indicates whether the read-optimized form should be enabled for this organization.|
|DisplayName|Use Read-Optimized Form|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|usereadform|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### UseReadForm Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_UserGroupId"></a> UserGroupId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the default group of users in the organization.|
|DisplayName|User Group|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|usergroupid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_UseSkypeProtocol"></a> UseSkypeProtocol

|Property|Value|
|--------|-----|
|Description|Indicates default protocol selected for organization.|
|DisplayName|User Skype Protocol|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|useskypeprotocol|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### UseSkypeProtocol Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: True



### <a name="BKMK_UTCConversionTimeZoneCode"></a> UTCConversionTimeZoneCode

|Property|Value|
|--------|-----|
|Description|Time zone code that was in use when the record was created.|
|DisplayName|UTC Conversion Time Zone Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|utcconversiontimezonecode|
|MaxValue|2147483647|
|MinValue|-1|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_WebResourceHash"></a> WebResourceHash

|Property|Value|
|--------|-----|
|Description|Hash value of web resources.|
|DisplayName|Web resource hash|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|webresourcehash|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_WeekStartDayCode"></a> WeekStartDayCode

|Property|Value|
|--------|-----|
|Description|Designated first day of the week throughout Microsoft Dynamics 365.|
|DisplayName|Week Start Day Code|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|weekstartdaycode|
|RequiredLevel|SystemRequired|
|Type|Picklist|

#### WeekStartDayCode Options

| Value | Label |
|-------|-------|
|       |       |

### <a name="BKMK_WidgetProperties"></a> WidgetProperties

|Property|Value|
|--------|-----|
|Description|For Internal use only.|
|DisplayName|For Internal use only.|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|widgetproperties|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_YammerGroupId"></a> YammerGroupId

|Property|Value|
|--------|-----|
|Description|Denotes the Yammer group ID|
|DisplayName|Yammer Group Id|
|Format|None|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|yammergroupid|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|None|
|Type|Integer|


### <a name="BKMK_YammerNetworkPermalink"></a> YammerNetworkPermalink

|Property|Value|
|--------|-----|
|Description|Denotes the Yammer network permalink|
|DisplayName|Yammer Network Permalink|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|yammernetworkpermalink|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_YammerOAuthAccessTokenExpired"></a> YammerOAuthAccessTokenExpired

|Property|Value|
|--------|-----|
|Description|Denotes whether the OAuth access token for Yammer network has expired|
|DisplayName|Yammer OAuth Access Token Expired|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|yammeroauthaccesstokenexpired|
|RequiredLevel|None|
|Type|Boolean|

#### YammerOAuthAccessTokenExpired Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_YammerPostMethod"></a> YammerPostMethod

|Property|Value|
|--------|-----|
|Description|Internal Use Only|
|DisplayName|Internal Use Only|
|IsValidForCreate|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|yammerpostmethod|
|RequiredLevel|None|
|Type|Picklist|

#### YammerPostMethod Options

|Value|Label|
|-----|-----|
|0|Public|
|1|Private|



### <a name="BKMK_YearStartWeekCode"></a> YearStartWeekCode

|Property|Value|
|--------|-----|
|Description|Information that specifies how the first week of the year is specified in Microsoft Dynamics 365.|
|DisplayName|Year Start Week Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|yearstartweekcode|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|

<a name="read-only-attributes"></a>
## Read-only attributes
These attributes return false for both **IsValidForCreate** or **IsValidForUpdate**. Listed by **SchemaName**.

- [AcknowledgementTemplateIdName](#BKMK_AcknowledgementTemplateIdName)
- [BaseCurrencyIdName](#BKMK_BaseCurrencyIdName)
- [BaseCurrencyPrecision](#BKMK_BaseCurrencyPrecision)
- [BaseCurrencySymbol](#BKMK_BaseCurrencySymbol)
- [BaseISOCurrencyCode](#BKMK_BaseISOCurrencyCode)
- [CreatedBy](#BKMK_CreatedBy)
- [CreatedByName](#BKMK_CreatedByName)
- [CreatedByYomiName](#BKMK_CreatedByYomiName)
- [CreatedOn](#BKMK_CreatedOn)
- [CreatedOnBehalfBy](#BKMK_CreatedOnBehalfBy)
- [CreatedOnBehalfByName](#BKMK_CreatedOnBehalfByName)
- [CreatedOnBehalfByYomiName](#BKMK_CreatedOnBehalfByYomiName)
- [CurrentImportSequenceNumber](#BKMK_CurrentImportSequenceNumber)
- [CurrentParsedTableNumber](#BKMK_CurrentParsedTableNumber)
- [DaysSinceRecordLastModifiedMaxValue](#BKMK_DaysSinceRecordLastModifiedMaxValue)
- [DefaultEmailServerProfileIdName](#BKMK_DefaultEmailServerProfileIdName)
- [DefaultMobileOfflineProfileIdName](#BKMK_DefaultMobileOfflineProfileIdName)
- [DisabledReason](#BKMK_DisabledReason)
- [EntityImage_Timestamp](#BKMK_EntityImage_Timestamp)
- [EntityImage_URL](#BKMK_EntityImage_URL)
- [EntityImageId](#BKMK_EntityImageId)
- [FiscalSettingsUpdated](#BKMK_FiscalSettingsUpdated)
- [IsDisabled](#BKMK_IsDisabled)
- [MaxSupportedInternetExplorerVersion](#BKMK_MaxSupportedInternetExplorerVersion)
- [MaxVerboseLoggingMailbox](#BKMK_MaxVerboseLoggingMailbox)
- [MaxVerboseLoggingSyncCycles](#BKMK_MaxVerboseLoggingSyncCycles)
- [MetadataSyncLastTimeOfNeverExpiredDeletedObjects](#BKMK_MetadataSyncLastTimeOfNeverExpiredDeletedObjects)
- [MetadataSyncTimestamp](#BKMK_MetadataSyncTimestamp)
- [MobileOfflineMinLicenseProd](#BKMK_MobileOfflineMinLicenseProd)
- [MobileOfflineMinLicenseTrial](#BKMK_MobileOfflineMinLicenseTrial)
- [ModifiedBy](#BKMK_ModifiedBy)
- [ModifiedByName](#BKMK_ModifiedByName)
- [ModifiedByYomiName](#BKMK_ModifiedByYomiName)
- [ModifiedOn](#BKMK_ModifiedOn)
- [ModifiedOnBehalfBy](#BKMK_ModifiedOnBehalfBy)
- [ModifiedOnBehalfByName](#BKMK_ModifiedOnBehalfByName)
- [ModifiedOnBehalfByYomiName](#BKMK_ModifiedOnBehalfByYomiName)
- [NextCustomObjectTypeCode](#BKMK_NextCustomObjectTypeCode)
- [OrganizationId](#BKMK_OrganizationId)
- [OrganizationState](#BKMK_OrganizationState)
- [ParsedTableColumnPrefix](#BKMK_ParsedTableColumnPrefix)
- [ParsedTablePrefix](#BKMK_ParsedTablePrefix)
- [V3CalloutConfigHash](#BKMK_V3CalloutConfigHash)
- [VersionNumber](#BKMK_VersionNumber)


### <a name="BKMK_AcknowledgementTemplateIdName"></a> AcknowledgementTemplateIdName

|Property|Value|
|--------|-----|
|Description|Name of the template to be used for unsubscription acknowledgement.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|acknowledgementtemplateidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_BaseCurrencyIdName"></a> BaseCurrencyIdName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|basecurrencyidname|
|MaxLength|100|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_BaseCurrencyPrecision"></a> BaseCurrencyPrecision

|Property|Value|
|--------|-----|
|Description|Number of decimal places that can be used for the base currency.|
|DisplayName|Base Currency Precision|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|basecurrencyprecision|
|MaxValue|4|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_BaseCurrencySymbol"></a> BaseCurrencySymbol

|Property|Value|
|--------|-----|
|Description|Symbol used for the base currency.|
|DisplayName|Base Currency Symbol|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|basecurrencysymbol|
|MaxLength|5|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_BaseISOCurrencyCode"></a> BaseISOCurrencyCode

|Property|Value|
|--------|-----|
|Description||
|DisplayName|Base ISO Currency Code|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|baseisocurrencycode|
|MaxLength|5|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_CreatedBy"></a> CreatedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who created the organization.|
|DisplayName|Created By|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedByName"></a> CreatedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedByYomiName"></a> CreatedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOn"></a> CreatedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the organization was created.|
|DisplayName|Created On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_CreatedOnBehalfBy"></a> CreatedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who created the organization.|
|DisplayName|Created By (Delegate)|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_CreatedOnBehalfByName"></a> CreatedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CreatedOnBehalfByYomiName"></a> CreatedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|createdonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_CurrentImportSequenceNumber"></a> CurrentImportSequenceNumber

|Property|Value|
|--------|-----|
|Description|Import sequence to use.|
|DisplayName|Current Import Sequence Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|currentimportsequencenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_CurrentParsedTableNumber"></a> CurrentParsedTableNumber

|Property|Value|
|--------|-----|
|Description|First parsed table number to use.|
|DisplayName|Current Parsed Table Number|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|currentparsedtablenumber|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_DaysSinceRecordLastModifiedMaxValue"></a> DaysSinceRecordLastModifiedMaxValue

|Property|Value|
|--------|-----|
|Description|The maximum value for the Mobile Offline setting Days since record last modified|
|DisplayName|Max value of Days since record last modified|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|dayssincerecordlastmodifiedmaxvalue|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_DefaultEmailServerProfileIdName"></a> DefaultEmailServerProfileIdName

|Property|Value|
|--------|-----|
|Description|Name of the email server profile to be used as default profile for the mailboxes.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|defaultemailserverprofileidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_DefaultMobileOfflineProfileIdName"></a> DefaultMobileOfflineProfileIdName

|Property|Value|
|--------|-----|
|Description|Name of the default mobile offline profile to be used as default profile for mobile offline.|
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|defaultmobileofflineprofileidname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_DisabledReason"></a> DisabledReason

|Property|Value|
|--------|-----|
|Description|Reason for disabling the organization.|
|DisplayName|Disabled Reason|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|disabledreason|
|MaxLength|500|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EntityImage_Timestamp"></a> EntityImage_Timestamp

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage_timestamp|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|


### <a name="BKMK_EntityImage_URL"></a> EntityImage_URL

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Url|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimage_url|
|MaxLength|200|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_EntityImageId"></a> EntityImageId

|Property|Value|
|--------|-----|
|Description|For internal use only.|
|DisplayName|Entity Image Id|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|entityimageid|
|RequiredLevel|None|
|Type|Uniqueidentifier|


### <a name="BKMK_FiscalSettingsUpdated"></a> FiscalSettingsUpdated

|Property|Value|
|--------|-----|
|Description|Information that specifies whether the fiscal settings have been updated.|
|DisplayName|Is Fiscal Settings Updated|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|fiscalsettingsupdated|
|RequiredLevel|SystemRequired|
|Type|Boolean|

#### FiscalSettingsUpdated Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_IsDisabled"></a> IsDisabled

|Property|Value|
|--------|-----|
|Description|Information that specifies whether the organization is disabled.|
|DisplayName|Is Organization Disabled|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|isdisabled|
|RequiredLevel|None|
|Type|Boolean|

#### IsDisabled Options

|Value|Label|
|-----|-----|
|1|Yes|
|0|No|

**DefaultValue**: False



### <a name="BKMK_MaxSupportedInternetExplorerVersion"></a> MaxSupportedInternetExplorerVersion

|Property|Value|
|--------|-----|
|Description|The maximum version of IE to run browser emulation for in Outlook client|
|DisplayName|Max supported IE version|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|maxsupportedinternetexplorerversion|
|MaxValue|2147483647|
|MinValue|0|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_MaxVerboseLoggingMailbox"></a> MaxVerboseLoggingMailbox

|Property|Value|
|--------|-----|
|Description|Maximum number of mailboxes that can be toggled for verbose logging|
|DisplayName|Max No Of Mailboxes To Enable For Verbose Logging|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|maxverboseloggingmailbox|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_MaxVerboseLoggingSyncCycles"></a> MaxVerboseLoggingSyncCycles

|Property|Value|
|--------|-----|
|Description|Maximum number of sync cycles for which verbose logging will be enabled by default|
|DisplayName|Maximum number of sync cycles for which verbose logging will be enabled by default|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|maxverboseloggingsynccycles|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_MetadataSyncLastTimeOfNeverExpiredDeletedObjects"></a> MetadataSyncLastTimeOfNeverExpiredDeletedObjects

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|What is the last date/time where there are metadata tracking deleted objects that have never been outside of the expiration period.|
|DisplayName|The last date/time for never expired metadata tracking deleted objects|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|metadatasynclasttimeofneverexpireddeletedobjects|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_MetadataSyncTimestamp"></a> MetadataSyncTimestamp

|Property|Value|
|--------|-----|
|Description|Contains the maximum version number for attributes used by metadata synchronization that have changed.|
|DisplayName|Metadata sync version|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|metadatasynctimestamp|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|SystemRequired|
|Type|BigInt|


### <a name="BKMK_MobileOfflineMinLicenseProd"></a> MobileOfflineMinLicenseProd

|Property|Value|
|--------|-----|
|Description|Minimum number of user license required for mobile offline service by production/preview organization|
|DisplayName|Minimum number of user license required for mobile offline service by production/preview organization|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|mobileofflineminlicenseprod|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_MobileOfflineMinLicenseTrial"></a> MobileOfflineMinLicenseTrial

|Property|Value|
|--------|-----|
|Description|Minimum number of user license required for mobile offline service by trial organization|
|DisplayName|Minimum number of user license required for mobile offline service by trial organization|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|mobileofflineminlicensetrial|
|MaxValue|2147483647|
|MinValue|-2147483648|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_ModifiedBy"></a> ModifiedBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the user who last modified the organization.|
|DisplayName|Modified By|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedByName"></a> ModifiedByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedByYomiName"></a> ModifiedByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOn"></a> ModifiedOn

|Property|Value|
|--------|-----|
|DateTimeBehavior|UserLocal|
|Description|Date and time when the organization was last modified.|
|DisplayName|Modified On|
|Format|DateAndTime|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedon|
|RequiredLevel|None|
|Type|DateTime|


### <a name="BKMK_ModifiedOnBehalfBy"></a> ModifiedOnBehalfBy

|Property|Value|
|--------|-----|
|Description|Unique identifier of the delegate user who last modified the organization.|
|DisplayName|Modified By (Delegate)|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfby|
|RequiredLevel|None|
|Targets|systemuser|
|Type|Lookup|


### <a name="BKMK_ModifiedOnBehalfByName"></a> ModifiedOnBehalfByName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyname|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_ModifiedOnBehalfByYomiName"></a> ModifiedOnBehalfByYomiName

|Property|Value|
|--------|-----|
|Description||
|DisplayName||
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|modifiedonbehalfbyyominame|
|MaxLength|100|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_NextCustomObjectTypeCode"></a> NextCustomObjectTypeCode

|Property|Value|
|--------|-----|
|Description|Next entity type code to use for custom entities.|
|DisplayName|Next Entity Type Code|
|Format|None|
|IsValidForForm|False|
|IsValidForRead|False|
|LogicalName|nextcustomobjecttypecode|
|MaxValue|2147483647|
|MinValue|10000|
|RequiredLevel|SystemRequired|
|Type|Integer|


### <a name="BKMK_OrganizationId"></a> OrganizationId

|Property|Value|
|--------|-----|
|Description|Unique identifier of the organization.|
|DisplayName|Organization|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationid|
|RequiredLevel|SystemRequired|
|Type|Uniqueidentifier|


### <a name="BKMK_OrganizationState"></a> OrganizationState

|Property|Value|
|--------|-----|
|Description|Indicates the organization lifecycle state|
|DisplayName|Organization State|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|organizationstate|
|RequiredLevel|None|
|Type|Picklist|

#### OrganizationState Options

|Value|Label|
|-----|-----|
|0|Creating|
|1|Upgrading|
|2|Updating|
|3|Active|



### <a name="BKMK_ParsedTableColumnPrefix"></a> ParsedTableColumnPrefix

|Property|Value|
|--------|-----|
|Description|Prefix used for parsed table columns.|
|DisplayName|Parsed Table Column Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parsedtablecolumnprefix|
|MaxLength|20|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_ParsedTablePrefix"></a> ParsedTablePrefix

|Property|Value|
|--------|-----|
|Description|Prefix used for parsed tables.|
|DisplayName|Parsed Table Prefix|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|parsedtableprefix|
|MaxLength|20|
|RequiredLevel|SystemRequired|
|Type|String|


### <a name="BKMK_V3CalloutConfigHash"></a> V3CalloutConfigHash

|Property|Value|
|--------|-----|
|Description|Hash of the V3 callout configuration file.|
|DisplayName|V3 Callout Hash|
|FormatName|Text|
|IsLocalizable|False|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|v3calloutconfighash|
|MaxLength|256|
|RequiredLevel|None|
|Type|String|


### <a name="BKMK_VersionNumber"></a> VersionNumber

|Property|Value|
|--------|-----|
|Description|Version number of the organization.|
|DisplayName|Version Number|
|IsValidForForm|False|
|IsValidForRead|True|
|LogicalName|versionnumber|
|MaxValue|9223372036854775807|
|MinValue|-9223372036854775808|
|RequiredLevel|None|
|Type|BigInt|

<a name="onetomany"></a>

## One-To-Many Relationships

Listed by **SchemaName**.

- [organization_territories](#BKMK_organization_territories)
- [dynamicproperty_organization](#BKMK_dynamicproperty_organization)
- [DynamicPropertyAssociation_organization](#BKMK_DynamicPropertyAssociation_organization)
- [DynamicPropertyOptionSetItem_organization](#BKMK_DynamicPropertyOptionSetItem_organization)
- [organization_price_levels](#BKMK_organization_price_levels)
- [organization_products](#BKMK_organization_products)
- [organization_ProductAssociation](#BKMK_organization_ProductAssociation)
- [organization_ProductSubstitute](#BKMK_organization_ProductSubstitute)
- [organization_uof_schedules](#BKMK_organization_uof_schedules)
- [organization_contract_templates](#BKMK_organization_contract_templates)
- [entitlementtemplate_organization](#BKMK_entitlementtemplate_organization)
- [organization_phonetocaseprocess](#BKMK_organization_phonetocaseprocess)
- [organization_services](#BKMK_organization_services)
- [organization_topicmodel](#BKMK_organization_topicmodel)
- [organization_topicmodelconfiguration](#BKMK_organization_topicmodelconfiguration)
- [organization_topicmodelexecutionhistory](#BKMK_organization_topicmodelexecutionhistory)
- [organization_sites](#BKMK_organization_sites)
- [organization_constraint_based_groups](#BKMK_organization_constraint_based_groups)
- [organization_equipment](#BKMK_organization_equipment)
- [organization_resources](#BKMK_organization_resources)
- [organization_resource_groups](#BKMK_organization_resource_groups)
- [organization_resource_specs](#BKMK_organization_resource_specs)
- [entitlementchannel_organization](#BKMK_entitlementchannel_organization)
- [entitlementtemplatechannel_organization](#BKMK_entitlementtemplatechannel_organization)
- [organization_discount_types](#BKMK_organization_discount_types)
- [organization_leadtoopportunitysalesprocess](#BKMK_organization_leadtoopportunitysalesprocess)
- [organization_opportunitysalesprocess](#BKMK_organization_opportunitysalesprocess)
- [organization_sales_literature](#BKMK_organization_sales_literature)
- [organization_competitors](#BKMK_organization_competitors)
- [organization_msdyn_postconfig](#BKMK_organization_msdyn_postconfig)
- [organization_msdyn_postruleconfig](#BKMK_organization_msdyn_postruleconfig)
- [organization_msdyn_wallsavedquery](#BKMK_organization_msdyn_wallsavedquery)
- [organization_msdyn_organizationalunit](#BKMK_organization_msdyn_organizationalunit)
- [organization_msdyn_schedulingparameter](#BKMK_organization_msdyn_schedulingparameter)
- [organization_msdyn_batchjob](#BKMK_organization_msdyn_batchjob)
- [organization_msdyn_bpf_665e73aa18c247d886bfc50499c73b82](#BKMK_organization_msdyn_bpf_665e73aa18c247d886bfc50499c73b82)
- [organization_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d](#BKMK_organization_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d)
- [organization_msdyn_contractlineinvoiceschedule](#BKMK_organization_msdyn_contractlineinvoiceschedule)
- [organization_msdyn_expensecategory](#BKMK_organization_msdyn_expensecategory)
- [organization_msdyn_invoicefrequency](#BKMK_organization_msdyn_invoicefrequency)
- [organization_msdyn_invoicefrequencydetail](#BKMK_organization_msdyn_invoicefrequencydetail)
- [organization_msdyn_mlresultcache](#BKMK_organization_msdyn_mlresultcache)
- [organization_msdyn_processnotes](#BKMK_organization_msdyn_processnotes)
- [organization_msdyn_projectparameter](#BKMK_organization_msdyn_projectparameter)
- [organization_msdyn_projectparameterpricelist](#BKMK_organization_msdyn_projectparameterpricelist)
- [organization_msdyn_projectteammembersignup](#BKMK_organization_msdyn_projectteammembersignup)
- [organization_msdyn_quotelineinvoiceschedule](#BKMK_organization_msdyn_quotelineinvoiceschedule)
- [organization_msdyn_resourcecategorypricelevel](#BKMK_organization_msdyn_resourcecategorypricelevel)
- [organization_msdyn_transactioncategory](#BKMK_organization_msdyn_transactioncategory)
- [organization_msdyn_transactioncategoryclassification](#BKMK_organization_msdyn_transactioncategoryclassification)
- [organization_msdyn_transactioncategoryhierarchyelement](#BKMK_organization_msdyn_transactioncategoryhierarchyelement)
- [organization_msdyn_transactioncategorypricelevel](#BKMK_organization_msdyn_transactioncategorypricelevel)
- [organization_msdyn_transactiontype](#BKMK_organization_msdyn_transactiontype)
- [organization_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799](#BKMK_organization_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799)
- [organization_msdyn_bpf_989e9b1857e24af18787d5143b67523b](#BKMK_organization_msdyn_bpf_989e9b1857e24af18787d5143b67523b)
- [organization_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](#BKMK_organization_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3)
- [organization_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39](#BKMK_organization_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39)
- [organization_msdyn_fieldservicepricelistitem](#BKMK_organization_msdyn_fieldservicepricelistitem)
- [organization_msdyn_fieldservicesystemjob](#BKMK_organization_msdyn_fieldservicesystemjob)
- [organization_msdyn_productinventory](#BKMK_organization_msdyn_productinventory)
- [organization_msdyn_uniquenumber](#BKMK_organization_msdyn_uniquenumber)
- [organization_msdyn_workorderdetailsgenerationqueue](#BKMK_organization_msdyn_workorderdetailsgenerationqueue)
- [organization_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b](#BKMK_organization_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b)
- [lk_principalobjectattributeaccess_organizationid](#BKMK_lk_principalobjectattributeaccess_organizationid)
- [organization_theme](#BKMK_organization_theme)
- [organization_UserMapping](#BKMK_organization_UserMapping)
- [organization_suggestioncardtemplate](#BKMK_organization_suggestioncardtemplate)
- [organization_metric](#BKMK_organization_metric)
- [organization_position](#BKMK_organization_position)
- [organization_officegraphdocument](#BKMK_organization_officegraphdocument)
- [organization_delveactionhub](#BKMK_organization_delveactionhub)
- [organization_recommendeddocument](#BKMK_organization_recommendeddocument)
- [organization_KnowledgeBaseRecord](#BKMK_organization_KnowledgeBaseRecord)
- [organization_translationprocess](#BKMK_organization_translationprocess)
- [organization_orginsightsmetric](#BKMK_organization_orginsightsmetric)
- [organization_navigationsetting](#BKMK_organization_navigationsetting)
- [organization_plugintype](#BKMK_organization_plugintype)
- [organization_azureserviceconnection](#BKMK_organization_azureserviceconnection)
- [organization_sdkmessageresponse](#BKMK_organization_sdkmessageresponse)
- [organization_business_unit_news_articles](#BKMK_organization_business_unit_news_articles)
- [organization_saved_query_visualizations](#BKMK_organization_saved_query_visualizations)
- [customcontrolresource_organization](#BKMK_customcontrolresource_organization)
- [organization_post](#BKMK_organization_post)
- [organization_PostComment](#BKMK_organization_PostComment)
- [organization_postlike](#BKMK_organization_postlike)
- [organization_importjob](#BKMK_organization_importjob)
- [organization_licenses](#BKMK_organization_licenses)
- [organization_expanderevent](#BKMK_organization_expanderevent)
- [organization_ribbon_customization](#BKMK_organization_ribbon_customization)
- [organization_queues](#BKMK_organization_queues)
- [organization_sdkmessageprocessingstepimage](#BKMK_organization_sdkmessageprocessingstepimage)
- [organization_savedorginsightsconfiguration](#BKMK_organization_savedorginsightsconfiguration)
- [organization_plugintypestatistic](#BKMK_organization_plugintypestatistic)
- [MobileOfflineProfileItemAssociation_organization](#BKMK_MobileOfflineProfileItemAssociation_organization)
- [organization_relationship_roles](#BKMK_organization_relationship_roles)
- [organization_appmodule](#BKMK_organization_appmodule)
- [organization_sdkmessagepair](#BKMK_organization_sdkmessagepair)
- [organization_kb_articles](#BKMK_organization_kb_articles)
- [organization_systemforms](#BKMK_organization_systemforms)
- [organization_appconfig](#BKMK_organization_appconfig)
- [organization_sdkmessagerequestfield](#BKMK_organization_sdkmessagerequestfield)
- [organization_connection_roles](#BKMK_organization_connection_roles)
- [customcontrol_organization](#BKMK_customcontrol_organization)
- [userentityinstancedata_organization](#BKMK_userentityinstancedata_organization)
- [organization_subjects](#BKMK_organization_subjects)
- [organization_calendars](#BKMK_organization_calendars)
- [organization_publisher](#BKMK_organization_publisher)
- [organization_queueitems](#BKMK_organization_queueitems)
- [organization_teams](#BKMK_organization_teams)
- [organization_advancedsimilarityrule](#BKMK_organization_advancedsimilarityrule)
- [organization_socialinsightsconfiguration](#BKMK_organization_socialinsightsconfiguration)
- [organization_entitymap](#BKMK_organization_entitymap)
- [channelproperty_organization](#BKMK_channelproperty_organization)
- [organization_entitydataprovider](#BKMK_organization_entitydataprovider)
- [organization_sharepointdocument](#BKMK_organization_sharepointdocument)
- [webresource_organization](#BKMK_webresource_organization)
- [organization_textanalyticsentitymapping](#BKMK_organization_textanalyticsentitymapping)
- [MobileOfflineProfile_organization](#BKMK_MobileOfflineProfile_organization)
- [organization_transactioncurrencies](#BKMK_organization_transactioncurrencies)
- [organization_expiredprocess](#BKMK_organization_expiredprocess)
- [organization_mailbox](#BKMK_organization_mailbox)
- [lk_dataperformance_organizationid](#BKMK_lk_dataperformance_organizationid)
- [organization_isvconfigs](#BKMK_organization_isvconfigs)
- [organization_sharepointdata](#BKMK_organization_sharepointdata)
- [offlinecommanddefinition_organization](#BKMK_offlinecommanddefinition_organization)
- [MobileOfflineProfileItem_organization](#BKMK_MobileOfflineProfileItem_organization)
- [organization_custom_displaystrings](#BKMK_organization_custom_displaystrings)
- [Organization_SyncErrors](#BKMK_Organization_SyncErrors)
- [channelpropertygroup_organization](#BKMK_channelpropertygroup_organization)
- [organization_sdkmessagerequest](#BKMK_organization_sdkmessagerequest)
- [Organization_AsyncOperations](#BKMK_Organization_AsyncOperations)
- [customcontroldefaultconfig_organization](#BKMK_customcontroldefaultconfig_organization)
- [organization_sitemap](#BKMK_organization_sitemap)
- [Organization_MailboxTrackingFolder](#BKMK_Organization_MailboxTrackingFolder)
- [organization_emailserverprofile](#BKMK_organization_emailserverprofile)
- [lk_organizationui_organizationid](#BKMK_lk_organizationui_organizationid)
- [organization_pluginassembly](#BKMK_organization_pluginassembly)
- [organization_mailboxstatistics](#BKMK_organization_mailboxstatistics)
- [organization_knowledgesearchmodel](#BKMK_organization_knowledgesearchmodel)
- [Organization_BulkDeleteFailures](#BKMK_Organization_BulkDeleteFailures)
- [lk_fieldsecurityprofile_organizationid](#BKMK_lk_fieldsecurityprofile_organizationid)
- [organization_sdkmessagefilter](#BKMK_organization_sdkmessagefilter)
- [organization_kb_article_templates](#BKMK_organization_kb_article_templates)
- [organization_roles](#BKMK_organization_roles)
- [organization_sdkmessageprocessingstepsecureconfig](#BKMK_organization_sdkmessageprocessingstepsecureconfig)
- [organization_entitydatasource](#BKMK_organization_entitydatasource)
- [organization_aciviewmapper](#BKMK_organization_aciviewmapper)
- [organization_system_users](#BKMK_organization_system_users)
- [languagelocale_organization](#BKMK_languagelocale_organization)
- [organization_business_units](#BKMK_organization_business_units)
- [organization_sdkmessageresponsefield](#BKMK_organization_sdkmessageresponsefield)
- [organization_attributemap](#BKMK_organization_attributemap)
- [organization_newprocess](#BKMK_organization_newprocess)
- [organization_hierarchyrules](#BKMK_organization_hierarchyrules)
- [organization_sdkmessageprocessingstep](#BKMK_organization_sdkmessageprocessingstep)
- [organization_RoutingRules](#BKMK_organization_RoutingRules)
- [organization_orginsightsnotification](#BKMK_organization_orginsightsnotification)
- [organization_appconfiginstance](#BKMK_organization_appconfiginstance)
- [organization_routingruleitems](#BKMK_organization_routingruleitems)
- [lk_documenttemplatebase_organization](#BKMK_lk_documenttemplatebase_organization)
- [organization_serviceendpoint](#BKMK_organization_serviceendpoint)
- [organization_sdkmessage](#BKMK_organization_sdkmessage)
- [organization_appconfigmaster](#BKMK_organization_appconfigmaster)
- [organization_saved_queries](#BKMK_organization_saved_queries)
- [organization_tracelog](#BKMK_organization_tracelog)
- [organization_solution](#BKMK_organization_solution)


### <a name="BKMK_organization_territories"></a> organization_territories

Same as territory entity [organization_territories](territory.md#BKMK_organization_territories) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|territory|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_territories|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_dynamicproperty_organization"></a> dynamicproperty_organization

Same as dynamicproperty entity [dynamicproperty_organization](dynamicproperty.md#BKMK_dynamicproperty_organization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|dynamicproperty|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|dynamicproperty_organization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_DynamicPropertyAssociation_organization"></a> DynamicPropertyAssociation_organization

Same as dynamicpropertyassociation entity [DynamicPropertyAssociation_organization](dynamicpropertyassociation.md#BKMK_DynamicPropertyAssociation_organization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|dynamicpropertyassociation|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|DynamicPropertyAssociation_organization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_DynamicPropertyOptionSetItem_organization"></a> DynamicPropertyOptionSetItem_organization

Same as dynamicpropertyoptionsetitem entity [DynamicPropertyOptionSetItem_organization](dynamicpropertyoptionsetitem.md#BKMK_DynamicPropertyOptionSetItem_organization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|dynamicpropertyoptionsetitem|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|DynamicPropertyOptionSetItem_organization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_price_levels"></a> organization_price_levels

Same as pricelevel entity [organization_price_levels](pricelevel.md#BKMK_organization_price_levels) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|pricelevel|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_price_levels|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_products"></a> organization_products

Same as product entity [organization_products](product.md#BKMK_organization_products) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|product|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_products|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_ProductAssociation"></a> organization_ProductAssociation

Same as productassociation entity [organization_ProductAssociation](productassociation.md#BKMK_organization_ProductAssociation) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|productassociation|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_ProductAssociation|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_ProductSubstitute"></a> organization_ProductSubstitute

Same as productsubstitute entity [organization_ProductSubstitute](productsubstitute.md#BKMK_organization_ProductSubstitute) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|productsubstitute|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_ProductSubstitute|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_uof_schedules"></a> organization_uof_schedules

Same as uomschedule entity [organization_uof_schedules](uomschedule.md#BKMK_organization_uof_schedules) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|uomschedule|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_uof_schedules|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_contract_templates"></a> organization_contract_templates

Same as contracttemplate entity [organization_contract_templates](contracttemplate.md#BKMK_organization_contract_templates) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|contracttemplate|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_contract_templates|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementtemplate_organization"></a> entitlementtemplate_organization

Same as entitlementtemplate entity [entitlementtemplate_organization](entitlementtemplate.md#BKMK_entitlementtemplate_organization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|entitlementtemplate|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|entitlementtemplate_organization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_phonetocaseprocess"></a> organization_phonetocaseprocess

Same as phonetocaseprocess entity [organization_phonetocaseprocess](phonetocaseprocess.md#BKMK_organization_phonetocaseprocess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|phonetocaseprocess|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_phonetocaseprocess|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_services"></a> organization_services

Same as service entity [organization_services](service.md#BKMK_organization_services) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|service|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_services|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_topicmodel"></a> organization_topicmodel

Same as topicmodel entity [organization_topicmodel](topicmodel.md#BKMK_organization_topicmodel) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|topicmodel|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_topicmodel|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_topicmodelconfiguration"></a> organization_topicmodelconfiguration

Same as topicmodelconfiguration entity [organization_topicmodelconfiguration](topicmodelconfiguration.md#BKMK_organization_topicmodelconfiguration) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|topicmodelconfiguration|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_topicmodelconfiguration|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_topicmodelexecutionhistory"></a> organization_topicmodelexecutionhistory

Same as topicmodelexecutionhistory entity [organization_topicmodelexecutionhistory](topicmodelexecutionhistory.md#BKMK_organization_topicmodelexecutionhistory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|topicmodelexecutionhistory|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_topicmodelexecutionhistory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_sites"></a> organization_sites

Same as site entity [organization_sites](site.md#BKMK_organization_sites) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|site|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_sites|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_constraint_based_groups"></a> organization_constraint_based_groups

Same as constraintbasedgroup entity [organization_constraint_based_groups](constraintbasedgroup.md#BKMK_organization_constraint_based_groups) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|constraintbasedgroup|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_constraint_based_groups|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_equipment"></a> organization_equipment

Same as equipment entity [organization_equipment](equipment.md#BKMK_organization_equipment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|equipment|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_equipment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_resources"></a> organization_resources

Same as resource entity [organization_resources](resource.md#BKMK_organization_resources) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|resource|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_resources|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_resource_groups"></a> organization_resource_groups

Same as resourcegroup entity [organization_resource_groups](resourcegroup.md#BKMK_organization_resource_groups) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|resourcegroup|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_resource_groups|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_resource_specs"></a> organization_resource_specs

Same as resourcespec entity [organization_resource_specs](resourcespec.md#BKMK_organization_resource_specs) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|resourcespec|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_resource_specs|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementchannel_organization"></a> entitlementchannel_organization

Same as entitlementchannel entity [entitlementchannel_organization](entitlementchannel.md#BKMK_entitlementchannel_organization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|entitlementchannel|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|entitlementchannel_organization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_entitlementtemplatechannel_organization"></a> entitlementtemplatechannel_organization

Same as entitlementtemplatechannel entity [entitlementtemplatechannel_organization](entitlementtemplatechannel.md#BKMK_entitlementtemplatechannel_organization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|entitlementtemplatechannel|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|entitlementtemplatechannel_organization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_discount_types"></a> organization_discount_types

Same as discounttype entity [organization_discount_types](discounttype.md#BKMK_organization_discount_types) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|discounttype|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_discount_types|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_leadtoopportunitysalesprocess"></a> organization_leadtoopportunitysalesprocess

Same as leadtoopportunitysalesprocess entity [organization_leadtoopportunitysalesprocess](leadtoopportunitysalesprocess.md#BKMK_organization_leadtoopportunitysalesprocess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|leadtoopportunitysalesprocess|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_leadtoopportunitysalesprocess|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_opportunitysalesprocess"></a> organization_opportunitysalesprocess

Same as opportunitysalesprocess entity [organization_opportunitysalesprocess](opportunitysalesprocess.md#BKMK_organization_opportunitysalesprocess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|opportunitysalesprocess|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_opportunitysalesprocess|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_sales_literature"></a> organization_sales_literature

Same as salesliterature entity [organization_sales_literature](salesliterature.md#BKMK_organization_sales_literature) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|salesliterature|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_sales_literature|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_competitors"></a> organization_competitors

Same as competitor entity [organization_competitors](competitor.md#BKMK_organization_competitors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|competitor|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_competitors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_postconfig"></a> organization_msdyn_postconfig

Same as msdyn_postconfig entity [organization_msdyn_postconfig](msdyn_postconfig.md#BKMK_organization_msdyn_postconfig) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_postconfig|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_postconfig|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_postruleconfig"></a> organization_msdyn_postruleconfig

Same as msdyn_postruleconfig entity [organization_msdyn_postruleconfig](msdyn_postruleconfig.md#BKMK_organization_msdyn_postruleconfig) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_postruleconfig|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_postruleconfig|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_wallsavedquery"></a> organization_msdyn_wallsavedquery

Same as msdyn_wallsavedquery entity [organization_msdyn_wallsavedquery](msdyn_wallsavedquery.md#BKMK_organization_msdyn_wallsavedquery) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_wallsavedquery|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_wallsavedquery|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_organizationalunit"></a> organization_msdyn_organizationalunit

Same as msdyn_organizationalunit entity [organization_msdyn_organizationalunit](msdyn_organizationalunit.md#BKMK_organization_msdyn_organizationalunit) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_organizationalunit|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_organizationalunit|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_schedulingparameter"></a> organization_msdyn_schedulingparameter

Same as msdyn_schedulingparameter entity [organization_msdyn_schedulingparameter](msdyn_schedulingparameter.md#BKMK_organization_msdyn_schedulingparameter) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_schedulingparameter|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_schedulingparameter|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_batchjob"></a> organization_msdyn_batchjob

Same as msdyn_batchjob entity [organization_msdyn_batchjob](msdyn_batchjob.md#BKMK_organization_msdyn_batchjob) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_batchjob|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_batchjob|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_bpf_665e73aa18c247d886bfc50499c73b82"></a> organization_msdyn_bpf_665e73aa18c247d886bfc50499c73b82

Same as msdyn_bpf_665e73aa18c247d886bfc50499c73b82 entity [organization_msdyn_bpf_665e73aa18c247d886bfc50499c73b82](msdyn_bpf_665e73aa18c247d886bfc50499c73b82.md#BKMK_organization_msdyn_bpf_665e73aa18c247d886bfc50499c73b82) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_665e73aa18c247d886bfc50499c73b82|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_bpf_665e73aa18c247d886bfc50499c73b82|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d"></a> organization_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d

Same as msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d entity [organization_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d](msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d.md#BKMK_organization_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_bpf_d8f9dc7f099f44db9d641dd81fbd470d|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_contractlineinvoiceschedule"></a> organization_msdyn_contractlineinvoiceschedule

Same as msdyn_contractlineinvoiceschedule entity [organization_msdyn_contractlineinvoiceschedule](msdyn_contractlineinvoiceschedule.md#BKMK_organization_msdyn_contractlineinvoiceschedule) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_contractlineinvoiceschedule|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_contractlineinvoiceschedule|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_expensecategory"></a> organization_msdyn_expensecategory

Same as msdyn_expensecategory entity [organization_msdyn_expensecategory](msdyn_expensecategory.md#BKMK_organization_msdyn_expensecategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_expensecategory|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_expensecategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_invoicefrequency"></a> organization_msdyn_invoicefrequency

Same as msdyn_invoicefrequency entity [organization_msdyn_invoicefrequency](msdyn_invoicefrequency.md#BKMK_organization_msdyn_invoicefrequency) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_invoicefrequency|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_invoicefrequency|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_invoicefrequencydetail"></a> organization_msdyn_invoicefrequencydetail

Same as msdyn_invoicefrequencydetail entity [organization_msdyn_invoicefrequencydetail](msdyn_invoicefrequencydetail.md#BKMK_organization_msdyn_invoicefrequencydetail) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_invoicefrequencydetail|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_invoicefrequencydetail|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_mlresultcache"></a> organization_msdyn_mlresultcache

Same as msdyn_mlresultcache entity [organization_msdyn_mlresultcache](msdyn_mlresultcache.md#BKMK_organization_msdyn_mlresultcache) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_mlresultcache|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_mlresultcache|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_processnotes"></a> organization_msdyn_processnotes

Same as msdyn_processnotes entity [organization_msdyn_processnotes](msdyn_processnotes.md#BKMK_organization_msdyn_processnotes) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_processnotes|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_processnotes|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_projectparameter"></a> organization_msdyn_projectparameter

Same as msdyn_projectparameter entity [organization_msdyn_projectparameter](msdyn_projectparameter.md#BKMK_organization_msdyn_projectparameter) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectparameter|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_projectparameter|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_projectparameterpricelist"></a> organization_msdyn_projectparameterpricelist

Same as msdyn_projectparameterpricelist entity [organization_msdyn_projectparameterpricelist](msdyn_projectparameterpricelist.md#BKMK_organization_msdyn_projectparameterpricelist) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectparameterpricelist|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_projectparameterpricelist|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_projectteammembersignup"></a> organization_msdyn_projectteammembersignup

Same as msdyn_projectteammembersignup entity [organization_msdyn_projectteammembersignup](msdyn_projectteammembersignup.md#BKMK_organization_msdyn_projectteammembersignup) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_projectteammembersignup|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_projectteammembersignup|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_quotelineinvoiceschedule"></a> organization_msdyn_quotelineinvoiceschedule

Same as msdyn_quotelineinvoiceschedule entity [organization_msdyn_quotelineinvoiceschedule](msdyn_quotelineinvoiceschedule.md#BKMK_organization_msdyn_quotelineinvoiceschedule) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_quotelineinvoiceschedule|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_quotelineinvoiceschedule|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_resourcecategorypricelevel"></a> organization_msdyn_resourcecategorypricelevel

Same as msdyn_resourcecategorypricelevel entity [organization_msdyn_resourcecategorypricelevel](msdyn_resourcecategorypricelevel.md#BKMK_organization_msdyn_resourcecategorypricelevel) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_resourcecategorypricelevel|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_resourcecategorypricelevel|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_transactioncategory"></a> organization_msdyn_transactioncategory

Same as msdyn_transactioncategory entity [organization_msdyn_transactioncategory](msdyn_transactioncategory.md#BKMK_organization_msdyn_transactioncategory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactioncategory|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_transactioncategory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_transactioncategoryclassification"></a> organization_msdyn_transactioncategoryclassification

Same as msdyn_transactioncategoryclassification entity [organization_msdyn_transactioncategoryclassification](msdyn_transactioncategoryclassification.md#BKMK_organization_msdyn_transactioncategoryclassification) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactioncategoryclassification|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_transactioncategoryclassification|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_transactioncategoryhierarchyelement"></a> organization_msdyn_transactioncategoryhierarchyelement

Same as msdyn_transactioncategoryhierarchyelement entity [organization_msdyn_transactioncategoryhierarchyelement](msdyn_transactioncategoryhierarchyelement.md#BKMK_organization_msdyn_transactioncategoryhierarchyelement) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactioncategoryhierarchyelement|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_transactioncategoryhierarchyelement|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_transactioncategorypricelevel"></a> organization_msdyn_transactioncategorypricelevel

Same as msdyn_transactioncategorypricelevel entity [organization_msdyn_transactioncategorypricelevel](msdyn_transactioncategorypricelevel.md#BKMK_organization_msdyn_transactioncategorypricelevel) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactioncategorypricelevel|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_transactioncategorypricelevel|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_transactiontype"></a> organization_msdyn_transactiontype

Same as msdyn_transactiontype entity [organization_msdyn_transactiontype](msdyn_transactiontype.md#BKMK_organization_msdyn_transactiontype) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_transactiontype|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_transactiontype|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799"></a> organization_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799

Same as msdyn_bpf_2c5fe86acc8b414b8322ae571000c799 entity [organization_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799](msdyn_bpf_2c5fe86acc8b414b8322ae571000c799.md#BKMK_organization_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_2c5fe86acc8b414b8322ae571000c799|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_bpf_2c5fe86acc8b414b8322ae571000c799|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_bpf_989e9b1857e24af18787d5143b67523b"></a> organization_msdyn_bpf_989e9b1857e24af18787d5143b67523b

Same as msdyn_bpf_989e9b1857e24af18787d5143b67523b entity [organization_msdyn_bpf_989e9b1857e24af18787d5143b67523b](msdyn_bpf_989e9b1857e24af18787d5143b67523b.md#BKMK_organization_msdyn_bpf_989e9b1857e24af18787d5143b67523b) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_989e9b1857e24af18787d5143b67523b|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_bpf_989e9b1857e24af18787d5143b67523b|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3"></a> organization_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3

Same as msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3 entity [organization_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3](msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3.md#BKMK_organization_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_bpf_baa0a411a239410cb8bded8b5fdd88e3|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39"></a> organization_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39

Same as msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39 entity [organization_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39](msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39.md#BKMK_organization_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_bpf_d3d97bac8c294105840e99e37a9d1c39|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_fieldservicepricelistitem"></a> organization_msdyn_fieldservicepricelistitem

Same as msdyn_fieldservicepricelistitem entity [organization_msdyn_fieldservicepricelistitem](msdyn_fieldservicepricelistitem.md#BKMK_organization_msdyn_fieldservicepricelistitem) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fieldservicepricelistitem|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_fieldservicepricelistitem|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_fieldservicesystemjob"></a> organization_msdyn_fieldservicesystemjob

Same as msdyn_fieldservicesystemjob entity [organization_msdyn_fieldservicesystemjob](msdyn_fieldservicesystemjob.md#BKMK_organization_msdyn_fieldservicesystemjob) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_fieldservicesystemjob|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_fieldservicesystemjob|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_productinventory"></a> organization_msdyn_productinventory

Same as msdyn_productinventory entity [organization_msdyn_productinventory](msdyn_productinventory.md#BKMK_organization_msdyn_productinventory) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_productinventory|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_productinventory|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_uniquenumber"></a> organization_msdyn_uniquenumber

Same as msdyn_uniquenumber entity [organization_msdyn_uniquenumber](msdyn_uniquenumber.md#BKMK_organization_msdyn_uniquenumber) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_uniquenumber|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_uniquenumber|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_workorderdetailsgenerationqueue"></a> organization_msdyn_workorderdetailsgenerationqueue

Same as msdyn_workorderdetailsgenerationqueue entity [organization_msdyn_workorderdetailsgenerationqueue](msdyn_workorderdetailsgenerationqueue.md#BKMK_organization_msdyn_workorderdetailsgenerationqueue) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_workorderdetailsgenerationqueue|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_workorderdetailsgenerationqueue|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b"></a> organization_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b

Same as msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b entity [organization_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b](msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b.md#BKMK_organization_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_msdyn_bpf_477c16f59170487b8b4dc895c5dcd09b|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_principalobjectattributeaccess_organizationid"></a> lk_principalobjectattributeaccess_organizationid

Same as principalobjectattributeaccess entity [lk_principalobjectattributeaccess_organizationid](principalobjectattributeaccess.md#BKMK_lk_principalobjectattributeaccess_organizationid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|principalobjectattributeaccess|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|lk_principalobjectattributeaccess_organizationid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_theme"></a> organization_theme

Same as theme entity [organization_theme](theme.md#BKMK_organization_theme) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|theme|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_theme|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_UserMapping"></a> organization_UserMapping

Same as usermapping entity [organization_UserMapping](usermapping.md#BKMK_organization_UserMapping) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|usermapping|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_UserMapping|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_suggestioncardtemplate"></a> organization_suggestioncardtemplate

Same as suggestioncardtemplate entity [organization_suggestioncardtemplate](suggestioncardtemplate.md#BKMK_organization_suggestioncardtemplate) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|suggestioncardtemplate|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_suggestioncardtemplate|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_metric"></a> organization_metric

Same as metric entity [organization_metric](metric.md#BKMK_organization_metric) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|metric|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_metric|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_position"></a> organization_position

Same as position entity [organization_position](position.md#BKMK_organization_position) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|position|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_position|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_officegraphdocument"></a> organization_officegraphdocument

Same as officegraphdocument entity [organization_officegraphdocument](officegraphdocument.md#BKMK_organization_officegraphdocument) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|officegraphdocument|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_officegraphdocument|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_delveactionhub"></a> organization_delveactionhub

Same as delveactionhub entity [organization_delveactionhub](delveactionhub.md#BKMK_organization_delveactionhub) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|delveactionhub|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_delveactionhub|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_recommendeddocument"></a> organization_recommendeddocument

Same as recommendeddocument entity [organization_recommendeddocument](recommendeddocument.md#BKMK_organization_recommendeddocument) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|recommendeddocument|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_recommendeddocument|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_KnowledgeBaseRecord"></a> organization_KnowledgeBaseRecord

Same as knowledgebaserecord entity [organization_KnowledgeBaseRecord](knowledgebaserecord.md#BKMK_organization_KnowledgeBaseRecord) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|knowledgebaserecord|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_KnowledgeBaseRecord|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_translationprocess"></a> organization_translationprocess

Same as translationprocess entity [organization_translationprocess](translationprocess.md#BKMK_organization_translationprocess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|translationprocess|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_translationprocess|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_orginsightsmetric"></a> organization_orginsightsmetric

Same as orginsightsmetric entity [organization_orginsightsmetric](orginsightsmetric.md#BKMK_organization_orginsightsmetric) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|orginsightsmetric|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_orginsightsmetric|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_navigationsetting"></a> organization_navigationsetting

Same as navigationsetting entity [organization_navigationsetting](navigationsetting.md#BKMK_organization_navigationsetting) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|navigationsetting|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_navigationsetting|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_plugintype"></a> organization_plugintype

Same as plugintype entity [organization_plugintype](plugintype.md#BKMK_organization_plugintype) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|plugintype|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_plugintype|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_azureserviceconnection"></a> organization_azureserviceconnection

Same as azureserviceconnection entity [organization_azureserviceconnection](azureserviceconnection.md#BKMK_organization_azureserviceconnection) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|azureserviceconnection|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_azureserviceconnection|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_sdkmessageresponse"></a> organization_sdkmessageresponse

Same as sdkmessageresponse entity [organization_sdkmessageresponse](sdkmessageresponse.md#BKMK_organization_sdkmessageresponse) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sdkmessageresponse|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_sdkmessageresponse|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_business_unit_news_articles"></a> organization_business_unit_news_articles

Same as businessunitnewsarticle entity [organization_business_unit_news_articles](businessunitnewsarticle.md#BKMK_organization_business_unit_news_articles) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|businessunitnewsarticle|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_business_unit_news_articles|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_saved_query_visualizations"></a> organization_saved_query_visualizations

Same as savedqueryvisualization entity [organization_saved_query_visualizations](savedqueryvisualization.md#BKMK_organization_saved_query_visualizations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|savedqueryvisualization|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_saved_query_visualizations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_customcontrolresource_organization"></a> customcontrolresource_organization

Same as customcontrolresource entity [customcontrolresource_organization](customcontrolresource.md#BKMK_customcontrolresource_organization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|customcontrolresource|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|customcontrolresource_organization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_post"></a> organization_post

Same as post entity [organization_post](post.md#BKMK_organization_post) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|post|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_post|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_PostComment"></a> organization_PostComment

Same as postcomment entity [organization_PostComment](postcomment.md#BKMK_organization_PostComment) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|postcomment|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_PostComment|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_postlike"></a> organization_postlike

Same as postlike entity [organization_postlike](postlike.md#BKMK_organization_postlike) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|postlike|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_postlike|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_importjob"></a> organization_importjob

Same as importjob entity [organization_importjob](importjob.md#BKMK_organization_importjob) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|importjob|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_importjob|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_licenses"></a> organization_licenses

Same as license entity [organization_licenses](license.md#BKMK_organization_licenses) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|license|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_licenses|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_expanderevent"></a> organization_expanderevent

Same as expanderevent entity [organization_expanderevent](expanderevent.md#BKMK_organization_expanderevent) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|expanderevent|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_expanderevent|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_ribbon_customization"></a> organization_ribbon_customization

Same as ribboncustomization entity [organization_ribbon_customization](ribboncustomization.md#BKMK_organization_ribbon_customization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|ribboncustomization|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_ribbon_customization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_queues"></a> organization_queues

Same as queue entity [organization_queues](queue.md#BKMK_organization_queues) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|queue|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_queues|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_sdkmessageprocessingstepimage"></a> organization_sdkmessageprocessingstepimage

Same as sdkmessageprocessingstepimage entity [organization_sdkmessageprocessingstepimage](sdkmessageprocessingstepimage.md#BKMK_organization_sdkmessageprocessingstepimage) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sdkmessageprocessingstepimage|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_sdkmessageprocessingstepimage|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_savedorginsightsconfiguration"></a> organization_savedorginsightsconfiguration

Same as savedorginsightsconfiguration entity [organization_savedorginsightsconfiguration](savedorginsightsconfiguration.md#BKMK_organization_savedorginsightsconfiguration) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|savedorginsightsconfiguration|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_savedorginsightsconfiguration|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_plugintypestatistic"></a> organization_plugintypestatistic

Same as plugintypestatistic entity [organization_plugintypestatistic](plugintypestatistic.md#BKMK_organization_plugintypestatistic) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|plugintypestatistic|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_plugintypestatistic|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_MobileOfflineProfileItemAssociation_organization"></a> MobileOfflineProfileItemAssociation_organization

Same as mobileofflineprofileitemassociation entity [MobileOfflineProfileItemAssociation_organization](mobileofflineprofileitemassociation.md#BKMK_MobileOfflineProfileItemAssociation_organization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mobileofflineprofileitemassociation|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|MobileOfflineProfileItemAssociation_organization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_relationship_roles"></a> organization_relationship_roles

Same as relationshiprole entity [organization_relationship_roles](relationshiprole.md#BKMK_organization_relationship_roles) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|relationshiprole|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_relationship_roles|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_appmodule"></a> organization_appmodule

Same as appmodule entity [organization_appmodule](appmodule.md#BKMK_organization_appmodule) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appmodule|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_appmodule|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_sdkmessagepair"></a> organization_sdkmessagepair

Same as sdkmessagepair entity [organization_sdkmessagepair](sdkmessagepair.md#BKMK_organization_sdkmessagepair) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sdkmessagepair|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_sdkmessagepair|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_kb_articles"></a> organization_kb_articles

Same as kbarticle entity [organization_kb_articles](kbarticle.md#BKMK_organization_kb_articles) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|kbarticle|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_kb_articles|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_systemforms"></a> organization_systemforms

Same as systemform entity [organization_systemforms](systemform.md#BKMK_organization_systemforms) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|systemform|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_systemforms|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_appconfig"></a> organization_appconfig

Same as appconfig entity [organization_appconfig](appconfig.md#BKMK_organization_appconfig) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appconfig|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_appconfig|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_sdkmessagerequestfield"></a> organization_sdkmessagerequestfield

Same as sdkmessagerequestfield entity [organization_sdkmessagerequestfield](sdkmessagerequestfield.md#BKMK_organization_sdkmessagerequestfield) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sdkmessagerequestfield|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_sdkmessagerequestfield|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_connection_roles"></a> organization_connection_roles

Same as connectionrole entity [organization_connection_roles](connectionrole.md#BKMK_organization_connection_roles) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|connectionrole|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_connection_roles|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_customcontrol_organization"></a> customcontrol_organization

Same as customcontrol entity [customcontrol_organization](customcontrol.md#BKMK_customcontrol_organization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|customcontrol|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|customcontrol_organization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_userentityinstancedata_organization"></a> userentityinstancedata_organization

Same as userentityinstancedata entity [userentityinstancedata_organization](userentityinstancedata.md#BKMK_userentityinstancedata_organization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|userentityinstancedata|
|ReferencingAttribute|objectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|userentityinstancedata_organization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_subjects"></a> organization_subjects

Same as subject entity [organization_subjects](subject.md#BKMK_organization_subjects) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|subject|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_subjects|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_calendars"></a> organization_calendars

Same as calendar entity [organization_calendars](calendar.md#BKMK_organization_calendars) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|calendar|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_calendars|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_publisher"></a> organization_publisher

Same as publisher entity [organization_publisher](publisher.md#BKMK_organization_publisher) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|publisher|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_publisher|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_queueitems"></a> organization_queueitems

Same as queueitem entity [organization_queueitems](queueitem.md#BKMK_organization_queueitems) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|queueitem|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_queueitems|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_teams"></a> organization_teams

Same as team entity [organization_teams](team.md#BKMK_organization_teams) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|team|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_teams|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_advancedsimilarityrule"></a> organization_advancedsimilarityrule

Same as advancedsimilarityrule entity [organization_advancedsimilarityrule](advancedsimilarityrule.md#BKMK_organization_advancedsimilarityrule) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|advancedsimilarityrule|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_advancedsimilarityrule|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_socialinsightsconfiguration"></a> organization_socialinsightsconfiguration

Same as socialinsightsconfiguration entity [organization_socialinsightsconfiguration](socialinsightsconfiguration.md#BKMK_organization_socialinsightsconfiguration) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|socialinsightsconfiguration|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_socialinsightsconfiguration|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_entitymap"></a> organization_entitymap

Same as entitymap entity [organization_entitymap](entitymap.md#BKMK_organization_entitymap) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|entitymap|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_entitymap|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_channelproperty_organization"></a> channelproperty_organization

Same as channelproperty entity [channelproperty_organization](channelproperty.md#BKMK_channelproperty_organization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|channelproperty|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|channelproperty_organization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_entitydataprovider"></a> organization_entitydataprovider

Same as entitydataprovider entity [organization_entitydataprovider](entitydataprovider.md#BKMK_organization_entitydataprovider) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|entitydataprovider|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_entitydataprovider|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_sharepointdocument"></a> organization_sharepointdocument

Same as sharepointdocument entity [organization_sharepointdocument](sharepointdocument.md#BKMK_organization_sharepointdocument) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdocument|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_sharepointdocument|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_webresource_organization"></a> webresource_organization

Same as webresource entity [webresource_organization](webresource.md#BKMK_webresource_organization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|webresource|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|webresource_organization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_textanalyticsentitymapping"></a> organization_textanalyticsentitymapping

Same as textanalyticsentitymapping entity [organization_textanalyticsentitymapping](textanalyticsentitymapping.md#BKMK_organization_textanalyticsentitymapping) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|textanalyticsentitymapping|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_textanalyticsentitymapping|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_MobileOfflineProfile_organization"></a> MobileOfflineProfile_organization

Same as mobileofflineprofile entity [MobileOfflineProfile_organization](mobileofflineprofile.md#BKMK_MobileOfflineProfile_organization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mobileofflineprofile|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|MobileOfflineProfile_organization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_transactioncurrencies"></a> organization_transactioncurrencies

Same as transactioncurrency entity [organization_transactioncurrencies](transactioncurrency.md#BKMK_organization_transactioncurrencies) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|transactioncurrency|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_transactioncurrencies|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_expiredprocess"></a> organization_expiredprocess

Same as expiredprocess entity [organization_expiredprocess](expiredprocess.md#BKMK_organization_expiredprocess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|expiredprocess|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_expiredprocess|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_mailbox"></a> organization_mailbox

Same as mailbox entity [organization_mailbox](mailbox.md#BKMK_organization_mailbox) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailbox|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_mailbox|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_dataperformance_organizationid"></a> lk_dataperformance_organizationid

Same as dataperformance entity [lk_dataperformance_organizationid](dataperformance.md#BKMK_lk_dataperformance_organizationid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|dataperformance|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|lk_dataperformance_organizationid|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_isvconfigs"></a> organization_isvconfigs

Same as isvconfig entity [organization_isvconfigs](isvconfig.md#BKMK_organization_isvconfigs) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|isvconfig|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_isvconfigs|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_sharepointdata"></a> organization_sharepointdata

Same as sharepointdata entity [organization_sharepointdata](sharepointdata.md#BKMK_organization_sharepointdata) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sharepointdata|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_sharepointdata|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_offlinecommanddefinition_organization"></a> offlinecommanddefinition_organization

Same as offlinecommanddefinition entity [offlinecommanddefinition_organization](offlinecommanddefinition.md#BKMK_offlinecommanddefinition_organization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|offlinecommanddefinition|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|offlinecommanddefinition_organization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_MobileOfflineProfileItem_organization"></a> MobileOfflineProfileItem_organization

Same as mobileofflineprofileitem entity [MobileOfflineProfileItem_organization](mobileofflineprofileitem.md#BKMK_MobileOfflineProfileItem_organization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mobileofflineprofileitem|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|MobileOfflineProfileItem_organization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_custom_displaystrings"></a> organization_custom_displaystrings

Same as displaystring entity [organization_custom_displaystrings](displaystring.md#BKMK_organization_custom_displaystrings) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|displaystring|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_custom_displaystrings|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Organization_SyncErrors"></a> Organization_SyncErrors

Same as syncerror entity [Organization_SyncErrors](syncerror.md#BKMK_Organization_SyncErrors) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|syncerror|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|Organization_SyncErrors|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: Cascade<br />Delete: NoCascade<br />Merge: Cascade<br />Reparent: Cascade<br />Share: Cascade<br />Unshare: Cascade|


### <a name="BKMK_channelpropertygroup_organization"></a> channelpropertygroup_organization

Same as channelpropertygroup entity [channelpropertygroup_organization](channelpropertygroup.md#BKMK_channelpropertygroup_organization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|channelpropertygroup|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|channelpropertygroup_organization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_sdkmessagerequest"></a> organization_sdkmessagerequest

Same as sdkmessagerequest entity [organization_sdkmessagerequest](sdkmessagerequest.md#BKMK_organization_sdkmessagerequest) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sdkmessagerequest|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_sdkmessagerequest|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Organization_AsyncOperations"></a> Organization_AsyncOperations

Same as asyncoperation entity [Organization_AsyncOperations](asyncoperation.md#BKMK_Organization_AsyncOperations) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|asyncoperation|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Organization_AsyncOperations|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_customcontroldefaultconfig_organization"></a> customcontroldefaultconfig_organization

Same as customcontroldefaultconfig entity [customcontroldefaultconfig_organization](customcontroldefaultconfig.md#BKMK_customcontroldefaultconfig_organization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|customcontroldefaultconfig|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|customcontroldefaultconfig_organization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_sitemap"></a> organization_sitemap

Same as sitemap entity [organization_sitemap](sitemap.md#BKMK_organization_sitemap) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sitemap|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_sitemap|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Organization_MailboxTrackingFolder"></a> Organization_MailboxTrackingFolder

Same as mailboxtrackingfolder entity [Organization_MailboxTrackingFolder](mailboxtrackingfolder.md#BKMK_Organization_MailboxTrackingFolder) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxtrackingfolder|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Organization_MailboxTrackingFolder|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_emailserverprofile"></a> organization_emailserverprofile

Same as emailserverprofile entity [organization_emailserverprofile](emailserverprofile.md#BKMK_organization_emailserverprofile) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|emailserverprofile|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_emailserverprofile|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_organizationui_organizationid"></a> lk_organizationui_organizationid

Same as organizationui entity [lk_organizationui_organizationid](organizationui.md#BKMK_lk_organizationui_organizationid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|organizationui|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|lk_organizationui_organizationid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_pluginassembly"></a> organization_pluginassembly

Same as pluginassembly entity [organization_pluginassembly](pluginassembly.md#BKMK_organization_pluginassembly) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|pluginassembly|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_pluginassembly|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_mailboxstatistics"></a> organization_mailboxstatistics

Same as mailboxstatistics entity [organization_mailboxstatistics](mailboxstatistics.md#BKMK_organization_mailboxstatistics) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|mailboxstatistics|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_mailboxstatistics|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_knowledgesearchmodel"></a> organization_knowledgesearchmodel

Same as knowledgesearchmodel entity [organization_knowledgesearchmodel](knowledgesearchmodel.md#BKMK_organization_knowledgesearchmodel) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|knowledgesearchmodel|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_knowledgesearchmodel|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_Organization_BulkDeleteFailures"></a> Organization_BulkDeleteFailures

Same as bulkdeletefailure entity [Organization_BulkDeleteFailures](bulkdeletefailure.md#BKMK_Organization_BulkDeleteFailures) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|bulkdeletefailure|
|ReferencingAttribute|regardingobjectid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|Organization_BulkDeleteFailures|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_fieldsecurityprofile_organizationid"></a> lk_fieldsecurityprofile_organizationid

Same as fieldsecurityprofile entity [lk_fieldsecurityprofile_organizationid](fieldsecurityprofile.md#BKMK_lk_fieldsecurityprofile_organizationid) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|fieldsecurityprofile|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|lk_fieldsecurityprofile_organizationid|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_sdkmessagefilter"></a> organization_sdkmessagefilter

Same as sdkmessagefilter entity [organization_sdkmessagefilter](sdkmessagefilter.md#BKMK_organization_sdkmessagefilter) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sdkmessagefilter|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_sdkmessagefilter|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_kb_article_templates"></a> organization_kb_article_templates

Same as kbarticletemplate entity [organization_kb_article_templates](kbarticletemplate.md#BKMK_organization_kb_article_templates) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|kbarticletemplate|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_kb_article_templates|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_roles"></a> organization_roles

Same as role entity [organization_roles](role.md#BKMK_organization_roles) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|role|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_roles|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_sdkmessageprocessingstepsecureconfig"></a> organization_sdkmessageprocessingstepsecureconfig

Same as sdkmessageprocessingstepsecureconfig entity [organization_sdkmessageprocessingstepsecureconfig](sdkmessageprocessingstepsecureconfig.md#BKMK_organization_sdkmessageprocessingstepsecureconfig) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sdkmessageprocessingstepsecureconfig|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_sdkmessageprocessingstepsecureconfig|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_entitydatasource"></a> organization_entitydatasource

Same as entitydatasource entity [organization_entitydatasource](entitydatasource.md#BKMK_organization_entitydatasource) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|entitydatasource|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_entitydatasource|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_aciviewmapper"></a> organization_aciviewmapper

Same as aciviewmapper entity [organization_aciviewmapper](aciviewmapper.md#BKMK_organization_aciviewmapper) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|aciviewmapper|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_aciviewmapper|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_system_users"></a> organization_system_users

Same as systemuser entity [organization_system_users](systemuser.md#BKMK_organization_system_users) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|systemuser|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_system_users|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_languagelocale_organization"></a> languagelocale_organization

Same as languagelocale entity [languagelocale_organization](languagelocale.md#BKMK_languagelocale_organization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|languagelocale|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|languagelocale_organization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_business_units"></a> organization_business_units

Same as businessunit entity [organization_business_units](businessunit.md#BKMK_organization_business_units) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|businessunit|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_business_units|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_sdkmessageresponsefield"></a> organization_sdkmessageresponsefield

Same as sdkmessageresponsefield entity [organization_sdkmessageresponsefield](sdkmessageresponsefield.md#BKMK_organization_sdkmessageresponsefield) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sdkmessageresponsefield|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_sdkmessageresponsefield|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_attributemap"></a> organization_attributemap

Same as attributemap entity [organization_attributemap](attributemap.md#BKMK_organization_attributemap) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|attributemap|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_attributemap|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_newprocess"></a> organization_newprocess

Same as newprocess entity [organization_newprocess](newprocess.md#BKMK_organization_newprocess) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|newprocess|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|True|
|ReferencedEntityNavigationPropertyName|organization_newprocess|
|AssociatedMenuConfiguration|Behavior: UseCollectionName<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_hierarchyrules"></a> organization_hierarchyrules

Same as hierarchyrule entity [organization_hierarchyrules](hierarchyrule.md#BKMK_organization_hierarchyrules) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|hierarchyrule|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_hierarchyrules|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_sdkmessageprocessingstep"></a> organization_sdkmessageprocessingstep

Same as sdkmessageprocessingstep entity [organization_sdkmessageprocessingstep](sdkmessageprocessingstep.md#BKMK_organization_sdkmessageprocessingstep) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sdkmessageprocessingstep|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_sdkmessageprocessingstep|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_RoutingRules"></a> organization_RoutingRules

Same as routingrule entity [organization_RoutingRules](routingrule.md#BKMK_organization_RoutingRules) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|routingrule|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_RoutingRules|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_orginsightsnotification"></a> organization_orginsightsnotification

Same as orginsightsnotification entity [organization_orginsightsnotification](orginsightsnotification.md#BKMK_organization_orginsightsnotification) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|orginsightsnotification|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_orginsightsnotification|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_appconfiginstance"></a> organization_appconfiginstance

Same as appconfiginstance entity [organization_appconfiginstance](appconfiginstance.md#BKMK_organization_appconfiginstance) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appconfiginstance|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_appconfiginstance|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_routingruleitems"></a> organization_routingruleitems

Same as routingruleitem entity [organization_routingruleitems](routingruleitem.md#BKMK_organization_routingruleitems) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|routingruleitem|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_routingruleitems|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_lk_documenttemplatebase_organization"></a> lk_documenttemplatebase_organization

Same as documenttemplate entity [lk_documenttemplatebase_organization](documenttemplate.md#BKMK_lk_documenttemplatebase_organization) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|documenttemplate|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|lk_documenttemplatebase_organization|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_serviceendpoint"></a> organization_serviceendpoint

Same as serviceendpoint entity [organization_serviceendpoint](serviceendpoint.md#BKMK_organization_serviceendpoint) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|serviceendpoint|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_serviceendpoint|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_sdkmessage"></a> organization_sdkmessage

Same as sdkmessage entity [organization_sdkmessage](sdkmessage.md#BKMK_organization_sdkmessage) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|sdkmessage|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_sdkmessage|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_appconfigmaster"></a> organization_appconfigmaster

Same as appconfigmaster entity [organization_appconfigmaster](appconfigmaster.md#BKMK_organization_appconfigmaster) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|appconfigmaster|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_appconfigmaster|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_saved_queries"></a> organization_saved_queries

Same as savedquery entity [organization_saved_queries](savedquery.md#BKMK_organization_saved_queries) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|savedquery|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_saved_queries|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_tracelog"></a> organization_tracelog

Same as tracelog entity [organization_tracelog](tracelog.md#BKMK_organization_tracelog) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|tracelog|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_tracelog|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|


### <a name="BKMK_organization_solution"></a> organization_solution

Same as solution entity [organization_solution](solution.md#BKMK_organization_solution) Many-To-One relationship.

|Property|Value|
|--------|-----|
|ReferencingEntity|solution|
|ReferencingAttribute|organizationid|
|IsHierarchical|False|
|IsCustomizable|False|
|ReferencedEntityNavigationPropertyName|organization_solution|
|AssociatedMenuConfiguration|Behavior: DoNotDisplay<br />Group: Details<br />Label: <br />Order: |
|CascadeConfiguration|Assign: NoCascade<br />Delete: NoCascade<br />Merge: NoCascade<br />Reparent: NoCascade<br />Share: NoCascade<br />Unshare: NoCascade|

<a name="manytoone"></a>

## Many-To-One Relationships

Each Many-To-One relationship is defined by a corresponding One-To-Many relationship with the related entity. Listed by **SchemaName**.

- [lk_organizationbase_modifiedby](#BKMK_lk_organizationbase_modifiedby)
- [lk_organization_createdonbehalfby](#BKMK_lk_organization_createdonbehalfby)
- [EmailServerProfile_Organization](#BKMK_EmailServerProfile_Organization)
- [DefaultMobileOfflineProfile_Organization](#BKMK_DefaultMobileOfflineProfile_Organization)
- [lk_organizationbase_createdby](#BKMK_lk_organizationbase_createdby)
- [basecurrency_organization](#BKMK_basecurrency_organization)
- [lk_organization_modifiedonbehalfby](#BKMK_lk_organization_modifiedonbehalfby)
- [calendar_organization](#BKMK_calendar_organization)
- [Template_Organization](#BKMK_Template_Organization)


### <a name="BKMK_lk_organizationbase_modifiedby"></a> lk_organizationbase_modifiedby

See systemuser Entity [lk_organizationbase_modifiedby](systemuser.md#BKMK_lk_organizationbase_modifiedby) One-To-Many relationship.

### <a name="BKMK_lk_organization_createdonbehalfby"></a> lk_organization_createdonbehalfby

See systemuser Entity [lk_organization_createdonbehalfby](systemuser.md#BKMK_lk_organization_createdonbehalfby) One-To-Many relationship.

### <a name="BKMK_EmailServerProfile_Organization"></a> EmailServerProfile_Organization

See emailserverprofile Entity [EmailServerProfile_Organization](emailserverprofile.md#BKMK_EmailServerProfile_Organization) One-To-Many relationship.

### <a name="BKMK_DefaultMobileOfflineProfile_Organization"></a> DefaultMobileOfflineProfile_Organization

See mobileofflineprofile Entity [DefaultMobileOfflineProfile_Organization](mobileofflineprofile.md#BKMK_DefaultMobileOfflineProfile_Organization) One-To-Many relationship.

### <a name="BKMK_lk_organizationbase_createdby"></a> lk_organizationbase_createdby

See systemuser Entity [lk_organizationbase_createdby](systemuser.md#BKMK_lk_organizationbase_createdby) One-To-Many relationship.

### <a name="BKMK_basecurrency_organization"></a> basecurrency_organization

See transactioncurrency Entity [basecurrency_organization](transactioncurrency.md#BKMK_basecurrency_organization) One-To-Many relationship.

### <a name="BKMK_lk_organization_modifiedonbehalfby"></a> lk_organization_modifiedonbehalfby

See systemuser Entity [lk_organization_modifiedonbehalfby](systemuser.md#BKMK_lk_organization_modifiedonbehalfby) One-To-Many relationship.

### <a name="BKMK_calendar_organization"></a> calendar_organization

See calendar Entity [calendar_organization](calendar.md#BKMK_calendar_organization) One-To-Many relationship.

### <a name="BKMK_Template_Organization"></a> Template_Organization

See template Entity [Template_Organization](template.md#BKMK_Template_Organization) One-To-Many relationship.

### See also

[About the Entity Reference](../about-entity-reference.md)<br />
[Programming reference for Dynamics 365 Customer Engagement](../programming-reference.md)<br />
[Web API Reference](/dynamics365/customer-engagement/web-api/about)<br />
<xref href="Microsoft.Dynamics.CRM.organization?text=organization EntityType" />