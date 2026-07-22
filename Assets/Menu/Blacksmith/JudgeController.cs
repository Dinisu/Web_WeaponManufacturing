using UnityEngine;

public class JudgeController : MonoBehaviour
{
    [SerializeField] private GaugeController gaugeController;
    [SerializeField] private SuccessAreaController successAreaController;

    public JudgeResult Judge()
    {
        float pointer = gaugeController.GetPointerPosition();

        // ‘å¬Œ÷
        if (pointer >= successAreaController.GreatLeft &&
            pointer <= successAreaController.GreatRight)
        {
            return JudgeResult.Great;
        }

        // ¬Œ÷
        if (pointer >= successAreaController.SuccessLeft &&
            pointer <= successAreaController.SuccessRight)
        {
            return JudgeResult.Success;
        }

        // Ž¸”s
        return JudgeResult.Miss;
    }
}
