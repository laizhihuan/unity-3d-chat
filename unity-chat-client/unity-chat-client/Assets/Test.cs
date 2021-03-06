using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Test : MonoBehaviour {
	
	
	public UIGrid grid;
	int count = 0;
	void Start()
	{
		//得到grid对象
		grid = GameObject.Find("Panel").GetComponent<UIGrid>();
	}
	
	void OnClick ()
    {
		
	    //克隆预设	
		GameObject o  =(GameObject) Instantiate(Resources.Load("item"));
		//为每个预设设置一个独一无二的名称
		o.name = "item" + count;
		//将新预设放在Panel对象下面
		o.transform.parent = GameObject.Find("Panel").transform;
		
		////下面这段代码是因为创建预设时 会自动修改旋转缩放的系数，
		//我不知道为什么会自动修改，所以MOMO重新为它赋值
		//有知道的朋友麻烦告诉我一下 谢谢！！！
	
		GameObject item = GameObject.Find(o.name);
		item.transform.localPosition = new Vector3(0,0,0);
		item.transform.localScale= new Vector3(1,1,1);
		
		count ++;
		
		//列表添加后用于刷新listView 
		grid.repositionNow = true;
    }

}
