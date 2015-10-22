using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using CellStore.Client;
using CellStore.Model;

namespace CellStore.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataApi
    {
        
        /// <summary>
        /// Retrieve a summary for all components of a given filing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="fiscalYear">The fiscal year focus of the components to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period focus of the components to retrieve (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="aid">The id of the filings for which to retrieve components</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="hypercube">An hypercube name to further filter components</param>
        /// <param name="disclosure">The disclosure to search for (e.g. BalanceSheet)</param>
        /// <param name="reportElement">The name of the report element to search for (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <param name="validate">Whether to run validation on the output components (default: false). Adds a column ValidationErrors</param>
        /// <param name="language">A language code</param>
        /// <returns>Object</returns>
        Object ListComponents (string token, string eid = null, string ticker = null, string tag = null, string sic = null, string cik = null, string edinetcode = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string aid = null, string section = null, string hypercube = null, string disclosure = null, string reportElement = null, string label = null, string profileName = null, bool? count = null, int? top = null, bool? skip = null, bool? validate = null, string language = null);
  
        /// <summary>
        /// Retrieve a summary for all components of a given filing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="fiscalYear">The fiscal year focus of the components to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period focus of the components to retrieve (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="aid">The id of the filings for which to retrieve components</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="hypercube">An hypercube name to further filter components</param>
        /// <param name="disclosure">The disclosure to search for (e.g. BalanceSheet)</param>
        /// <param name="reportElement">The name of the report element to search for (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <param name="validate">Whether to run validation on the output components (default: false). Adds a column ValidationErrors</param>
        /// <param name="language">A language code</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListComponentsAsync (string token, string eid = null, string ticker = null, string tag = null, string sic = null, string cik = null, string edinetcode = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string aid = null, string section = null, string hypercube = null, string disclosure = null, string reportElement = null, string label = null, string profileName = null, bool? count = null, int? top = null, bool? skip = null, bool? validate = null, string language = null);
        
        /// <summary>
        /// Retrieve metadata about the entities that submit filings. These entities are also referred to by facts with the xbrl:Entity aspect, of which the values are called Entity IDs (EIDs). One entity might have several EIDs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API</param>
        /// <param name="tag">Includes in the results entities that have the supplied tags. A tag is often a stock index</param>
        /// <param name="eid">Includes in the results the entity with the supplied Entity ID (scheme + local name)</param>
        /// <param name="cik">Includes in the results the entity with the supplied CIK number</param>
        /// <param name="edinetcode">Includes in the results the entity with the supplied EDINET Code</param>
        /// <param name="sic">Includes in the results the entity with the supplied industry group</param>
        /// <param name="ticker">Includes in the results the entity with the supplied ticker symbol</param>
        /// <param name="entitySearch">Includes in the results the entities whose name match this full-text query</param>
        /// <param name="entitySearchOffset">Includes in the results the entities whose name match the entity-search parameter skipping the first entity-search-offset results (default: 0)</param>
        /// <param name="entitySearchLimit">Includes in the results the entities whose name match the entity-search parameter limited to a maximum of entity-search-limit results (default: 10)</param>
        /// <param name="language">Specifies in which language to perform the entity-search query (default: en)</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <returns>Object</returns>
        Object ListEntities (string token, string tag = null, string eid = null, string cik = null, string edinetcode = null, string sic = null, string ticker = null, string entitySearch = null, int? entitySearchOffset = null, int? entitySearchLimit = null, string language = null, bool? count = null, int? top = null, bool? skip = null);
  
        /// <summary>
        /// Retrieve metadata about the entities that submit filings. These entities are also referred to by facts with the xbrl:Entity aspect, of which the values are called Entity IDs (EIDs). One entity might have several EIDs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API</param>
        /// <param name="tag">Includes in the results entities that have the supplied tags. A tag is often a stock index</param>
        /// <param name="eid">Includes in the results the entity with the supplied Entity ID (scheme + local name)</param>
        /// <param name="cik">Includes in the results the entity with the supplied CIK number</param>
        /// <param name="edinetcode">Includes in the results the entity with the supplied EDINET Code</param>
        /// <param name="sic">Includes in the results the entity with the supplied industry group</param>
        /// <param name="ticker">Includes in the results the entity with the supplied ticker symbol</param>
        /// <param name="entitySearch">Includes in the results the entities whose name match this full-text query</param>
        /// <param name="entitySearchOffset">Includes in the results the entities whose name match the entity-search parameter skipping the first entity-search-offset results (default: 0)</param>
        /// <param name="entitySearchLimit">Includes in the results the entities whose name match the entity-search parameter limited to a maximum of entity-search-limit results (default: 10)</param>
        /// <param name="language">Specifies in which language to perform the entity-search query (default: en)</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListEntitiesAsync (string token, string tag = null, string eid = null, string cik = null, string edinetcode = null, string sic = null, string ticker = null, string entitySearch = null, int? entitySearchOffset = null, int? entitySearchLimit = null, string language = null, bool? count = null, int? top = null, bool? skip = null);
        
        /// <summary>
        /// Retrieve one or more facts for a combination of filings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="aid">The id of the filing</param>
        /// <param name="fiscalYear">The fiscal year of the fact to retrieve (default: no filtering)</param>
        /// <param name="concept">The name of the concept to retrieve the fact for (alternatively, a parameter with name xbrl:Concept can be used)</param>
        /// <param name="fiscalPeriod">The fiscal period of the fact to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriodType">The fiscal period type of the fact to retrieve (default: no filtering). Can select multiple</param>
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none)</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="labels">Whether human readable labels should be included for concepts in each fact. (default: false)</param>
        /// <param name="open">Whether the query has open hypercube semantics. (default: false)</param>
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <param name="dimensions">A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string</param>
        /// <param name="dimensionTypes">Sets the given dimensions to be typed dimensions with the specified type. (Default: xbrl:Entity/xbrl:Period/xbrl:Unit/xbrl28:Archive are typed string, others are explicit dimensions. Some further dimensions may have default types depending on the profile.). Each key is in the form prefix:dimension::type, each value is a string</param>
        /// <param name="defaultDimensionValues">Specifies the default value of the given dimensions that should be returned if the dimension was not provided explicitly for a fact. Each key is in the form  prefix:dimension::default, each value is a string</param>
        /// <param name="dimensionSlicers">Specifies whether the given dimensions are slicers (true) or a dicers (false). Slicer dimensions do not appear in the output fact table (default: false). Each key is in the form prefix:dimension::slicer, each value is a boolean</param>
        /// <param name="dimensionColumns">Specifies the position at which dicer dimensions appear in the output fact table (default: arbitrary order). Each key is in the form prefix:dimension::column, each value is an integer</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <returns>Object</returns>
        Object ListFacts (string token, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string aid = null, string fiscalYear = null, string concept = null, string fiscalPeriod = null, string fiscalPeriodType = null, string report = null, string additionalRules = null, bool? labels = null, bool? open = null, string mostRecentVersionAspect = null, string profileName = null, Dictionary<string, string> dimensions = null, Dictionary<string, string> dimensionTypes = null, Dictionary<string, string> defaultDimensionValues = null, Dictionary<string, bool?> dimensionSlicers = null, Dictionary<string, int?> dimensionColumns = null, bool? count = null, int? top = null, bool? skip = null);
  
        /// <summary>
        /// Retrieve one or more facts for a combination of filings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="aid">The id of the filing</param>
        /// <param name="fiscalYear">The fiscal year of the fact to retrieve (default: no filtering)</param>
        /// <param name="concept">The name of the concept to retrieve the fact for (alternatively, a parameter with name xbrl:Concept can be used)</param>
        /// <param name="fiscalPeriod">The fiscal period of the fact to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriodType">The fiscal period type of the fact to retrieve (default: no filtering). Can select multiple</param>
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none)</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="labels">Whether human readable labels should be included for concepts in each fact. (default: false)</param>
        /// <param name="open">Whether the query has open hypercube semantics. (default: false)</param>
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <param name="dimensions">A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string</param>
        /// <param name="dimensionTypes">Sets the given dimensions to be typed dimensions with the specified type. (Default: xbrl:Entity/xbrl:Period/xbrl:Unit/xbrl28:Archive are typed string, others are explicit dimensions. Some further dimensions may have default types depending on the profile.). Each key is in the form prefix:dimension::type, each value is a string</param>
        /// <param name="defaultDimensionValues">Specifies the default value of the given dimensions that should be returned if the dimension was not provided explicitly for a fact. Each key is in the form  prefix:dimension::default, each value is a string</param>
        /// <param name="dimensionSlicers">Specifies whether the given dimensions are slicers (true) or a dicers (false). Slicer dimensions do not appear in the output fact table (default: false). Each key is in the form prefix:dimension::slicer, each value is a boolean</param>
        /// <param name="dimensionColumns">Specifies the position at which dicer dimensions appear in the output fact table (default: arbitrary order). Each key is in the form prefix:dimension::column, each value is an integer</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListFactsAsync (string token, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string aid = null, string fiscalYear = null, string concept = null, string fiscalPeriod = null, string fiscalPeriodType = null, string report = null, string additionalRules = null, bool? labels = null, bool? open = null, string mostRecentVersionAspect = null, string profileName = null, Dictionary<string, string> dimensions = null, Dictionary<string, string> dimensionTypes = null, Dictionary<string, string> defaultDimensionValues = null, Dictionary<string, bool?> dimensionSlicers = null, Dictionary<string, int?> dimensionColumns = null, bool? count = null, int? top = null, bool? skip = null);
        
        /// <summary>
        /// Add a fact to a filing.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="fact">The fact object</param>
        /// <param name="aid">The id of the filing</param>
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <returns>Object</returns>
        Object AddFacts (string token, Object fact, string aid = null, string mostRecentVersionAspect = null, string profileName = null);
  
        /// <summary>
        /// Add a fact to a filing.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="fact">The fact object</param>
        /// <param name="aid">The id of the filing</param>
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> AddFactsAsync (string token, Object fact, string aid = null, string mostRecentVersionAspect = null, string profileName = null);
        
        /// <summary>
        /// Retrieve the fact table for a given component. A component can be selected in three ways. (1) by component id (cid), (2) by accession number and disclosure (aid and disclosure), or (3) by CIK, fiscal year, fiscal period, and disclosure (cik, fiscalYear, fiscalPeriod, and disclosure).
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="aid">The accession number of the filing. This parameter needs to be used together with the disclosure parameter to identify a component</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">A tag to filter</param>
        /// <param name="sic">The industry group</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="fiscalYear">The fiscal year of the filing (default: no filtering). In override mode, also filters facts</param>
        /// <param name="fiscalPeriod">The fiscal period of the filing (default: no filtering). In override mode, also filters facts</param>
        /// <param name="fiscalPeriodType">In override mode, the fiscal period type of the facts to filter (default: no filtering). Can select multiple</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="disclosure">The disclosure of the component (e.g. BalanceSheet)</param>
        /// <param name="reportElement">Filters only those components that contained the supplied report element (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false)</param>
        /// <param name="merge">Whether to merge components if multiple are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to the component&#39;s rules (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="labels">Whether human readable labels should be included for concepts in each fact. (default: false)</param>
        /// <param name="language">A language code</param>
        /// <param name="_override">Whether the fiscalYear/fiscalPeriod/fiscalPeriodType parameters should also be used to filter facts (default: false)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <returns>Object</returns>
        Object ListFactTable (string token, string aid = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string section = null, string fiscalYear = null, string fiscalPeriod = null, string fiscalPeriodType = null, string filingKind = null, string disclosure = null, string reportElement = null, string label = null, bool? validate = null, bool? merge = null, bool? count = null, int? top = null, bool? skip = null, string mostRecentVersionAspect = null, string additionalRules = null, bool? labels = null, string language = null, bool? _override = null, string profileName = null);
  
        /// <summary>
        /// Retrieve the fact table for a given component. A component can be selected in three ways. (1) by component id (cid), (2) by accession number and disclosure (aid and disclosure), or (3) by CIK, fiscal year, fiscal period, and disclosure (cik, fiscalYear, fiscalPeriod, and disclosure).
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="aid">The accession number of the filing. This parameter needs to be used together with the disclosure parameter to identify a component</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">A tag to filter</param>
        /// <param name="sic">The industry group</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="fiscalYear">The fiscal year of the filing (default: no filtering). In override mode, also filters facts</param>
        /// <param name="fiscalPeriod">The fiscal period of the filing (default: no filtering). In override mode, also filters facts</param>
        /// <param name="fiscalPeriodType">In override mode, the fiscal period type of the facts to filter (default: no filtering). Can select multiple</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="disclosure">The disclosure of the component (e.g. BalanceSheet)</param>
        /// <param name="reportElement">Filters only those components that contained the supplied report element (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false)</param>
        /// <param name="merge">Whether to merge components if multiple are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to the component&#39;s rules (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="labels">Whether human readable labels should be included for concepts in each fact. (default: false)</param>
        /// <param name="language">A language code</param>
        /// <param name="_override">Whether the fiscalYear/fiscalPeriod/fiscalPeriodType parameters should also be used to filter facts (default: false)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListFactTableAsync (string token, string aid = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string section = null, string fiscalYear = null, string fiscalPeriod = null, string fiscalPeriodType = null, string filingKind = null, string disclosure = null, string reportElement = null, string label = null, bool? validate = null, bool? merge = null, bool? count = null, int? top = null, bool? skip = null, string mostRecentVersionAspect = null, string additionalRules = null, bool? labels = null, string language = null, bool? _override = null, string profileName = null);
        
        /// <summary>
        /// Retrieve the fact table for a given report. Filters can be overriden. Filters MUST be overriden if the report is not already filtering.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="fiscalYear">The fiscal year of the fact to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period of the fact to retrieve (default: no filtering). Can select multiple</param>
        /// <param name="fiscalPeriodType">The fiscal period type of the fact to retrieve (default: no filtering). Can select multiple</param>
        /// <param name="report">The name of the report to be used (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="validate">Validate and stamp facts accordingly</param>
        /// <param name="labels">Whether human readable labels should be included for concepts in each fact. (default: false)</param>
        /// <param name="language">A language code</param>
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <returns>Object</returns>
        Object ListFactTableForReport (string token, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string fiscalYear = null, string fiscalPeriod = null, string fiscalPeriodType = null, string report = null, bool? validate = null, bool? labels = null, string language = null, string mostRecentVersionAspect = null, string profileName = null, bool? count = null, int? top = null, bool? skip = null);
  
        /// <summary>
        /// Retrieve the fact table for a given report. Filters can be overriden. Filters MUST be overriden if the report is not already filtering.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="fiscalYear">The fiscal year of the fact to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period of the fact to retrieve (default: no filtering). Can select multiple</param>
        /// <param name="fiscalPeriodType">The fiscal period type of the fact to retrieve (default: no filtering). Can select multiple</param>
        /// <param name="report">The name of the report to be used (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="validate">Validate and stamp facts accordingly</param>
        /// <param name="labels">Whether human readable labels should be included for concepts in each fact. (default: false)</param>
        /// <param name="language">A language code</param>
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListFactTableForReportAsync (string token, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string fiscalYear = null, string fiscalPeriod = null, string fiscalPeriodType = null, string report = null, bool? validate = null, bool? labels = null, string language = null, string mostRecentVersionAspect = null, string profileName = null, bool? count = null, int? top = null, bool? skip = null);
        
        /// <summary>
        /// Retrieve metadata about the filings, also called archives. The filings are identified with Archive IDs (AIDs). Facts can be bound with filings with the xbrl28:Archive aspect, whose values are AIDs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API</param>
        /// <param name="tag">Filters the results for filings submitted by the entity identified by this tag, with the same semantics as the entities endpoint</param>
        /// <param name="eid">Filters the results for filings submitted by the entity identified by this EID, with the same semantics as the entities endpoint</param>
        /// <param name="cik">Filters the results for filings submitted by the entity identified by this CIK, with the same semantics as the entities endpoint</param>
        /// <param name="edinetcode">Filters the results for filings submitted by the entity identified by this EDINET code, with the same semantics as the entities endpoint</param>
        /// <param name="ticker">Filters the results for filings submitted by the entity identified by this ticker symbol, with the same semantics as the entities endpoint</param>
        /// <param name="sic">Filters the results for filings submitted by the entity identified by this industry group, with the same semantics as the entities endpoint</param>
        /// <param name="aid">Includes in the results the filings with the supplied Archive ID. This parameter is unaffected by the other filters</param>
        /// <param name="fiscalYear">Filters the results for the filings submitted for the supplied fiscal year focus. (default: no filtering)</param>
        /// <param name="fiscalPeriod">Filters the results for the filings submitted for the supplied fiscal period focus. (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <param name="language">A language code</param>
        /// <returns>Object</returns>
        Object ListFilings (string token, string tag = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string sic = null, string aid = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, bool? count = null, int? top = null, bool? skip = null, string language = null);
  
        /// <summary>
        /// Retrieve metadata about the filings, also called archives. The filings are identified with Archive IDs (AIDs). Facts can be bound with filings with the xbrl28:Archive aspect, whose values are AIDs.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API</param>
        /// <param name="tag">Filters the results for filings submitted by the entity identified by this tag, with the same semantics as the entities endpoint</param>
        /// <param name="eid">Filters the results for filings submitted by the entity identified by this EID, with the same semantics as the entities endpoint</param>
        /// <param name="cik">Filters the results for filings submitted by the entity identified by this CIK, with the same semantics as the entities endpoint</param>
        /// <param name="edinetcode">Filters the results for filings submitted by the entity identified by this EDINET code, with the same semantics as the entities endpoint</param>
        /// <param name="ticker">Filters the results for filings submitted by the entity identified by this ticker symbol, with the same semantics as the entities endpoint</param>
        /// <param name="sic">Filters the results for filings submitted by the entity identified by this industry group, with the same semantics as the entities endpoint</param>
        /// <param name="aid">Includes in the results the filings with the supplied Archive ID. This parameter is unaffected by the other filters</param>
        /// <param name="fiscalYear">Filters the results for the filings submitted for the supplied fiscal year focus. (default: no filtering)</param>
        /// <param name="fiscalPeriod">Filters the results for the filings submitted for the supplied fiscal period focus. (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <param name="language">A language code</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListFilingsAsync (string token, string tag = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string sic = null, string aid = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, bool? count = null, int? top = null, bool? skip = null, string language = null);
        
        /// <summary>
        /// Add or updata a filing. The filings are identified with Archive IDs (AIDs).
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API.</param>
        /// <param name="format">Returns the results in the supplied format.</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository.</param>
        /// <returns>Object</returns>
        Object UpsertFilings (string token, string format = null, string profileName = null);
  
        /// <summary>
        /// Add or updata a filing. The filings are identified with Archive IDs (AIDs).
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token that allows you to use this API.</param>
        /// <param name="format">Returns the results in the supplied format.</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository.</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> UpsertFilingsAsync (string token, string format = null, string profileName = null);
        
        /// <summary>
        /// Retrieve labels for the supplied components and report elements
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="fiscalYear">The fiscal year focus of the components to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period focus of the components to retrieve (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="aid">The id of the filings for which to retrieve components</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="disclosure">The disclosure to search for (e.g. BalanceSheet)</param>
        /// <param name="reportElement">The name of the report element to search for (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock). Exact match, except for the SEC profile where it performs full text search in English</param>
        /// <param name="language">A language code</param>
        /// <param name="labelRole">A label role</param>
        /// <param name="kind">Filters by concept kind (default: no filtering)</param>
        /// <param name="eliminateReportElementDuplicates">Whether to eliminate (concept name, language, label role) duplicates. By default no duplicate elimination</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <returns>Object</returns>
        Object ListLabels (string token, string eid = null, string ticker = null, string tag = null, string sic = null, string cik = null, string edinetcode = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string aid = null, string section = null, string disclosure = null, string reportElement = null, string label = null, string language = null, string labelRole = null, string kind = null, bool? eliminateReportElementDuplicates = null, string profileName = null, bool? count = null, int? top = null, bool? skip = null);
  
        /// <summary>
        /// Retrieve labels for the supplied components and report elements
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="fiscalYear">The fiscal year focus of the components to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period focus of the components to retrieve (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="aid">The id of the filings for which to retrieve components</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="disclosure">The disclosure to search for (e.g. BalanceSheet)</param>
        /// <param name="reportElement">The name of the report element to search for (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock). Exact match, except for the SEC profile where it performs full text search in English</param>
        /// <param name="language">A language code</param>
        /// <param name="labelRole">A label role</param>
        /// <param name="kind">Filters by concept kind (default: no filtering)</param>
        /// <param name="eliminateReportElementDuplicates">Whether to eliminate (concept name, language, label role) duplicates. By default no duplicate elimination</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListLabelsAsync (string token, string eid = null, string ticker = null, string tag = null, string sic = null, string cik = null, string edinetcode = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string aid = null, string section = null, string disclosure = null, string reportElement = null, string label = null, string language = null, string labelRole = null, string kind = null, bool? eliminateReportElementDuplicates = null, string profileName = null, bool? count = null, int? top = null, bool? skip = null);
        
        /// <summary>
        /// Retrieve the model structure for a given component. A component can be selected in three ways. (1) by component id (cid), (2) by accession number and disclosure (aid and disclosure), or (3) by CIK, fiscal year, fiscal period, and disclosure (cik, fiscalYear, fiscalPeriod, and disclosure).
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="aid">The accession number of the filing. This parameter needs to be used together with the disclosure parameter to identify a component</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="hypercube">A hypercube name to further filter components</param>
        /// <param name="fiscalYear">The fiscal year of the filing (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period of the filing (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="disclosure">The disclosure of the component (e.g. BalanceSheet)</param>
        /// <param name="reportElement">Filters only those components that contained the supplied report element (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <param name="language">A language code</param>
        /// <returns>Object</returns>
        Object ListModelStructure (string token, string aid = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string section = null, string hypercube = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string disclosure = null, string reportElement = null, string label = null, bool? count = null, int? top = null, bool? skip = null, string language = null);
  
        /// <summary>
        /// Retrieve the model structure for a given component. A component can be selected in three ways. (1) by component id (cid), (2) by accession number and disclosure (aid and disclosure), or (3) by CIK, fiscal year, fiscal period, and disclosure (cik, fiscalYear, fiscalPeriod, and disclosure).
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="aid">The accession number of the filing. This parameter needs to be used together with the disclosure parameter to identify a component</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="hypercube">A hypercube name to further filter components</param>
        /// <param name="fiscalYear">The fiscal year of the filing (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period of the filing (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="disclosure">The disclosure of the component (e.g. BalanceSheet)</param>
        /// <param name="reportElement">Filters only those components that contained the supplied report element (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <param name="language">A language code</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListModelStructureAsync (string token, string aid = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string section = null, string hypercube = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string disclosure = null, string reportElement = null, string label = null, bool? count = null, int? top = null, bool? skip = null, string language = null);
        
        /// <summary>
        /// Retrieve a summary for all networks of a given filing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="fiscalYear">The fiscal year focus of the components to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period focus of the components to retrieve (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="aid">The id of the filings for which to retrieve components</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="hypercube">A hypercube name to further filter networks</param>
        /// <param name="disclosure">The disclosure to search for (e.g. BalanceSheet)</param>
        /// <param name="reportElement">The name of the report element to search for (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <returns>Object</returns>
        Object ListNetworks (string token, string eid = null, string ticker = null, string tag = null, string sic = null, string cik = null, string edinetcode = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string aid = null, string section = null, string hypercube = null, string disclosure = null, string reportElement = null, string label = null, string profileName = null, bool? count = null, int? top = null, bool? skip = null);
  
        /// <summary>
        /// Retrieve a summary for all networks of a given filing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="fiscalYear">The fiscal year focus of the components to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period focus of the components to retrieve (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="aid">The id of the filings for which to retrieve components</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="hypercube">A hypercube name to further filter networks</param>
        /// <param name="disclosure">The disclosure to search for (e.g. BalanceSheet)</param>
        /// <param name="reportElement">The name of the report element to search for (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListNetworksAsync (string token, string eid = null, string ticker = null, string tag = null, string sic = null, string cik = null, string edinetcode = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string aid = null, string section = null, string hypercube = null, string disclosure = null, string reportElement = null, string label = null, string profileName = null, bool? count = null, int? top = null, bool? skip = null);
        
        /// <summary>
        /// Retrieve the periods of the filings filed by a particular entity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="tag">A tag to filter</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">A ticker symbol</param>
        /// <param name="sic">The industry group</param>
        /// <param name="aid">An Archive ID (a value of the xbrl28:Archive aspect)</param>
        /// <param name="fiscalYear">The fiscal year focus of the filings to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period focus of the filings to retrieve (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <returns>Object</returns>
        Object ListPeriods (string token, string tag = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string sic = null, string aid = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, bool? count = null, int? top = null, bool? skip = null);
  
        /// <summary>
        /// Retrieve the periods of the filings filed by a particular entity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="tag">A tag to filter</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">A ticker symbol</param>
        /// <param name="sic">The industry group</param>
        /// <param name="aid">An Archive ID (a value of the xbrl28:Archive aspect)</param>
        /// <param name="fiscalYear">The fiscal year focus of the filings to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period focus of the filings to retrieve (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListPeriodsAsync (string token, string tag = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string sic = null, string aid = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, bool? count = null, int? top = null, bool? skip = null);
        
        /// <summary>
        /// Retrieve the report elements contained in a set of filings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="tag">A tag to filter entities</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">A ticker symbols</param>
        /// <param name="sic">The industry group</param>
        /// <param name="fiscalYear">The fiscal year focus of the component to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period focus of the component to retrieve (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="aid">The id of the filing</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="disclosure">The disclosure to search for (e.g. BalanceSheet)</param>
        /// <param name="onlyNames">Whether only the names of the report elements should be returned. If so, the values don&#39;t contain duplicates. (default: false)</param>
        /// <param name="name">The name of the report element to return (e.g. us-gaap:Assets)</param>
        /// <param name="report">The report to use as a context to retrieve the report elements. In particular, concept maps found in this report will be used. (default: none)</param>
        /// <param name="label">A search term to search in the labels of report elements (e.g. stock)</param>
        /// <param name="onlyTextBlocks">Filters by text block/not text block (default: no filtering)</param>
        /// <param name="kind">Filters by concept kind (default: no filtering)</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <param name="language">A language code</param>
        /// <param name="contentType">Content-Type of the request</param>
        /// <returns>Object</returns>
        Object ListReportElements (string token, string tag = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string sic = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string aid = null, string section = null, string disclosure = null, bool? onlyNames = null, string name = null, string report = null, string label = null, bool? onlyTextBlocks = null, string kind = null, bool? count = null, int? top = null, bool? skip = null, string language = null, string contentType = null);
  
        /// <summary>
        /// Retrieve the report elements contained in a set of filings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="tag">A tag to filter entities</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">A ticker symbols</param>
        /// <param name="sic">The industry group</param>
        /// <param name="fiscalYear">The fiscal year focus of the component to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period focus of the component to retrieve (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="aid">The id of the filing</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="disclosure">The disclosure to search for (e.g. BalanceSheet)</param>
        /// <param name="onlyNames">Whether only the names of the report elements should be returned. If so, the values don&#39;t contain duplicates. (default: false)</param>
        /// <param name="name">The name of the report element to return (e.g. us-gaap:Assets)</param>
        /// <param name="report">The report to use as a context to retrieve the report elements. In particular, concept maps found in this report will be used. (default: none)</param>
        /// <param name="label">A search term to search in the labels of report elements (e.g. stock)</param>
        /// <param name="onlyTextBlocks">Filters by text block/not text block (default: no filtering)</param>
        /// <param name="kind">Filters by concept kind (default: no filtering)</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <param name="language">A language code</param>
        /// <param name="contentType">Content-Type of the request</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListReportElementsAsync (string token, string tag = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string sic = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string aid = null, string section = null, string disclosure = null, bool? onlyNames = null, string name = null, string report = null, string label = null, bool? onlyTextBlocks = null, string kind = null, bool? count = null, int? top = null, bool? skip = null, string language = null, string contentType = null);
        
        /// <summary>
        /// Retrieve a summary for all sections of a given filing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="fiscalYear">The fiscal year focus of the components to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period focus of the components to retrieve (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="aid">The id of the filings for which to retrieve components</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="disclosure">The disclosure to search for (e.g. BalanceSheet)</param>
        /// <param name="reportElement">The name of the report element to search for (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <param name="validate">Whether to run validation on the output components (default: false). Adds a column ValidationErrors</param>
        /// <param name="language">A language code</param>
        /// <returns>Object</returns>
        Object ListSections (string token, string eid = null, string ticker = null, string tag = null, string sic = null, string cik = null, string edinetcode = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string aid = null, string section = null, string disclosure = null, string reportElement = null, string label = null, string profileName = null, bool? count = null, int? top = null, bool? skip = null, bool? validate = null, string language = null);
  
        /// <summary>
        /// Retrieve a summary for all sections of a given filing
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="fiscalYear">The fiscal year focus of the components to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period focus of the components to retrieve (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="aid">The id of the filings for which to retrieve components</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="disclosure">The disclosure to search for (e.g. BalanceSheet)</param>
        /// <param name="reportElement">The name of the report element to search for (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <param name="validate">Whether to run validation on the output components (default: false). Adds a column ValidationErrors</param>
        /// <param name="language">A language code</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListSectionsAsync (string token, string eid = null, string ticker = null, string tag = null, string sic = null, string cik = null, string edinetcode = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string aid = null, string section = null, string disclosure = null, string reportElement = null, string label = null, string profileName = null, bool? count = null, int? top = null, bool? skip = null, bool? validate = null, string language = null);
        
        /// <summary>
        /// Retrieve the business friendly Spreadsheet for a given component. A component can be selected in three ways. (1) by component id (cid), (2) by accession number and disclosure (aid and disclosure), or (3) by CIK, fiscal year, fiscal period, and disclosure (cik, fiscalYear, fiscalPeriod, and disclosure).
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="aid">The accession number of the filing. This parameter needs to be used together with the disclosure parameter to identify a component</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">A tag to filter</param>
        /// <param name="sic">The industry group</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="fiscalYear">The fiscal year of the filing (default: no filtering). In override mode, also filters facts</param>
        /// <param name="fiscalPeriod">The fiscal period of the filing (default: no filtering). In override mode, also filters facts</param>
        /// <param name="fiscalPeriodType">In override mode, the fiscal period type of the facts to filter (default: no filtering). Can select multiple</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="disclosure">The disclosure of the component (e.g. BalanceSheet)</param>
        /// <param name="reportElement">Filters only those components that contained the supplied report element (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false)</param>
        /// <param name="eliminate">Whether  to eliminate empty rows/columns</param>
        /// <param name="merge">Whether to merge components if multiple are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved</param>
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to the component&#39;s rules (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="_override">Whether the fiscalYear/fiscalPeriod/fiscalPeriodType parameters should also be used to filter facts (default: false)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <returns>Object</returns>
        Object SpreadsheetForComponent (string token, string aid = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string section = null, string fiscalYear = null, string fiscalPeriod = null, string fiscalPeriodType = null, string filingKind = null, string disclosure = null, string reportElement = null, string label = null, bool? validate = null, bool? eliminate = null, bool? merge = null, string mostRecentVersionAspect = null, string additionalRules = null, bool? _override = null, string profileName = null);
  
        /// <summary>
        /// Retrieve the business friendly Spreadsheet for a given component. A component can be selected in three ways. (1) by component id (cid), (2) by accession number and disclosure (aid and disclosure), or (3) by CIK, fiscal year, fiscal period, and disclosure (cik, fiscalYear, fiscalPeriod, and disclosure).
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="aid">The accession number of the filing. This parameter needs to be used together with the disclosure parameter to identify a component</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">A tag to filter</param>
        /// <param name="sic">The industry group</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="fiscalYear">The fiscal year of the filing (default: no filtering). In override mode, also filters facts</param>
        /// <param name="fiscalPeriod">The fiscal period of the filing (default: no filtering). In override mode, also filters facts</param>
        /// <param name="fiscalPeriodType">In override mode, the fiscal period type of the facts to filter (default: no filtering). Can select multiple</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="disclosure">The disclosure of the component (e.g. BalanceSheet)</param>
        /// <param name="reportElement">Filters only those components that contained the supplied report element (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false)</param>
        /// <param name="eliminate">Whether  to eliminate empty rows/columns</param>
        /// <param name="merge">Whether to merge components if multiple are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved</param>
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to the component&#39;s rules (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="_override">Whether the fiscalYear/fiscalPeriod/fiscalPeriodType parameters should also be used to filter facts (default: false)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> SpreadsheetForComponentAsync (string token, string aid = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string section = null, string fiscalYear = null, string fiscalPeriod = null, string fiscalPeriodType = null, string filingKind = null, string disclosure = null, string reportElement = null, string label = null, bool? validate = null, bool? eliminate = null, bool? merge = null, string mostRecentVersionAspect = null, string additionalRules = null, bool? _override = null, string profileName = null);
        
        /// <summary>
        /// Retrieve the business-friendly spreadsheet for a report. Filters can be overriden. Filters MUST be overriden if the report is not already filtering.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="fiscalYear">The fiscal year of the fact to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period of the fact to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriodType">The fiscal period type of the fact to retrieve (default: no filtering). Can select multiple, but preferably not both YTD and QTD</param>
        /// <param name="report">The name of the report to be used (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="eliminate">Wwether to eliminate empty rows/colummns</param>
        /// <param name="validate">Validate and stamp facts accordingly</param>
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <returns>Object</returns>
        Object ListSpreadsheetForReport (string token, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string fiscalYear = null, string fiscalPeriod = null, string fiscalPeriodType = null, string report = null, bool? eliminate = null, bool? validate = null, string mostRecentVersionAspect = null, string profileName = null);
  
        /// <summary>
        /// Retrieve the business-friendly spreadsheet for a report. Filters can be overriden. Filters MUST be overriden if the report is not already filtering.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="token">The token of the current session</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="fiscalYear">The fiscal year of the fact to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period of the fact to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriodType">The fiscal period type of the fact to retrieve (default: no filtering). Can select multiple, but preferably not both YTD and QTD</param>
        /// <param name="report">The name of the report to be used (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="eliminate">Wwether to eliminate empty rows/colummns</param>
        /// <param name="validate">Validate and stamp facts accordingly</param>
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> ListSpreadsheetForReportAsync (string token, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string fiscalYear = null, string fiscalPeriod = null, string fiscalPeriodType = null, string report = null, bool? eliminate = null, bool? validate = null, string mostRecentVersionAspect = null, string profileName = null);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DataApi : IDataApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DataApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DataApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Retrieve a summary for all components of a given filing 
        /// </summary>
        /// <param name="token">The token of the current session</param> 
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param> 
        /// <param name="ticker">The ticker of the entity</param> 
        /// <param name="tag">The tag to filter entities</param> 
        /// <param name="sic">The industry group</param> 
        /// <param name="cik">A CIK number</param> 
        /// <param name="edinetcode">An EDINET Code</param> 
        /// <param name="fiscalYear">The fiscal year focus of the components to retrieve (default: no filtering)</param> 
        /// <param name="fiscalPeriod">The fiscal period focus of the components to retrieve (default: no filtering)</param> 
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param> 
        /// <param name="aid">The id of the filings for which to retrieve components</param> 
        /// <param name="section">The URI of a particular section</param> 
        /// <param name="hypercube">An hypercube name to further filter components</param> 
        /// <param name="disclosure">The disclosure to search for (e.g. BalanceSheet)</param> 
        /// <param name="reportElement">The name of the report element to search for (e.g. us-gaap:Goodwill)</param> 
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param> 
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param> 
        /// <param name="count">If true, only outputs statistics (default is false)</param> 
        /// <param name="top">Output only the first [top] results (default: no limit)</param> 
        /// <param name="skip">Skip the first [skip] results (default: 0)</param> 
        /// <param name="validate">Whether to run validation on the output components (default: false). Adds a column ValidationErrors</param> 
        /// <param name="language">A language code</param> 
        /// <returns>Object</returns>            
        public Object ListComponents (string token, string eid = null, string ticker = null, string tag = null, string sic = null, string cik = null, string edinetcode = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string aid = null, string section = null, string hypercube = null, string disclosure = null, string reportElement = null, string label = null, string profileName = null, bool? count = null, int? top = null, bool? skip = null, bool? validate = null, string language = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListComponents");
            
    
            var path = "/api/components";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
            
            
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListComponents: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListComponents: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve a summary for all components of a given filing 
        /// </summary>
        /// <param name="token">The token of the current session</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="fiscalYear">The fiscal year focus of the components to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period focus of the components to retrieve (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="aid">The id of the filings for which to retrieve components</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="hypercube">An hypercube name to further filter components</param>
        /// <param name="disclosure">The disclosure to search for (e.g. BalanceSheet)</param>
        /// <param name="reportElement">The name of the report element to search for (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <param name="validate">Whether to run validation on the output components (default: false). Adds a column ValidationErrors</param>
        /// <param name="language">A language code</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListComponentsAsync (string token, string eid = null, string ticker = null, string tag = null, string sic = null, string cik = null, string edinetcode = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string aid = null, string section = null, string hypercube = null, string disclosure = null, string reportElement = null, string label = null, string profileName = null, bool? count = null, int? top = null, bool? skip = null, bool? validate = null, string language = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListComponents");
            
    
            var path = "/api/components";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
                        
            
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListComponents: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve metadata about the entities that submit filings. These entities are also referred to by facts with the xbrl:Entity aspect, of which the values are called Entity IDs (EIDs). One entity might have several EIDs. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API</param> 
        /// <param name="tag">Includes in the results entities that have the supplied tags. A tag is often a stock index</param> 
        /// <param name="eid">Includes in the results the entity with the supplied Entity ID (scheme + local name)</param> 
        /// <param name="cik">Includes in the results the entity with the supplied CIK number</param> 
        /// <param name="edinetcode">Includes in the results the entity with the supplied EDINET Code</param> 
        /// <param name="sic">Includes in the results the entity with the supplied industry group</param> 
        /// <param name="ticker">Includes in the results the entity with the supplied ticker symbol</param> 
        /// <param name="entitySearch">Includes in the results the entities whose name match this full-text query</param> 
        /// <param name="entitySearchOffset">Includes in the results the entities whose name match the entity-search parameter skipping the first entity-search-offset results (default: 0)</param> 
        /// <param name="entitySearchLimit">Includes in the results the entities whose name match the entity-search parameter limited to a maximum of entity-search-limit results (default: 10)</param> 
        /// <param name="language">Specifies in which language to perform the entity-search query (default: en)</param> 
        /// <param name="count">If true, only outputs statistics (default is false)</param> 
        /// <param name="top">Output only the first [top] results (default: no limit)</param> 
        /// <param name="skip">Skip the first [skip] results (default: 0)</param> 
        /// <returns>Object</returns>            
        public Object ListEntities (string token, string tag = null, string eid = null, string cik = null, string edinetcode = null, string sic = null, string ticker = null, string entitySearch = null, int? entitySearchOffset = null, int? entitySearchLimit = null, string language = null, bool? count = null, int? top = null, bool? skip = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListEntities");
            
    
            var path = "/api/entities";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
            
            
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (entitySearch != null) queryParams.Add("entity-search", ApiClient.ParameterToString(entitySearch)); // query parameter
            if (entitySearchOffset != null) queryParams.Add("entity-search-offset", ApiClient.ParameterToString(entitySearchOffset)); // query parameter
            if (entitySearchLimit != null) queryParams.Add("entity-search-limit", ApiClient.ParameterToString(entitySearchLimit)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListEntities: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListEntities: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve metadata about the entities that submit filings. These entities are also referred to by facts with the xbrl:Entity aspect, of which the values are called Entity IDs (EIDs). One entity might have several EIDs. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API</param>
        /// <param name="tag">Includes in the results entities that have the supplied tags. A tag is often a stock index</param>
        /// <param name="eid">Includes in the results the entity with the supplied Entity ID (scheme + local name)</param>
        /// <param name="cik">Includes in the results the entity with the supplied CIK number</param>
        /// <param name="edinetcode">Includes in the results the entity with the supplied EDINET Code</param>
        /// <param name="sic">Includes in the results the entity with the supplied industry group</param>
        /// <param name="ticker">Includes in the results the entity with the supplied ticker symbol</param>
        /// <param name="entitySearch">Includes in the results the entities whose name match this full-text query</param>
        /// <param name="entitySearchOffset">Includes in the results the entities whose name match the entity-search parameter skipping the first entity-search-offset results (default: 0)</param>
        /// <param name="entitySearchLimit">Includes in the results the entities whose name match the entity-search parameter limited to a maximum of entity-search-limit results (default: 10)</param>
        /// <param name="language">Specifies in which language to perform the entity-search query (default: en)</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListEntitiesAsync (string token, string tag = null, string eid = null, string cik = null, string edinetcode = null, string sic = null, string ticker = null, string entitySearch = null, int? entitySearchOffset = null, int? entitySearchLimit = null, string language = null, bool? count = null, int? top = null, bool? skip = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListEntities");
            
    
            var path = "/api/entities";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
                        
            
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (entitySearch != null) queryParams.Add("entity-search", ApiClient.ParameterToString(entitySearch)); // query parameter
            if (entitySearchOffset != null) queryParams.Add("entity-search-offset", ApiClient.ParameterToString(entitySearchOffset)); // query parameter
            if (entitySearchLimit != null) queryParams.Add("entity-search-limit", ApiClient.ParameterToString(entitySearchLimit)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListEntities: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve one or more facts for a combination of filings. 
        /// </summary>
        /// <param name="token">The token of the current session</param> 
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param> 
        /// <param name="cik">A CIK number</param> 
        /// <param name="edinetcode">An EDINET Code</param> 
        /// <param name="ticker">The ticker of the entity</param> 
        /// <param name="tag">The tag to filter entities</param> 
        /// <param name="sic">The industry group</param> 
        /// <param name="aid">The id of the filing</param> 
        /// <param name="fiscalYear">The fiscal year of the fact to retrieve (default: no filtering)</param> 
        /// <param name="concept">The name of the concept to retrieve the fact for (alternatively, a parameter with name xbrl:Concept can be used)</param> 
        /// <param name="fiscalPeriod">The fiscal period of the fact to retrieve (default: no filtering)</param> 
        /// <param name="fiscalPeriodType">The fiscal period type of the fact to retrieve (default: no filtering). Can select multiple</param> 
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none)</param> 
        /// <param name="additionalRules">The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts)</param> 
        /// <param name="labels">Whether human readable labels should be included for concepts in each fact. (default: false)</param> 
        /// <param name="open">Whether the query has open hypercube semantics. (default: false)</param> 
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param> 
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param> 
        /// <param name="dimensions">A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string</param> 
        /// <param name="dimensionTypes">Sets the given dimensions to be typed dimensions with the specified type. (Default: xbrl:Entity/xbrl:Period/xbrl:Unit/xbrl28:Archive are typed string, others are explicit dimensions. Some further dimensions may have default types depending on the profile.). Each key is in the form prefix:dimension::type, each value is a string</param> 
        /// <param name="defaultDimensionValues">Specifies the default value of the given dimensions that should be returned if the dimension was not provided explicitly for a fact. Each key is in the form  prefix:dimension::default, each value is a string</param> 
        /// <param name="dimensionSlicers">Specifies whether the given dimensions are slicers (true) or a dicers (false). Slicer dimensions do not appear in the output fact table (default: false). Each key is in the form prefix:dimension::slicer, each value is a boolean</param> 
        /// <param name="dimensionColumns">Specifies the position at which dicer dimensions appear in the output fact table (default: arbitrary order). Each key is in the form prefix:dimension::column, each value is an integer</param> 
        /// <param name="count">If true, only outputs statistics (default is false)</param> 
        /// <param name="top">Output only the first [top] results (default: no limit)</param> 
        /// <param name="skip">Skip the first [skip] results (default: 0)</param> 
        /// <returns>Object</returns>            
        public Object ListFacts (string token, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string aid = null, string fiscalYear = null, string concept = null, string fiscalPeriod = null, string fiscalPeriodType = null, string report = null, string additionalRules = null, bool? labels = null, bool? open = null, string mostRecentVersionAspect = null, string profileName = null, Dictionary<string, string> dimensions = null, Dictionary<string, string> dimensionTypes = null, Dictionary<string, string> defaultDimensionValues = null, Dictionary<string, bool?> dimensionSlicers = null, Dictionary<string, int?> dimensionColumns = null, bool? count = null, int? top = null, bool? skip = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListFacts");
            
    
            var path = "/api/facts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
            
            
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (concept != null) queryParams.Add("concept", ApiClient.ParameterToString(concept)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (report != null) queryParams.Add("report", ApiClient.ParameterToString(report)); // query parameter
            if (additionalRules != null) queryParams.Add("additional-rules", ApiClient.ParameterToString(additionalRules)); // query parameter
            if (labels != null) queryParams.Add("labels", ApiClient.ParameterToString(labels)); // query parameter
            if (open != null) queryParams.Add("open", ApiClient.ParameterToString(open)); // query parameter
            if (mostRecentVersionAspect != null) queryParams.Add("most-recent-version-aspect", ApiClient.ParameterToString(mostRecentVersionAspect)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            if (dimensions != null) ApiClient.AddPatternQueryParameters(dimensions, "^[^:]+:[^:]+$", queryParams); // pattern query parameter
            if (dimensionTypes != null) ApiClient.AddPatternQueryParameters(dimensionTypes, "^[^:]+:[^:]+::type$", queryParams); // pattern query parameter
            if (defaultDimensionValues != null) ApiClient.AddPatternQueryParameters(defaultDimensionValues, "^[^:]+:[^:]+::default$", queryParams); // pattern query parameter
            if (dimensionSlicers != null) ApiClient.AddPatternQueryParameters(dimensionSlicers, "^[^:]+:[^:]+::slicer$", queryParams); // pattern query parameter
            if (dimensionColumns != null) ApiClient.AddPatternQueryParameters(dimensionColumns, "^[^:]+:[^:]+::column$", queryParams); // pattern query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve one or more facts for a combination of filings. 
        /// </summary>
        /// <param name="token">The token of the current session</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="aid">The id of the filing</param>
        /// <param name="fiscalYear">The fiscal year of the fact to retrieve (default: no filtering)</param>
        /// <param name="concept">The name of the concept to retrieve the fact for (alternatively, a parameter with name xbrl:Concept can be used)</param>
        /// <param name="fiscalPeriod">The fiscal period of the fact to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriodType">The fiscal period type of the fact to retrieve (default: no filtering). Can select multiple</param>
        /// <param name="report">The report to use as a context to retrieve the facts. In particular, concept maps and rules found in this report will be used. (default: none)</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to a report&#39;s rules (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="labels">Whether human readable labels should be included for concepts in each fact. (default: false)</param>
        /// <param name="open">Whether the query has open hypercube semantics. (default: false)</param>
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <param name="dimensions">A set of dimension names and values used for filtering. As a value, the value of the dimension or ALL can be provided if all facts with this dimension should be retrieved. Each key is in the form prefix:dimension, each value is a string</param>
        /// <param name="dimensionTypes">Sets the given dimensions to be typed dimensions with the specified type. (Default: xbrl:Entity/xbrl:Period/xbrl:Unit/xbrl28:Archive are typed string, others are explicit dimensions. Some further dimensions may have default types depending on the profile.). Each key is in the form prefix:dimension::type, each value is a string</param>
        /// <param name="defaultDimensionValues">Specifies the default value of the given dimensions that should be returned if the dimension was not provided explicitly for a fact. Each key is in the form  prefix:dimension::default, each value is a string</param>
        /// <param name="dimensionSlicers">Specifies whether the given dimensions are slicers (true) or a dicers (false). Slicer dimensions do not appear in the output fact table (default: false). Each key is in the form prefix:dimension::slicer, each value is a boolean</param>
        /// <param name="dimensionColumns">Specifies the position at which dicer dimensions appear in the output fact table (default: arbitrary order). Each key is in the form prefix:dimension::column, each value is an integer</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListFactsAsync (string token, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string aid = null, string fiscalYear = null, string concept = null, string fiscalPeriod = null, string fiscalPeriodType = null, string report = null, string additionalRules = null, bool? labels = null, bool? open = null, string mostRecentVersionAspect = null, string profileName = null, Dictionary<string, string> dimensions = null, Dictionary<string, string> dimensionTypes = null, Dictionary<string, string> defaultDimensionValues = null, Dictionary<string, bool?> dimensionSlicers = null, Dictionary<string, int?> dimensionColumns = null, bool? count = null, int? top = null, bool? skip = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListFacts");
            
    
            var path = "/api/facts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
                        
            
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (concept != null) queryParams.Add("concept", ApiClient.ParameterToString(concept)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (report != null) queryParams.Add("report", ApiClient.ParameterToString(report)); // query parameter
            if (additionalRules != null) queryParams.Add("additional-rules", ApiClient.ParameterToString(additionalRules)); // query parameter
            if (labels != null) queryParams.Add("labels", ApiClient.ParameterToString(labels)); // query parameter
            if (open != null) queryParams.Add("open", ApiClient.ParameterToString(open)); // query parameter
            if (mostRecentVersionAspect != null) queryParams.Add("most-recent-version-aspect", ApiClient.ParameterToString(mostRecentVersionAspect)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            if (dimensions != null) ApiClient.AddPatternQueryParameters(dimensions, "^[^:]+:[^:]+$", queryParams); // pattern query parameter
            if (dimensionTypes != null) ApiClient.AddPatternQueryParameters(dimensionTypes, "^[^:]+:[^:]+::type$", queryParams); // pattern query parameter
            if (defaultDimensionValues != null) ApiClient.AddPatternQueryParameters(defaultDimensionValues, "^[^:]+:[^:]+::default$", queryParams); // pattern query parameter
            if (dimensionSlicers != null) ApiClient.AddPatternQueryParameters(dimensionSlicers, "^[^:]+:[^:]+::slicer$", queryParams); // pattern query parameter
            if (dimensionColumns != null) ApiClient.AddPatternQueryParameters(dimensionColumns, "^[^:]+:[^:]+::column$", queryParams); // pattern query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFacts: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Add a fact to a filing. 
        /// </summary>
        /// <param name="token">The token of the current session</param> 
        /// <param name="fact">The fact object</param> 
        /// <param name="aid">The id of the filing</param> 
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param> 
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param> 
        /// <returns>Object</returns>            
        public Object AddFacts (string token, Object fact, string aid = null, string mostRecentVersionAspect = null, string profileName = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddFacts");
            
            // verify the required parameter 'fact' is set
            if (fact == null) throw new ApiException(400, "Missing required parameter 'fact' when calling AddFacts");
            
    
            var path = "/api/facts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
            
            
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (mostRecentVersionAspect != null) queryParams.Add("most-recent-version-aspect", ApiClient.ParameterToString(mostRecentVersionAspect)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            postBody = ApiClient.Serialize(fact); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddFacts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddFacts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Add a fact to a filing. 
        /// </summary>
        /// <param name="token">The token of the current session</param>
        /// <param name="fact">The fact object</param>
        /// <param name="aid">The id of the filing</param>
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> AddFactsAsync (string token, Object fact, string aid = null, string mostRecentVersionAspect = null, string profileName = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling AddFacts");
            // verify the required parameter 'fact' is set
            if (fact == null) throw new ApiException(400, "Missing required parameter 'fact' when calling AddFacts");
            
    
            var path = "/api/facts";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
                        
            
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (mostRecentVersionAspect != null) queryParams.Add("most-recent-version-aspect", ApiClient.ParameterToString(mostRecentVersionAspect)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            postBody = ApiClient.Serialize(fact); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddFacts: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve the fact table for a given component. A component can be selected in three ways. (1) by component id (cid), (2) by accession number and disclosure (aid and disclosure), or (3) by CIK, fiscal year, fiscal period, and disclosure (cik, fiscalYear, fiscalPeriod, and disclosure). 
        /// </summary>
        /// <param name="token">The token of the current session</param> 
        /// <param name="aid">The accession number of the filing. This parameter needs to be used together with the disclosure parameter to identify a component</param> 
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param> 
        /// <param name="cik">A CIK number</param> 
        /// <param name="edinetcode">An EDINET Code</param> 
        /// <param name="ticker">The ticker of the entity</param> 
        /// <param name="tag">A tag to filter</param> 
        /// <param name="sic">The industry group</param> 
        /// <param name="section">The URI of a particular section</param> 
        /// <param name="fiscalYear">The fiscal year of the filing (default: no filtering). In override mode, also filters facts</param> 
        /// <param name="fiscalPeriod">The fiscal period of the filing (default: no filtering). In override mode, also filters facts</param> 
        /// <param name="fiscalPeriodType">In override mode, the fiscal period type of the facts to filter (default: no filtering). Can select multiple</param> 
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param> 
        /// <param name="disclosure">The disclosure of the component (e.g. BalanceSheet)</param> 
        /// <param name="reportElement">Filters only those components that contained the supplied report element (e.g. us-gaap:Goodwill)</param> 
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param> 
        /// <param name="validate">Whether or not to stamp facts for validity (default is false)</param> 
        /// <param name="merge">Whether to merge components if multiple are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved</param> 
        /// <param name="count">If true, only outputs statistics (default is false)</param> 
        /// <param name="top">Output only the first [top] results (default: no limit)</param> 
        /// <param name="skip">Skip the first [skip] results (default: 0)</param> 
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param> 
        /// <param name="additionalRules">The name of a report from which to use rules in addition to the component&#39;s rules (e.g. FundamentalAccountingConcepts)</param> 
        /// <param name="labels">Whether human readable labels should be included for concepts in each fact. (default: false)</param> 
        /// <param name="language">A language code</param> 
        /// <param name="_override">Whether the fiscalYear/fiscalPeriod/fiscalPeriodType parameters should also be used to filter facts (default: false)</param> 
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param> 
        /// <returns>Object</returns>            
        public Object ListFactTable (string token, string aid = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string section = null, string fiscalYear = null, string fiscalPeriod = null, string fiscalPeriodType = null, string filingKind = null, string disclosure = null, string reportElement = null, string label = null, bool? validate = null, bool? merge = null, bool? count = null, int? top = null, bool? skip = null, string mostRecentVersionAspect = null, string additionalRules = null, bool? labels = null, string language = null, bool? _override = null, string profileName = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListFactTable");
            
    
            var path = "/api/facttable-for-component";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
            
            
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (merge != null) queryParams.Add("merge", ApiClient.ParameterToString(merge)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (mostRecentVersionAspect != null) queryParams.Add("most-recent-version-aspect", ApiClient.ParameterToString(mostRecentVersionAspect)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (additionalRules != null) queryParams.Add("additional-rules", ApiClient.ParameterToString(additionalRules)); // query parameter
            if (labels != null) queryParams.Add("labels", ApiClient.ParameterToString(labels)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (_override != null) queryParams.Add("override", ApiClient.ParameterToString(_override)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFactTable: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFactTable: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve the fact table for a given component. A component can be selected in three ways. (1) by component id (cid), (2) by accession number and disclosure (aid and disclosure), or (3) by CIK, fiscal year, fiscal period, and disclosure (cik, fiscalYear, fiscalPeriod, and disclosure). 
        /// </summary>
        /// <param name="token">The token of the current session</param>
        /// <param name="aid">The accession number of the filing. This parameter needs to be used together with the disclosure parameter to identify a component</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">A tag to filter</param>
        /// <param name="sic">The industry group</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="fiscalYear">The fiscal year of the filing (default: no filtering). In override mode, also filters facts</param>
        /// <param name="fiscalPeriod">The fiscal period of the filing (default: no filtering). In override mode, also filters facts</param>
        /// <param name="fiscalPeriodType">In override mode, the fiscal period type of the facts to filter (default: no filtering). Can select multiple</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="disclosure">The disclosure of the component (e.g. BalanceSheet)</param>
        /// <param name="reportElement">Filters only those components that contained the supplied report element (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false)</param>
        /// <param name="merge">Whether to merge components if multiple are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to the component&#39;s rules (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="labels">Whether human readable labels should be included for concepts in each fact. (default: false)</param>
        /// <param name="language">A language code</param>
        /// <param name="_override">Whether the fiscalYear/fiscalPeriod/fiscalPeriodType parameters should also be used to filter facts (default: false)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListFactTableAsync (string token, string aid = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string section = null, string fiscalYear = null, string fiscalPeriod = null, string fiscalPeriodType = null, string filingKind = null, string disclosure = null, string reportElement = null, string label = null, bool? validate = null, bool? merge = null, bool? count = null, int? top = null, bool? skip = null, string mostRecentVersionAspect = null, string additionalRules = null, bool? labels = null, string language = null, bool? _override = null, string profileName = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListFactTable");
            
    
            var path = "/api/facttable-for-component";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
                        
            
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (merge != null) queryParams.Add("merge", ApiClient.ParameterToString(merge)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (mostRecentVersionAspect != null) queryParams.Add("most-recent-version-aspect", ApiClient.ParameterToString(mostRecentVersionAspect)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (additionalRules != null) queryParams.Add("additional-rules", ApiClient.ParameterToString(additionalRules)); // query parameter
            if (labels != null) queryParams.Add("labels", ApiClient.ParameterToString(labels)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (_override != null) queryParams.Add("override", ApiClient.ParameterToString(_override)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFactTable: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve the fact table for a given report. Filters can be overriden. Filters MUST be overriden if the report is not already filtering. 
        /// </summary>
        /// <param name="token">The token of the current session</param> 
        /// <param name="cik">A CIK number</param> 
        /// <param name="edinetcode">An EDINET Code</param> 
        /// <param name="ticker">The ticker of the entity</param> 
        /// <param name="tag">The tag to filter entities</param> 
        /// <param name="sic">The industry group</param> 
        /// <param name="fiscalYear">The fiscal year of the fact to retrieve (default: no filtering)</param> 
        /// <param name="fiscalPeriod">The fiscal period of the fact to retrieve (default: no filtering). Can select multiple</param> 
        /// <param name="fiscalPeriodType">The fiscal period type of the fact to retrieve (default: no filtering). Can select multiple</param> 
        /// <param name="report">The name of the report to be used (e.g. FundamentalAccountingConcepts)</param> 
        /// <param name="validate">Validate and stamp facts accordingly</param> 
        /// <param name="labels">Whether human readable labels should be included for concepts in each fact. (default: false)</param> 
        /// <param name="language">A language code</param> 
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param> 
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param> 
        /// <param name="count">If true, only outputs statistics (default is false)</param> 
        /// <param name="top">Output only the first [top] results (default: no limit)</param> 
        /// <param name="skip">Skip the first [skip] results (default: 0)</param> 
        /// <returns>Object</returns>            
        public Object ListFactTableForReport (string token, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string fiscalYear = null, string fiscalPeriod = null, string fiscalPeriodType = null, string report = null, bool? validate = null, bool? labels = null, string language = null, string mostRecentVersionAspect = null, string profileName = null, bool? count = null, int? top = null, bool? skip = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListFactTableForReport");
            
    
            var path = "/api/facttable-for-report";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
            
            
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (report != null) queryParams.Add("report", ApiClient.ParameterToString(report)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (labels != null) queryParams.Add("labels", ApiClient.ParameterToString(labels)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (mostRecentVersionAspect != null) queryParams.Add("most-recent-version-aspect", ApiClient.ParameterToString(mostRecentVersionAspect)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFactTableForReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFactTableForReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve the fact table for a given report. Filters can be overriden. Filters MUST be overriden if the report is not already filtering. 
        /// </summary>
        /// <param name="token">The token of the current session</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="fiscalYear">The fiscal year of the fact to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period of the fact to retrieve (default: no filtering). Can select multiple</param>
        /// <param name="fiscalPeriodType">The fiscal period type of the fact to retrieve (default: no filtering). Can select multiple</param>
        /// <param name="report">The name of the report to be used (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="validate">Validate and stamp facts accordingly</param>
        /// <param name="labels">Whether human readable labels should be included for concepts in each fact. (default: false)</param>
        /// <param name="language">A language code</param>
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListFactTableForReportAsync (string token, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string fiscalYear = null, string fiscalPeriod = null, string fiscalPeriodType = null, string report = null, bool? validate = null, bool? labels = null, string language = null, string mostRecentVersionAspect = null, string profileName = null, bool? count = null, int? top = null, bool? skip = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListFactTableForReport");
            
    
            var path = "/api/facttable-for-report";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
                        
            
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (report != null) queryParams.Add("report", ApiClient.ParameterToString(report)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (labels != null) queryParams.Add("labels", ApiClient.ParameterToString(labels)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (mostRecentVersionAspect != null) queryParams.Add("most-recent-version-aspect", ApiClient.ParameterToString(mostRecentVersionAspect)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFactTableForReport: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve metadata about the filings, also called archives. The filings are identified with Archive IDs (AIDs). Facts can be bound with filings with the xbrl28:Archive aspect, whose values are AIDs. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API</param> 
        /// <param name="tag">Filters the results for filings submitted by the entity identified by this tag, with the same semantics as the entities endpoint</param> 
        /// <param name="eid">Filters the results for filings submitted by the entity identified by this EID, with the same semantics as the entities endpoint</param> 
        /// <param name="cik">Filters the results for filings submitted by the entity identified by this CIK, with the same semantics as the entities endpoint</param> 
        /// <param name="edinetcode">Filters the results for filings submitted by the entity identified by this EDINET code, with the same semantics as the entities endpoint</param> 
        /// <param name="ticker">Filters the results for filings submitted by the entity identified by this ticker symbol, with the same semantics as the entities endpoint</param> 
        /// <param name="sic">Filters the results for filings submitted by the entity identified by this industry group, with the same semantics as the entities endpoint</param> 
        /// <param name="aid">Includes in the results the filings with the supplied Archive ID. This parameter is unaffected by the other filters</param> 
        /// <param name="fiscalYear">Filters the results for the filings submitted for the supplied fiscal year focus. (default: no filtering)</param> 
        /// <param name="fiscalPeriod">Filters the results for the filings submitted for the supplied fiscal period focus. (default: no filtering)</param> 
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param> 
        /// <param name="count">If true, only outputs statistics (default is false)</param> 
        /// <param name="top">Output only the first [top] results (default: no limit)</param> 
        /// <param name="skip">Skip the first [skip] results (default: 0)</param> 
        /// <param name="language">A language code</param> 
        /// <returns>Object</returns>            
        public Object ListFilings (string token, string tag = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string sic = null, string aid = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, bool? count = null, int? top = null, bool? skip = null, string language = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListFilings");
            
    
            var path = "/api/filings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
            
            
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFilings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFilings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve metadata about the filings, also called archives. The filings are identified with Archive IDs (AIDs). Facts can be bound with filings with the xbrl28:Archive aspect, whose values are AIDs. 
        /// </summary>
        /// <param name="token">The token that allows you to use this API</param>
        /// <param name="tag">Filters the results for filings submitted by the entity identified by this tag, with the same semantics as the entities endpoint</param>
        /// <param name="eid">Filters the results for filings submitted by the entity identified by this EID, with the same semantics as the entities endpoint</param>
        /// <param name="cik">Filters the results for filings submitted by the entity identified by this CIK, with the same semantics as the entities endpoint</param>
        /// <param name="edinetcode">Filters the results for filings submitted by the entity identified by this EDINET code, with the same semantics as the entities endpoint</param>
        /// <param name="ticker">Filters the results for filings submitted by the entity identified by this ticker symbol, with the same semantics as the entities endpoint</param>
        /// <param name="sic">Filters the results for filings submitted by the entity identified by this industry group, with the same semantics as the entities endpoint</param>
        /// <param name="aid">Includes in the results the filings with the supplied Archive ID. This parameter is unaffected by the other filters</param>
        /// <param name="fiscalYear">Filters the results for the filings submitted for the supplied fiscal year focus. (default: no filtering)</param>
        /// <param name="fiscalPeriod">Filters the results for the filings submitted for the supplied fiscal period focus. (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <param name="language">A language code</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListFilingsAsync (string token, string tag = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string sic = null, string aid = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, bool? count = null, int? top = null, bool? skip = null, string language = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListFilings");
            
    
            var path = "/api/filings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
                        
            
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListFilings: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Add or updata a filing. The filings are identified with Archive IDs (AIDs). 
        /// </summary>
        /// <param name="token">The token that allows you to use this API.</param> 
        /// <param name="format">Returns the results in the supplied format.</param> 
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository.</param> 
        /// <returns>Object</returns>            
        public Object UpsertFilings (string token, string format = null, string profileName = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpsertFilings");
            
    
            var path = "/api/filings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            
            
            if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpsertFilings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpsertFilings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Add or updata a filing. The filings are identified with Archive IDs (AIDs). 
        /// </summary>
        /// <param name="token">The token that allows you to use this API.</param>
        /// <param name="format">Returns the results in the supplied format.</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository.</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> UpsertFilingsAsync (string token, string format = null, string profileName = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling UpsertFilings");
            
    
            var path = "/api/filings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

                        
            
            if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpsertFilings: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve labels for the supplied components and report elements 
        /// </summary>
        /// <param name="token">The token of the current session</param> 
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param> 
        /// <param name="ticker">The ticker of the entity</param> 
        /// <param name="tag">The tag to filter entities</param> 
        /// <param name="sic">The industry group</param> 
        /// <param name="cik">A CIK number</param> 
        /// <param name="edinetcode">An EDINET Code</param> 
        /// <param name="fiscalYear">The fiscal year focus of the components to retrieve (default: no filtering)</param> 
        /// <param name="fiscalPeriod">The fiscal period focus of the components to retrieve (default: no filtering)</param> 
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param> 
        /// <param name="aid">The id of the filings for which to retrieve components</param> 
        /// <param name="section">The URI of a particular section</param> 
        /// <param name="disclosure">The disclosure to search for (e.g. BalanceSheet)</param> 
        /// <param name="reportElement">The name of the report element to search for (e.g. us-gaap:Goodwill)</param> 
        /// <param name="label">A search term to search in the labels of components (e.g. stock). Exact match, except for the SEC profile where it performs full text search in English</param> 
        /// <param name="language">A language code</param> 
        /// <param name="labelRole">A label role</param> 
        /// <param name="kind">Filters by concept kind (default: no filtering)</param> 
        /// <param name="eliminateReportElementDuplicates">Whether to eliminate (concept name, language, label role) duplicates. By default no duplicate elimination</param> 
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param> 
        /// <param name="count">If true, only outputs statistics (default is false)</param> 
        /// <param name="top">Output only the first [top] results (default: no limit)</param> 
        /// <param name="skip">Skip the first [skip] results (default: 0)</param> 
        /// <returns>Object</returns>            
        public Object ListLabels (string token, string eid = null, string ticker = null, string tag = null, string sic = null, string cik = null, string edinetcode = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string aid = null, string section = null, string disclosure = null, string reportElement = null, string label = null, string language = null, string labelRole = null, string kind = null, bool? eliminateReportElementDuplicates = null, string profileName = null, bool? count = null, int? top = null, bool? skip = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListLabels");
            
    
            var path = "/api/labels";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
            
            
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (labelRole != null) queryParams.Add("labelRole", ApiClient.ParameterToString(labelRole)); // query parameter
            if (kind != null) queryParams.Add("kind", ApiClient.ParameterToString(kind)); // query parameter
            if (eliminateReportElementDuplicates != null) queryParams.Add("eliminateReportElementDuplicates", ApiClient.ParameterToString(eliminateReportElementDuplicates)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListLabels: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListLabels: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve labels for the supplied components and report elements 
        /// </summary>
        /// <param name="token">The token of the current session</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="fiscalYear">The fiscal year focus of the components to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period focus of the components to retrieve (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="aid">The id of the filings for which to retrieve components</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="disclosure">The disclosure to search for (e.g. BalanceSheet)</param>
        /// <param name="reportElement">The name of the report element to search for (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock). Exact match, except for the SEC profile where it performs full text search in English</param>
        /// <param name="language">A language code</param>
        /// <param name="labelRole">A label role</param>
        /// <param name="kind">Filters by concept kind (default: no filtering)</param>
        /// <param name="eliminateReportElementDuplicates">Whether to eliminate (concept name, language, label role) duplicates. By default no duplicate elimination</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListLabelsAsync (string token, string eid = null, string ticker = null, string tag = null, string sic = null, string cik = null, string edinetcode = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string aid = null, string section = null, string disclosure = null, string reportElement = null, string label = null, string language = null, string labelRole = null, string kind = null, bool? eliminateReportElementDuplicates = null, string profileName = null, bool? count = null, int? top = null, bool? skip = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListLabels");
            
    
            var path = "/api/labels";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
                        
            
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (labelRole != null) queryParams.Add("labelRole", ApiClient.ParameterToString(labelRole)); // query parameter
            if (kind != null) queryParams.Add("kind", ApiClient.ParameterToString(kind)); // query parameter
            if (eliminateReportElementDuplicates != null) queryParams.Add("eliminateReportElementDuplicates", ApiClient.ParameterToString(eliminateReportElementDuplicates)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListLabels: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve the model structure for a given component. A component can be selected in three ways. (1) by component id (cid), (2) by accession number and disclosure (aid and disclosure), or (3) by CIK, fiscal year, fiscal period, and disclosure (cik, fiscalYear, fiscalPeriod, and disclosure). 
        /// </summary>
        /// <param name="token">The token of the current session</param> 
        /// <param name="aid">The accession number of the filing. This parameter needs to be used together with the disclosure parameter to identify a component</param> 
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param> 
        /// <param name="cik">A CIK number</param> 
        /// <param name="edinetcode">An EDINET Code</param> 
        /// <param name="ticker">The ticker of the entity</param> 
        /// <param name="tag">The tag to filter entities</param> 
        /// <param name="sic">The industry group</param> 
        /// <param name="section">The URI of a particular section</param> 
        /// <param name="hypercube">A hypercube name to further filter components</param> 
        /// <param name="fiscalYear">The fiscal year of the filing (default: no filtering)</param> 
        /// <param name="fiscalPeriod">The fiscal period of the filing (default: no filtering)</param> 
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param> 
        /// <param name="disclosure">The disclosure of the component (e.g. BalanceSheet)</param> 
        /// <param name="reportElement">Filters only those components that contained the supplied report element (e.g. us-gaap:Goodwill)</param> 
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param> 
        /// <param name="count">If true, only outputs statistics (default is false)</param> 
        /// <param name="top">Output only the first [top] results (default: no limit)</param> 
        /// <param name="skip">Skip the first [skip] results (default: 0)</param> 
        /// <param name="language">A language code</param> 
        /// <returns>Object</returns>            
        public Object ListModelStructure (string token, string aid = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string section = null, string hypercube = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string disclosure = null, string reportElement = null, string label = null, bool? count = null, int? top = null, bool? skip = null, string language = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListModelStructure");
            
    
            var path = "/api/modelstructure-for-component";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
            
            
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListModelStructure: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListModelStructure: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve the model structure for a given component. A component can be selected in three ways. (1) by component id (cid), (2) by accession number and disclosure (aid and disclosure), or (3) by CIK, fiscal year, fiscal period, and disclosure (cik, fiscalYear, fiscalPeriod, and disclosure). 
        /// </summary>
        /// <param name="token">The token of the current session</param>
        /// <param name="aid">The accession number of the filing. This parameter needs to be used together with the disclosure parameter to identify a component</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="hypercube">A hypercube name to further filter components</param>
        /// <param name="fiscalYear">The fiscal year of the filing (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period of the filing (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="disclosure">The disclosure of the component (e.g. BalanceSheet)</param>
        /// <param name="reportElement">Filters only those components that contained the supplied report element (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <param name="language">A language code</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListModelStructureAsync (string token, string aid = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string section = null, string hypercube = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string disclosure = null, string reportElement = null, string label = null, bool? count = null, int? top = null, bool? skip = null, string language = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListModelStructure");
            
    
            var path = "/api/modelstructure-for-component";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
                        
            
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListModelStructure: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve a summary for all networks of a given filing 
        /// </summary>
        /// <param name="token">The token of the current session</param> 
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param> 
        /// <param name="ticker">The ticker of the entity</param> 
        /// <param name="tag">The tag to filter entities</param> 
        /// <param name="sic">The industry group</param> 
        /// <param name="cik">A CIK number</param> 
        /// <param name="edinetcode">An EDINET Code</param> 
        /// <param name="fiscalYear">The fiscal year focus of the components to retrieve (default: no filtering)</param> 
        /// <param name="fiscalPeriod">The fiscal period focus of the components to retrieve (default: no filtering)</param> 
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param> 
        /// <param name="aid">The id of the filings for which to retrieve components</param> 
        /// <param name="section">The URI of a particular section</param> 
        /// <param name="hypercube">A hypercube name to further filter networks</param> 
        /// <param name="disclosure">The disclosure to search for (e.g. BalanceSheet)</param> 
        /// <param name="reportElement">The name of the report element to search for (e.g. us-gaap:Goodwill)</param> 
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param> 
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param> 
        /// <param name="count">If true, only outputs statistics (default is false)</param> 
        /// <param name="top">Output only the first [top] results (default: no limit)</param> 
        /// <param name="skip">Skip the first [skip] results (default: 0)</param> 
        /// <returns>Object</returns>            
        public Object ListNetworks (string token, string eid = null, string ticker = null, string tag = null, string sic = null, string cik = null, string edinetcode = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string aid = null, string section = null, string hypercube = null, string disclosure = null, string reportElement = null, string label = null, string profileName = null, bool? count = null, int? top = null, bool? skip = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListNetworks");
            
    
            var path = "/api/networks";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
            
            
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNetworks: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNetworks: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve a summary for all networks of a given filing 
        /// </summary>
        /// <param name="token">The token of the current session</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="fiscalYear">The fiscal year focus of the components to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period focus of the components to retrieve (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="aid">The id of the filings for which to retrieve components</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="hypercube">A hypercube name to further filter networks</param>
        /// <param name="disclosure">The disclosure to search for (e.g. BalanceSheet)</param>
        /// <param name="reportElement">The name of the report element to search for (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListNetworksAsync (string token, string eid = null, string ticker = null, string tag = null, string sic = null, string cik = null, string edinetcode = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string aid = null, string section = null, string hypercube = null, string disclosure = null, string reportElement = null, string label = null, string profileName = null, bool? count = null, int? top = null, bool? skip = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListNetworks");
            
    
            var path = "/api/networks";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
                        
            
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (hypercube != null) queryParams.Add("hypercube", ApiClient.ParameterToString(hypercube)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListNetworks: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve the periods of the filings filed by a particular entity 
        /// </summary>
        /// <param name="token">The token of the current session</param> 
        /// <param name="tag">A tag to filter</param> 
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param> 
        /// <param name="cik">A CIK number</param> 
        /// <param name="edinetcode">An EDINET Code</param> 
        /// <param name="ticker">A ticker symbol</param> 
        /// <param name="sic">The industry group</param> 
        /// <param name="aid">An Archive ID (a value of the xbrl28:Archive aspect)</param> 
        /// <param name="fiscalYear">The fiscal year focus of the filings to retrieve (default: no filtering)</param> 
        /// <param name="fiscalPeriod">The fiscal period focus of the filings to retrieve (default: no filtering)</param> 
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param> 
        /// <param name="count">If true, only outputs statistics (default is false)</param> 
        /// <param name="top">Output only the first [top] results (default: no limit)</param> 
        /// <param name="skip">Skip the first [skip] results (default: 0)</param> 
        /// <returns>Object</returns>            
        public Object ListPeriods (string token, string tag = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string sic = null, string aid = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, bool? count = null, int? top = null, bool? skip = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListPeriods");
            
    
            var path = "/api/periods";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
            
            
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListPeriods: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListPeriods: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve the periods of the filings filed by a particular entity 
        /// </summary>
        /// <param name="token">The token of the current session</param>
        /// <param name="tag">A tag to filter</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">A ticker symbol</param>
        /// <param name="sic">The industry group</param>
        /// <param name="aid">An Archive ID (a value of the xbrl28:Archive aspect)</param>
        /// <param name="fiscalYear">The fiscal year focus of the filings to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period focus of the filings to retrieve (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListPeriodsAsync (string token, string tag = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string sic = null, string aid = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, bool? count = null, int? top = null, bool? skip = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListPeriods");
            
    
            var path = "/api/periods";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
                        
            
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListPeriods: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve the report elements contained in a set of filings. 
        /// </summary>
        /// <param name="token">The token of the current session</param> 
        /// <param name="tag">A tag to filter entities</param> 
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param> 
        /// <param name="cik">A CIK number</param> 
        /// <param name="edinetcode">An EDINET Code</param> 
        /// <param name="ticker">A ticker symbols</param> 
        /// <param name="sic">The industry group</param> 
        /// <param name="fiscalYear">The fiscal year focus of the component to retrieve (default: no filtering)</param> 
        /// <param name="fiscalPeriod">The fiscal period focus of the component to retrieve (default: no filtering)</param> 
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param> 
        /// <param name="aid">The id of the filing</param> 
        /// <param name="section">The URI of a particular section</param> 
        /// <param name="disclosure">The disclosure to search for (e.g. BalanceSheet)</param> 
        /// <param name="onlyNames">Whether only the names of the report elements should be returned. If so, the values don&#39;t contain duplicates. (default: false)</param> 
        /// <param name="name">The name of the report element to return (e.g. us-gaap:Assets)</param> 
        /// <param name="report">The report to use as a context to retrieve the report elements. In particular, concept maps found in this report will be used. (default: none)</param> 
        /// <param name="label">A search term to search in the labels of report elements (e.g. stock)</param> 
        /// <param name="onlyTextBlocks">Filters by text block/not text block (default: no filtering)</param> 
        /// <param name="kind">Filters by concept kind (default: no filtering)</param> 
        /// <param name="count">If true, only outputs statistics (default is false)</param> 
        /// <param name="top">Output only the first [top] results (default: no limit)</param> 
        /// <param name="skip">Skip the first [skip] results (default: 0)</param> 
        /// <param name="language">A language code</param> 
        /// <param name="contentType">Content-Type of the request</param> 
        /// <returns>Object</returns>            
        public Object ListReportElements (string token, string tag = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string sic = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string aid = null, string section = null, string disclosure = null, bool? onlyNames = null, string name = null, string report = null, string label = null, bool? onlyTextBlocks = null, string kind = null, bool? count = null, int? top = null, bool? skip = null, string language = null, string contentType = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListReportElements");
            
    
            var path = "/api/report-elements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
            
            
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (onlyNames != null) queryParams.Add("onlyNames", ApiClient.ParameterToString(onlyNames)); // query parameter
            if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
            if (report != null) queryParams.Add("report", ApiClient.ParameterToString(report)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (onlyTextBlocks != null) queryParams.Add("onlyTextBlocks", ApiClient.ParameterToString(onlyTextBlocks)); // query parameter
            if (kind != null) queryParams.Add("kind", ApiClient.ParameterToString(kind)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListReportElements: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListReportElements: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve the report elements contained in a set of filings. 
        /// </summary>
        /// <param name="token">The token of the current session</param>
        /// <param name="tag">A tag to filter entities</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">A ticker symbols</param>
        /// <param name="sic">The industry group</param>
        /// <param name="fiscalYear">The fiscal year focus of the component to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period focus of the component to retrieve (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="aid">The id of the filing</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="disclosure">The disclosure to search for (e.g. BalanceSheet)</param>
        /// <param name="onlyNames">Whether only the names of the report elements should be returned. If so, the values don&#39;t contain duplicates. (default: false)</param>
        /// <param name="name">The name of the report element to return (e.g. us-gaap:Assets)</param>
        /// <param name="report">The report to use as a context to retrieve the report elements. In particular, concept maps found in this report will be used. (default: none)</param>
        /// <param name="label">A search term to search in the labels of report elements (e.g. stock)</param>
        /// <param name="onlyTextBlocks">Filters by text block/not text block (default: no filtering)</param>
        /// <param name="kind">Filters by concept kind (default: no filtering)</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <param name="language">A language code</param>
        /// <param name="contentType">Content-Type of the request</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListReportElementsAsync (string token, string tag = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string sic = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string aid = null, string section = null, string disclosure = null, bool? onlyNames = null, string name = null, string report = null, string label = null, bool? onlyTextBlocks = null, string kind = null, bool? count = null, int? top = null, bool? skip = null, string language = null, string contentType = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListReportElements");
            
    
            var path = "/api/report-elements";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
                        
            
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (onlyNames != null) queryParams.Add("onlyNames", ApiClient.ParameterToString(onlyNames)); // query parameter
            if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
            if (report != null) queryParams.Add("report", ApiClient.ParameterToString(report)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (onlyTextBlocks != null) queryParams.Add("onlyTextBlocks", ApiClient.ParameterToString(onlyTextBlocks)); // query parameter
            if (kind != null) queryParams.Add("kind", ApiClient.ParameterToString(kind)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            if (contentType != null) headerParams.Add("Content-Type", ApiClient.ParameterToString(contentType)); // header parameter
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListReportElements: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve a summary for all sections of a given filing 
        /// </summary>
        /// <param name="token">The token of the current session</param> 
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param> 
        /// <param name="ticker">The ticker of the entity</param> 
        /// <param name="tag">The tag to filter entities</param> 
        /// <param name="sic">The industry group</param> 
        /// <param name="cik">A CIK number</param> 
        /// <param name="edinetcode">An EDINET Code</param> 
        /// <param name="fiscalYear">The fiscal year focus of the components to retrieve (default: no filtering)</param> 
        /// <param name="fiscalPeriod">The fiscal period focus of the components to retrieve (default: no filtering)</param> 
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param> 
        /// <param name="aid">The id of the filings for which to retrieve components</param> 
        /// <param name="section">The URI of a particular section</param> 
        /// <param name="disclosure">The disclosure to search for (e.g. BalanceSheet)</param> 
        /// <param name="reportElement">The name of the report element to search for (e.g. us-gaap:Goodwill)</param> 
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param> 
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param> 
        /// <param name="count">If true, only outputs statistics (default is false)</param> 
        /// <param name="top">Output only the first [top] results (default: no limit)</param> 
        /// <param name="skip">Skip the first [skip] results (default: 0)</param> 
        /// <param name="validate">Whether to run validation on the output components (default: false). Adds a column ValidationErrors</param> 
        /// <param name="language">A language code</param> 
        /// <returns>Object</returns>            
        public Object ListSections (string token, string eid = null, string ticker = null, string tag = null, string sic = null, string cik = null, string edinetcode = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string aid = null, string section = null, string disclosure = null, string reportElement = null, string label = null, string profileName = null, bool? count = null, int? top = null, bool? skip = null, bool? validate = null, string language = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListSections");
            
    
            var path = "/api/sections";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
            
            
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListSections: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListSections: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve a summary for all sections of a given filing 
        /// </summary>
        /// <param name="token">The token of the current session</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="fiscalYear">The fiscal year focus of the components to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period focus of the components to retrieve (default: no filtering)</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="aid">The id of the filings for which to retrieve components</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="disclosure">The disclosure to search for (e.g. BalanceSheet)</param>
        /// <param name="reportElement">The name of the report element to search for (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <param name="count">If true, only outputs statistics (default is false)</param>
        /// <param name="top">Output only the first [top] results (default: no limit)</param>
        /// <param name="skip">Skip the first [skip] results (default: 0)</param>
        /// <param name="validate">Whether to run validation on the output components (default: false). Adds a column ValidationErrors</param>
        /// <param name="language">A language code</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListSectionsAsync (string token, string eid = null, string ticker = null, string tag = null, string sic = null, string cik = null, string edinetcode = null, string fiscalYear = null, string fiscalPeriod = null, string filingKind = null, string aid = null, string section = null, string disclosure = null, string reportElement = null, string label = null, string profileName = null, bool? count = null, int? top = null, bool? skip = null, bool? validate = null, string language = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListSections");
            
    
            var path = "/api/sections";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
                        
            
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
            if (top != null) queryParams.Add("top", ApiClient.ParameterToString(top)); // query parameter
            if (skip != null) queryParams.Add("skip", ApiClient.ParameterToString(skip)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (language != null) queryParams.Add("language", ApiClient.ParameterToString(language)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListSections: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve the business friendly Spreadsheet for a given component. A component can be selected in three ways. (1) by component id (cid), (2) by accession number and disclosure (aid and disclosure), or (3) by CIK, fiscal year, fiscal period, and disclosure (cik, fiscalYear, fiscalPeriod, and disclosure). 
        /// </summary>
        /// <param name="token">The token of the current session</param> 
        /// <param name="aid">The accession number of the filing. This parameter needs to be used together with the disclosure parameter to identify a component</param> 
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param> 
        /// <param name="cik">A CIK number</param> 
        /// <param name="edinetcode">An EDINET Code</param> 
        /// <param name="ticker">The ticker of the entity</param> 
        /// <param name="tag">A tag to filter</param> 
        /// <param name="sic">The industry group</param> 
        /// <param name="section">The URI of a particular section</param> 
        /// <param name="fiscalYear">The fiscal year of the filing (default: no filtering). In override mode, also filters facts</param> 
        /// <param name="fiscalPeriod">The fiscal period of the filing (default: no filtering). In override mode, also filters facts</param> 
        /// <param name="fiscalPeriodType">In override mode, the fiscal period type of the facts to filter (default: no filtering). Can select multiple</param> 
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param> 
        /// <param name="disclosure">The disclosure of the component (e.g. BalanceSheet)</param> 
        /// <param name="reportElement">Filters only those components that contained the supplied report element (e.g. us-gaap:Goodwill)</param> 
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param> 
        /// <param name="validate">Whether or not to stamp facts for validity (default is false)</param> 
        /// <param name="eliminate">Whether  to eliminate empty rows/columns</param> 
        /// <param name="merge">Whether to merge components if multiple are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved</param> 
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param> 
        /// <param name="additionalRules">The name of a report from which to use rules in addition to the component&#39;s rules (e.g. FundamentalAccountingConcepts)</param> 
        /// <param name="_override">Whether the fiscalYear/fiscalPeriod/fiscalPeriodType parameters should also be used to filter facts (default: false)</param> 
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param> 
        /// <returns>Object</returns>            
        public Object SpreadsheetForComponent (string token, string aid = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string section = null, string fiscalYear = null, string fiscalPeriod = null, string fiscalPeriodType = null, string filingKind = null, string disclosure = null, string reportElement = null, string label = null, bool? validate = null, bool? eliminate = null, bool? merge = null, string mostRecentVersionAspect = null, string additionalRules = null, bool? _override = null, string profileName = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling SpreadsheetForComponent");
            
    
            var path = "/api/spreadsheet-for-component";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
            
            
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (eliminate != null) queryParams.Add("eliminate", ApiClient.ParameterToString(eliminate)); // query parameter
            if (merge != null) queryParams.Add("merge", ApiClient.ParameterToString(merge)); // query parameter
            if (mostRecentVersionAspect != null) queryParams.Add("most-recent-version-aspect", ApiClient.ParameterToString(mostRecentVersionAspect)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (additionalRules != null) queryParams.Add("additional-rules", ApiClient.ParameterToString(additionalRules)); // query parameter
            if (_override != null) queryParams.Add("override", ApiClient.ParameterToString(_override)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SpreadsheetForComponent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SpreadsheetForComponent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve the business friendly Spreadsheet for a given component. A component can be selected in three ways. (1) by component id (cid), (2) by accession number and disclosure (aid and disclosure), or (3) by CIK, fiscal year, fiscal period, and disclosure (cik, fiscalYear, fiscalPeriod, and disclosure). 
        /// </summary>
        /// <param name="token">The token of the current session</param>
        /// <param name="aid">The accession number of the filing. This parameter needs to be used together with the disclosure parameter to identify a component</param>
        /// <param name="eid">An Entity ID (a value of the xbrl:Entity aspect)</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">A tag to filter</param>
        /// <param name="sic">The industry group</param>
        /// <param name="section">The URI of a particular section</param>
        /// <param name="fiscalYear">The fiscal year of the filing (default: no filtering). In override mode, also filters facts</param>
        /// <param name="fiscalPeriod">The fiscal period of the filing (default: no filtering). In override mode, also filters facts</param>
        /// <param name="fiscalPeriodType">In override mode, the fiscal period type of the facts to filter (default: no filtering). Can select multiple</param>
        /// <param name="filingKind">Filters the results for the filings submitted for kind of filing. (default: no filtering)</param>
        /// <param name="disclosure">The disclosure of the component (e.g. BalanceSheet)</param>
        /// <param name="reportElement">Filters only those components that contained the supplied report element (e.g. us-gaap:Goodwill)</param>
        /// <param name="label">A search term to search in the labels of components (e.g. stock)</param>
        /// <param name="validate">Whether or not to stamp facts for validity (default is false)</param>
        /// <param name="eliminate">Whether  to eliminate empty rows/columns</param>
        /// <param name="merge">Whether to merge components if multiple are retrieved. By default, it is true. If false, a random component is selected if multiple are retrieved</param>
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param>
        /// <param name="additionalRules">The name of a report from which to use rules in addition to the component&#39;s rules (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="_override">Whether the fiscalYear/fiscalPeriod/fiscalPeriodType parameters should also be used to filter facts (default: false)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> SpreadsheetForComponentAsync (string token, string aid = null, string eid = null, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string section = null, string fiscalYear = null, string fiscalPeriod = null, string fiscalPeriodType = null, string filingKind = null, string disclosure = null, string reportElement = null, string label = null, bool? validate = null, bool? eliminate = null, bool? merge = null, string mostRecentVersionAspect = null, string additionalRules = null, bool? _override = null, string profileName = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling SpreadsheetForComponent");
            
    
            var path = "/api/spreadsheet-for-component";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
                        
            
            if (aid != null) queryParams.Add("aid", ApiClient.ParameterToString(aid)); // query parameter
            if (eid != null) queryParams.Add("eid", ApiClient.ParameterToString(eid)); // query parameter
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (section != null) queryParams.Add("section", ApiClient.ParameterToString(section)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (filingKind != null) queryParams.Add("filingKind", ApiClient.ParameterToString(filingKind)); // query parameter
            if (disclosure != null) queryParams.Add("disclosure", ApiClient.ParameterToString(disclosure)); // query parameter
            if (reportElement != null) queryParams.Add("reportElement", ApiClient.ParameterToString(reportElement)); // query parameter
            if (label != null) queryParams.Add("label", ApiClient.ParameterToString(label)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (eliminate != null) queryParams.Add("eliminate", ApiClient.ParameterToString(eliminate)); // query parameter
            if (merge != null) queryParams.Add("merge", ApiClient.ParameterToString(merge)); // query parameter
            if (mostRecentVersionAspect != null) queryParams.Add("most-recent-version-aspect", ApiClient.ParameterToString(mostRecentVersionAspect)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            if (additionalRules != null) queryParams.Add("additional-rules", ApiClient.ParameterToString(additionalRules)); // query parameter
            if (_override != null) queryParams.Add("override", ApiClient.ParameterToString(_override)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SpreadsheetForComponent: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        /// Retrieve the business-friendly spreadsheet for a report. Filters can be overriden. Filters MUST be overriden if the report is not already filtering. 
        /// </summary>
        /// <param name="token">The token of the current session</param> 
        /// <param name="cik">A CIK number</param> 
        /// <param name="edinetcode">An EDINET Code</param> 
        /// <param name="ticker">The ticker of the entity</param> 
        /// <param name="tag">The tag to filter entities</param> 
        /// <param name="sic">The industry group</param> 
        /// <param name="fiscalYear">The fiscal year of the fact to retrieve (default: no filtering)</param> 
        /// <param name="fiscalPeriod">The fiscal period of the fact to retrieve (default: no filtering)</param> 
        /// <param name="fiscalPeriodType">The fiscal period type of the fact to retrieve (default: no filtering). Can select multiple, but preferably not both YTD and QTD</param> 
        /// <param name="report">The name of the report to be used (e.g. FundamentalAccountingConcepts)</param> 
        /// <param name="eliminate">Wwether to eliminate empty rows/colummns</param> 
        /// <param name="validate">Validate and stamp facts accordingly</param> 
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param> 
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param> 
        /// <returns>Object</returns>            
        public Object ListSpreadsheetForReport (string token, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string fiscalYear = null, string fiscalPeriod = null, string fiscalPeriodType = null, string report = null, bool? eliminate = null, bool? validate = null, string mostRecentVersionAspect = null, string profileName = null)
        {
            
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListSpreadsheetForReport");
            
    
            var path = "/api/spreadsheet-for-report";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
            
            
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (report != null) queryParams.Add("report", ApiClient.ParameterToString(report)); // query parameter
            if (eliminate != null) queryParams.Add("eliminate", ApiClient.ParameterToString(eliminate)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (mostRecentVersionAspect != null) queryParams.Add("most-recent-version-aspect", ApiClient.ParameterToString(mostRecentVersionAspect)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListSpreadsheetForReport: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ListSpreadsheetForReport: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        /// Retrieve the business-friendly spreadsheet for a report. Filters can be overriden. Filters MUST be overriden if the report is not already filtering. 
        /// </summary>
        /// <param name="token">The token of the current session</param>
        /// <param name="cik">A CIK number</param>
        /// <param name="edinetcode">An EDINET Code</param>
        /// <param name="ticker">The ticker of the entity</param>
        /// <param name="tag">The tag to filter entities</param>
        /// <param name="sic">The industry group</param>
        /// <param name="fiscalYear">The fiscal year of the fact to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriod">The fiscal period of the fact to retrieve (default: no filtering)</param>
        /// <param name="fiscalPeriodType">The fiscal period type of the fact to retrieve (default: no filtering). Can select multiple, but preferably not both YTD and QTD</param>
        /// <param name="report">The name of the report to be used (e.g. FundamentalAccountingConcepts)</param>
        /// <param name="eliminate">Wwether to eliminate empty rows/colummns</param>
        /// <param name="validate">Validate and stamp facts accordingly</param>
        /// <param name="mostRecentVersionAspect">A transaction-time aspect of which only the latest value per cell is retained (default: sec:Accepted for SEC, fsa:Submitted for japan)</param>
        /// <param name="profileName">Specifies which profile to use. The default depends on the underlying repository</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> ListSpreadsheetForReportAsync (string token, string cik = null, string edinetcode = null, string ticker = null, string tag = null, string sic = null, string fiscalYear = null, string fiscalPeriod = null, string fiscalPeriodType = null, string report = null, bool? eliminate = null, bool? validate = null, string mostRecentVersionAspect = null, string profileName = null)
        {
            // verify the required parameter 'token' is set
            if (token == null) throw new ApiException(400, "Missing required parameter 'token' when calling ListSpreadsheetForReport");
            
    
            var path = "/api/spreadsheet-for-report";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            queryParams.Add("format", ApiClient.ParameterToString("json")); // hardcoded query parameter
                        
            
            if (cik != null) queryParams.Add("cik", ApiClient.ParameterToString(cik)); // query parameter
            if (edinetcode != null) queryParams.Add("edinetcode", ApiClient.ParameterToString(edinetcode)); // query parameter
            if (ticker != null) queryParams.Add("ticker", ApiClient.ParameterToString(ticker)); // query parameter
            if (tag != null) queryParams.Add("tag", ApiClient.ParameterToString(tag)); // query parameter
            if (sic != null) queryParams.Add("sic", ApiClient.ParameterToString(sic)); // query parameter
            if (fiscalYear != null) queryParams.Add("fiscalYear", ApiClient.ParameterToString(fiscalYear)); // query parameter
            if (fiscalPeriod != null) queryParams.Add("fiscalPeriod", ApiClient.ParameterToString(fiscalPeriod)); // query parameter
            if (fiscalPeriodType != null) queryParams.Add("fiscalPeriodType", ApiClient.ParameterToString(fiscalPeriodType)); // query parameter
            if (report != null) queryParams.Add("report", ApiClient.ParameterToString(report)); // query parameter
            if (eliminate != null) queryParams.Add("eliminate", ApiClient.ParameterToString(eliminate)); // query parameter
            if (validate != null) queryParams.Add("validate", ApiClient.ParameterToString(validate)); // query parameter
            if (mostRecentVersionAspect != null) queryParams.Add("most-recent-version-aspect", ApiClient.ParameterToString(mostRecentVersionAspect)); // query parameter
            if (profileName != null) queryParams.Add("profile-name", ApiClient.ParameterToString(profileName)); // query parameter
            if (token != null) queryParams.Add("token", ApiClient.ParameterToString(token)); // query parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ListSpreadsheetForReport: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
    }
    
}
