﻿using UnityEngine;
using System.Collections;

public class WordLIstManagerController : MonoBehaviour {
	
	public void gotoCreatEditList()
	{
		Application.LoadLevel ("WordList");
	}

	public void gotoShareList()
	{
		Application.LoadLevel ("ListServer");
	}

	public void gotoGetList()
	{
		Application.LoadLevel ("ListClient");
	}

}
