namespace ESFA.DC.JobContext.Interface
{
    public enum JobContextMessageKey
    {
        /// <summary>
        /// The UkPrn number. (int)
        /// </summary>
        UkPrn,

        /// <summary>
        /// The name of the container containing the file to process. (string)
        /// </summary>
        Container,

        /// <summary>
        /// The name of the file to process. (string)
        /// </summary>
        Filename,

        /// <summary>
        /// The size of the file in bytes. (long)
        /// </summary>
        FileSizeInBytes,

        /// <summary>
        /// The username who started the operation. (string)
        /// </summary>
        Username,

        /// <summary>
        /// The *Key* of the serialised and persisted valid learn ref numbers in storage. (string)
        /// </summary>
        ValidLearnRefNumbers = 100,

        /// <summary>
        /// The number of valid learners. (long)
        /// </summary>
        ValidLearnRefNumbersCount,

        /// <summary>
        /// The *Key* of the serialised invalid learn ref numbers in storage. (string)
        /// </summary>
        InvalidLearnRefNumbers,

        /// <summary>
        /// The number of invalid learners. (long)
        /// </summary>
        InvalidLearnRefNumbersCount,

        /// <summary>
        /// The total number of validation errors (int)
        /// </summary>
        ValidationTotalErrorCount,

        /// <summary>
        /// The total number of validation warnings (int)
        /// </summary>
        ValidationTotalWarningCount,

        /// <summary>
        /// The *Key* of the serialised and persisted validation errors. (string)
        /// </summary>
        ValidationErrors,

        /// <summary>
        /// The *Key* of the serialised and persisted validation error lookups. (string)
        /// </summary>
        ValidationErrorLookups,

        /// <summary>
        /// The *Key* of the serialised and persisted funding ALB output. (string)
        /// </summary>
        FundingAlbOutput = 200,

        /// <summary>
        /// The *Key* of the serialised and persisted funding FM35 output. (string)
        /// </summary>
        FundingFm35Output = 201,

        /// <summary>
        /// The *Key* of the serialised and persisted funding FM25 output. (string)
        /// </summary>
        FundingFm25Output = 202,

        /// <summary>
        /// Key to determine if the job will be finished (marked as completed) or go to Awaitng Action status
        /// </summary>
        PauseWhenFinished = 300
    }
}
