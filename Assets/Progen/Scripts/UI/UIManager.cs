using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private ProGen proGen;

    [SerializeField]
    private Slider rowsSlider;

    [SerializeField]
    private Slider columnsSlider;
    
    [SerializeField]
    private Slider cellUnitSlider;

    [SerializeField]
    private Slider floorsSlider;

    [SerializeField]
    private Toggle includeRoofToggle;

    [SerializeField]
    private Toggle cornersToggle;

    [SerializeField]
    private Toggle randomRowsToggle;

    [SerializeField]
    private Toggle randomColsToggle;


    void Awake() 
    {
        rowsSlider.value = proGen.Theme.rows;
        columnsSlider.value = proGen.Theme.columns;
        cellUnitSlider.value = proGen.Theme.cellUnitSize;
        floorsSlider.value = proGen.Theme.numberOfFloors;

        includeRoofToggle.isOn = proGen.Theme.includeRoof;
        cornersToggle.isOn = proGen.Theme.allowCornerWalls;
        randomRowsToggle.isOn = proGen.Theme.randomizeRows;
        randomColsToggle.isOn = proGen.Theme.randomizeColumns;

    }   

    void Start()
    {
        rowsSlider.onValueChanged.AddListener((v) => 
        {
            proGen.Theme.rows = (int)v;
            proGen.Generate();
        });

        columnsSlider.onValueChanged.AddListener((v) => 
        {
            proGen.Theme.columns = (int)v;
            proGen.Generate();
        });

        cellUnitSlider.onValueChanged.AddListener((v) => 
        {
            proGen.Theme.cellUnitSize = (int)v;
            proGen.Generate();
        });

        floorsSlider.onValueChanged.AddListener((v) => 
        {
            proGen.Theme.numberOfFloors = (int)v;
            proGen.Generate();
        });

        cornersToggle.onValueChanged.AddListener((v) => 
        {
            proGen.Theme.allowCornerWalls = v;
            proGen.Generate();
        });

        randomRowsToggle.onValueChanged.AddListener((v) => 
        {
            proGen.Theme.randomizeRows = v;
            proGen.Generate();
        });

        randomColsToggle.onValueChanged.AddListener((v) => 
        {
            proGen.Theme.randomizeColumns = v;
            proGen.Generate();
        });

        includeRoofToggle.onValueChanged.AddListener((v) => 
        {
            proGen.Theme.includeRoof = v;
            proGen.Generate();
        });
    }
}