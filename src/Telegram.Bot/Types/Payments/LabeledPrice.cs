namespace Telegram.Bot.Types.Payments;

/// <summary>
/// This object represents a portion of the price for goods or services.
/// </summary>
/// <a href="https://core.telegram.org/bots/api#labeledprice"/>
/// <param name="label">Portion label</param>
/// <param name="amount">Price of the product</param>
[method: JsonConstructor]
public class LabeledPrice(string label, int amount)
{
    /// <summary>
    /// Portion label
    /// </summary>
    public string Label { get; set; } = label;

    /// <summary>
    /// Price of the product in the <i>smallest units</i> of the
    /// <a href="https://core.telegram.org/bots/payments#supported-currencies">currency</a>
    /// (integer, <b>not</b> float/double).
    /// <para>
    /// For example, for a price of <c>US$ 1.45</c> pass <c>amount = 145</c>. See the <i>exp</i> parameter in
    /// <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number
    /// of digits past the decimal point for each currency (2 for the majority of currencies).
    /// </para>
    /// </summary>
    public int Amount { get; set; } = amount;
}
