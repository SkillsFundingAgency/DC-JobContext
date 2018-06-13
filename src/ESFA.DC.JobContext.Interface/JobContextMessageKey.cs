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
        /// The List of String of exception names that occurred during the message processing. Will be inspected if a callback fails to execute n times and the message is dead lettered. (List of String)
        /// </summary>
        CallbackExceptions,

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
        FundingAlbOutput = 200
    }
}
