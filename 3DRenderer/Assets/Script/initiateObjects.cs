using UnityEngine;
using System.Collections;
using System.IO;

public class initiateObjects : MonoBehaviour {

    public GameObject WeddingHall_1;
    public GameObject WeddingHall_2;

    public GameObject chair1;
    public GameObject chair2;
    public GameObject chair3;
    public GameObject chair4;
    public GameObject chair5;
    public GameObject chair6;

    public GameObject ChairTable1;
    public GameObject ChairTable2;
    public GameObject ChairTable3;
    public GameObject ChairTable4;
    public GameObject ChairTable5;

    public GameObject Hall1;
    public GameObject Hall2;

    public GameObject Sofa1;
    public GameObject Sofa2;
    public GameObject Sofa3;
    public GameObject Sofa4;

    public GameObject Table1;
    public GameObject Table2;
    public GameObject Table3;
    public GameObject Table4;
    public GameObject Table5;

    public GameObject Person1;
    public GameObject Person2;
    public GameObject Person3;
    public GameObject Person4;

    public GameObject Decoration1;
    public GameObject Decoration2;
    public GameObject Decoration3;
    public GameObject Decoration4;

    public GameObject Carpet1;
    public GameObject Carpet2;

    public GameObject stage1;


    // Update is called once per frame
    public void initiate_Objects (string word) {

        if (word.Equals("WeddingHall_1"))
        {
            Vector3 pos = new Vector3(1102.0f, 201.0f, 154.0f);
            GameObject obj = (GameObject)Instantiate(WeddingHall_1, pos, transform.rotation);
            obj.name = "WeddingHall_1";
            obj.transform.Rotate(0.0f, 0.0f, 270.0f);
            Application.ExternalCall("UpdateTreeNode", "WeddingHall_1", obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals("WeddingHall_2"))
        {
            Vector3 pos = new Vector3(1736.815f, 388.0f, -375.0f);
            GameObject obj = (GameObject)Instantiate(WeddingHall_2, pos, transform.rotation);
            obj.name = "WeddingHall_2";
            obj.transform.Rotate(0.0f, 0.0f, -90.0f);
            Application.ExternalCall("UpdateTreeNode", "WeddingHall_2", obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(chair1.name))
        {
            int objNo = 1;
            string nameObj = chair1.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = chair1.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(chair1, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(chair2.name))
        {
            int objNo = 1;
            string nameObj = chair2.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = chair2.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(chair2, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(chair3.name))
        {
            int objNo = 1;
            string nameObj = chair3.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = chair3.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(chair3, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(chair4.name))
        {
            int objNo = 1;
            string nameObj = chair4.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = chair4.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(chair4, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(chair5.name))
        {
            int objNo = 1;
            string nameObj = chair5.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = chair5.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(chair5, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(chair6.name))
        {
            int objNo = 1;
            string nameObj = chair6.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = chair6.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(chair6, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(ChairTable1.name))
        {
            int objNo = 1;
            string nameObj = ChairTable1.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = ChairTable1.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(ChairTable1, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(ChairTable2.name))
        {
            int objNo = 1;
            string nameObj = ChairTable2.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = ChairTable2.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(ChairTable2, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(ChairTable3.name))
        {
            int objNo = 1;
            string nameObj = ChairTable3.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = ChairTable3.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(ChairTable3, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(ChairTable4.name))
        {
            int objNo = 1;
            string nameObj = ChairTable4.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = ChairTable4.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(ChairTable4, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(ChairTable5.name))
        {
            int objNo = 1;
            string nameObj = ChairTable5.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = ChairTable5.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(ChairTable5, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }

        if (word.Equals(Hall1.name))
        {
            int objNo = 1;
            string nameObj = Hall1.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Hall1.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Hall1, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(Hall2.name))
        {
            int objNo = 1;
            string nameObj = Hall2.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Hall2.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Hall2, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(Sofa1.name))
        {
            int objNo = 1;
            string nameObj = Sofa1.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Sofa1.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Sofa1, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(Sofa2.name))
        {
            int objNo = 1;
            string nameObj = Sofa2.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Sofa2.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Sofa2, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(Sofa3.name))
        {
            int objNo = 1;
            string nameObj = Sofa3.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Sofa3.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Sofa3, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(Sofa4.name))
        {
            int objNo = 1;
            string nameObj = Sofa4.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Sofa4.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Sofa4, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(Table1.name))
        {
            int objNo = 1;
            string nameObj = Table1.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Table1.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Table1, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(Table2.name))
        {
            int objNo = 1;
            string nameObj = Table2.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Table2.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Table2, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(Table3.name))
        {
            int objNo = 1;
            string nameObj = Table3.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Table3.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Table3, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(Table4.name))
        {
            int objNo = 1;
            string nameObj = Table4.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Table4.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Table4, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(Table5.name))
        {
            int objNo = 1;
            string nameObj = Table5.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Table5.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Table5, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(Person1.name))
        {
            int objNo = 1;
            string nameObj = Person1.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Person1.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Person1, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(Person2.name))
        {
            int objNo = 1;
            string nameObj = Person2.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Person2.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Person2, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(Person3.name))
        {
            int objNo = 1;
            string nameObj = Person3.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Person3.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Person3, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(Person4.name))
        {
            int objNo = 1;
            string nameObj = Person4.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Person4.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Person4, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(Decoration1.name))
        {
            int objNo = 1;
            string nameObj = Decoration1.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Decoration1.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Decoration1, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(Decoration2.name))
        {
            int objNo = 1;
            string nameObj = Decoration2.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Decoration2.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Decoration2, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(Decoration3.name))
        {
            int objNo = 1;
            string nameObj = Decoration3.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Decoration3.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Decoration3, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(Decoration4.name))
        {
            int objNo = 1;
            string nameObj = Decoration4.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Decoration4.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Decoration4, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(Hall1.name))
        {
            int objNo = 1;
            string nameObj = Hall1.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Hall1.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Hall1, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(Hall2.name))
        {
            int objNo = 1;
            string nameObj = Hall2.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Hall2.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Hall2, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (word.Equals(stage1.name))
        {
            int objNo = 1;
            string nameObj = stage1.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = stage1.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(stage1, transform.position, transform.rotation);
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
    }

    public void initiateWithParameters(string objAttributes)
    {

        string objID;
        string objName;
        float posX;
        float posY;
        float posZ;
        float rotX;
        float rotY;
        float rotZ;
        float scaleX;
        float scaleY;
        float scaleZ;

        string[] attributes = objAttributes.Split('#');

        objName = attributes[0];
        posX = float.Parse(attributes[1]);
        posY = float.Parse(attributes[2]);
        posZ = float.Parse(attributes[3]);
        rotX = float.Parse(attributes[4]);
        rotY = float.Parse(attributes[5]);
        rotZ = float.Parse(attributes[6]);
        scaleX = float.Parse(attributes[7]);
        scaleY = float.Parse(attributes[8]);
        scaleZ = float.Parse(attributes[9]);

        Vector3 pos = new Vector3(posX, posY, posZ);
        Vector3 rot = new Vector3(rotX, rotY, rotZ);
        Vector3 scale = new Vector3(scaleX, scaleY, scaleZ);
        
        if (objName.Equals(chair1.name))
        {
            int objNo = 1;
            string nameObj = chair1.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = chair1.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(chair1, pos, transform.rotation);
            obj.transform.Rotate(rot);
            if(scaleX==0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            {}
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(chair2.name))
        {
            int objNo = 1;
            string nameObj = chair2.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = chair2.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(chair2, pos, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(chair3.name))
        {
            int objNo = 1;
            string nameObj = chair3.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = chair3.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(chair3, pos, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(chair4.name))
        {
            int objNo = 1;
            string nameObj = chair4.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = chair4.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(chair4, pos, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(chair5.name))
        {
            int objNo = 1;
            string nameObj = chair5.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = chair5.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(chair5, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(chair6.name))
        {
            int objNo = 1;
            string nameObj = chair6.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = chair6.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(chair6, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(ChairTable1.name))
        {
            int objNo = 1;
            string nameObj = ChairTable1.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = ChairTable1.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(ChairTable1, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(ChairTable2.name))
        {
            int objNo = 1;
            string nameObj = ChairTable2.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = ChairTable2.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(ChairTable2, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(ChairTable3.name))
        {
            int objNo = 1;
            string nameObj = ChairTable3.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = ChairTable3.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(ChairTable3, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(ChairTable4.name))
        {
            int objNo = 1;
            string nameObj = ChairTable4.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = ChairTable4.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(ChairTable4, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(ChairTable5.name))
        {
            int objNo = 1;
            string nameObj = ChairTable5.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = ChairTable5.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(ChairTable5, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }

        if (objName.Equals(Hall1.name))
        {
            int objNo = 1;
            string nameObj = Hall1.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Hall1.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Hall1, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(Hall2.name))
        {
            int objNo = 1;
            string nameObj = Hall2.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Hall2.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Hall2, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(Sofa1.name))
        {
            int objNo = 1;
            string nameObj = Sofa1.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Sofa1.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Sofa1, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(Sofa2.name))
        {
            int objNo = 1;
            string nameObj = Sofa2.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Sofa2.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Sofa2, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(Sofa3.name))
        {
            int objNo = 1;
            string nameObj = Sofa3.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Sofa3.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Sofa3, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(Sofa4.name))
        {
            int objNo = 1;
            string nameObj = Sofa4.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Sofa4.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Sofa4, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(Table1.name))
        {
            int objNo = 1;
            string nameObj = Table1.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Table1.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Table1, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(Table2.name))
        {
            int objNo = 1;
            string nameObj = Table2.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Table2.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Table2, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(Table3.name))
        {
            int objNo = 1;
            string nameObj = Table3.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Table3.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Table3, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(Table4.name))
        {
            int objNo = 1;
            string nameObj = Table4.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Table4.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Table4, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(Table5.name))
        {
            int objNo = 1;
            string nameObj = Table5.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Table5.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Table5, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(Person1.name))
        {
            int objNo = 1;
            string nameObj = Person1.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Person1.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Person1, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(Person2.name))
        {
            int objNo = 1;
            string nameObj = Person2.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Person2.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Person2, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(Person3.name))
        {
            int objNo = 1;
            string nameObj = Person3.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Person3.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Person3, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(Person4.name))
        {
            int objNo = 1;
            string nameObj = Person4.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Person4.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Person4, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(Decoration1.name))
        {
            int objNo = 1;
            string nameObj = Decoration1.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Decoration1.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Decoration1, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(Decoration2.name))
        {
            int objNo = 1;
            string nameObj = Decoration2.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Decoration2.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Decoration2, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(Decoration3.name))
        {
            int objNo = 1;
            string nameObj = Decoration3.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Decoration3.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Decoration3, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(Decoration4.name))
        {
            int objNo = 1;
            string nameObj = Decoration4.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Decoration4.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Decoration4, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(Hall1.name))
        {
            int objNo = 1;
            string nameObj = Hall1.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Hall1.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Hall1, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(Hall2.name))
        {
            int objNo = 1;
            string nameObj = Hall2.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = Hall2.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(Hall2, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
        if (objName.Equals(stage1.name))
        {
            int objNo = 1;
            string nameObj = stage1.name + "(" + objNo + ")";
            while (GameObject.Find(nameObj))
            {
                objNo++;
                nameObj = stage1.name + "(" + objNo + ")";
            }
            GameObject obj = (GameObject)Instantiate(stage1, transform.position, transform.rotation);
            obj.transform.Rotate(rot);
            if (scaleX == 0.0f || scaleY == 0.0f || scaleZ == 0.0f)
            { }
            else
            {
                obj.transform.localScale = scale;
            }
            obj.name = nameObj;
            Application.ExternalCall("UpdateTreeNode", nameObj, obj.transform.position.x, obj.transform.position.y, obj.transform.position.z, obj.transform.eulerAngles.x, obj.transform.eulerAngles.y, obj.transform.eulerAngles.z, obj.transform.rotation.x, obj.transform.rotation.y, obj.transform.rotation.z);
        }
    }

    void initiate_LoadedObjects(string objAttributes)
    {
        string objID;
        string objName;
        float posX;
        float posY;
        float posZ;
        float rotX;
        float rotY;
        float rotZ;
        float scaleX;
        float scaleY;
        float scaleZ;

        string[] attributes = objAttributes.Split('#');
        objID = attributes[0];
        objName = attributes[1];
        posX = float.Parse(attributes[2]);
        posY = float.Parse(attributes[3]);
        posZ = float.Parse(attributes[4]);
        rotX = float.Parse(attributes[5]);
        rotY = float.Parse(attributes[6]);
        rotZ = float.Parse(attributes[7]);
        scaleX = float.Parse(attributes[8]);
        scaleY = float.Parse(attributes[9]);
        scaleZ = float.Parse(attributes[10]);

        Vector3 pos = new Vector3(posX,posY,posZ);
        Vector3 rot = new Vector3(rotX, rotY, rotZ);
        Vector3 scale = new Vector3(scaleX, scaleY, scaleZ);

        if (objID.Equals("WeddingHall_1"))
        {
            Vector3 pos1 = new Vector3(1102.0f, 201.0f, 154.0f);
            GameObject obj = (GameObject)Instantiate(WeddingHall_1, pos1, transform.rotation);
            obj.name = "WeddingHall_1";
            obj.transform.Rotate(0.0f, 0.0f, 270.0f);         
        }

        if (objID.Equals("WeddingHall_2"))
        {
            Vector3 pos1 = new Vector3(1736.815f, 388.0f, -375.0f);
            GameObject obj = (GameObject)Instantiate(WeddingHall_2, pos1, transform.rotation);
            obj.name = "WeddingHall_2";
            obj.transform.Rotate(0.0f, 0.0f, -90.0f);
        }

        if (objID.Equals(chair1.name))
        {
            GameObject obj = (GameObject)Instantiate(chair1, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }

        if (objID.Equals(chair2.name))
        {
            GameObject obj = (GameObject)Instantiate(chair2, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(chair3.name))
        {
            GameObject obj = (GameObject)Instantiate(chair3, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(chair4.name))
        {
            GameObject obj = (GameObject)Instantiate(chair4, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(chair5.name))
        {
            GameObject obj = (GameObject)Instantiate(chair5, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(chair6.name))
        {
            GameObject obj = (GameObject)Instantiate(chair6, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(ChairTable1.name))
        {
            GameObject obj = (GameObject)Instantiate(ChairTable1, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(ChairTable2.name))
        {
            GameObject obj = (GameObject)Instantiate(ChairTable2, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(ChairTable3.name))
        {
            GameObject obj = (GameObject)Instantiate(ChairTable3, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(ChairTable4.name))
        {
            GameObject obj = (GameObject)Instantiate(ChairTable4, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(ChairTable5.name))
        {
            GameObject obj = (GameObject)Instantiate(ChairTable5, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }

        if (objID.Equals(Hall1.name))
        {
            GameObject obj = (GameObject)Instantiate(Hall1, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(Hall2.name))
        {
            GameObject obj = (GameObject)Instantiate(Hall2, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(Sofa1.name))
        {
            GameObject obj = (GameObject)Instantiate(Sofa1, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(Sofa2.name))
        {
            GameObject obj = (GameObject)Instantiate(Sofa2, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(Sofa3.name))
        {
            GameObject obj = (GameObject)Instantiate(Sofa3, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(Sofa4.name))
        {
            GameObject obj = (GameObject)Instantiate(Sofa4, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(Table1.name))
        {
            GameObject obj = (GameObject)Instantiate(Table1, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(Table2.name))
        {
            GameObject obj = (GameObject)Instantiate(Table2, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(Table3.name))
        {
            GameObject obj = (GameObject)Instantiate(Table3, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(Table4.name))
        {
            GameObject obj = (GameObject)Instantiate(Table4, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }

        if (objID.Equals(Table5.name))
        {
            GameObject obj = (GameObject)Instantiate(Table5, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }

        if (objID.Equals(Person1.name))
        {
            GameObject obj = (GameObject)Instantiate(Person1, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }

        if (objID.Equals(Person2.name))
        {
            GameObject obj = (GameObject)Instantiate(Person2, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(Person3.name))
        {
            GameObject obj = (GameObject)Instantiate(Person3, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(Person4.name))
        {
            GameObject obj = (GameObject)Instantiate(Person4, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(Decoration1.name))
        {
            GameObject obj = (GameObject)Instantiate(Decoration1, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(Decoration2.name))
        {
            GameObject obj = (GameObject)Instantiate(Decoration2, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(Decoration3.name))
        {
            GameObject obj = (GameObject)Instantiate(Decoration3, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(Decoration4.name))
        {
            GameObject obj = (GameObject)Instantiate(Decoration4, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(Hall1.name))
        {
            GameObject obj = (GameObject)Instantiate(Hall1, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(Hall2.name))
        {
            GameObject obj = (GameObject)Instantiate(Hall2, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
        if (objID.Equals(stage1.name))
        {
            GameObject obj = (GameObject)Instantiate(stage1, pos, transform.rotation);
            obj.name = objName;
            obj.transform.eulerAngles = rot;
            obj.transform.localScale = scale;
        }
    }
}