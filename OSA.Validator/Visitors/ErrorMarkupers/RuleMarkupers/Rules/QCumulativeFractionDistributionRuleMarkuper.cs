using OSA.Validator.Rules;
using OSA.Validator.Rules.QCumulativeRules;

namespace OSA.Validator.Visitors.ErrorMarkupers.RuleMarkupers.Rules
{
    public class QCumulativeFractionDistributionRuleMarkuper : MarkAllDependantRuleMarkuper
    {
        public override bool CanMarkupRuleNodeOfType(RuleNode ruleNode)
        {
            return ruleNode is QCumulativeFractionDistributionRule;
        }
    }
}