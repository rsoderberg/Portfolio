package com.mtag.app.muaythaiathletesguide;

import android.app.Activity;
import android.content.Context;
import android.os.Bundle;
import android.support.annotation.Nullable;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class MartialActivity extends Activity {
    @Override
    protected void onCreate(@Nullable Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_martial);

        final ListView listViewMartial = findViewById(R.id.listViewMartial);
        String[] values = new String[]{ "Boxing Workout 1\n(0:00) Jab - Cross - Hook\n(1:00) Rapid Fire Jab - Cross\n(2:00) Heavy L Hook - Heavy R Hook\n3:00 on Clock",
                "Boxing Workout 2\n(0:00) Jab - Parry - Right - Duck\n(1:00)Rapid Fire L Hook - R Hook\n(2:00)Jab - Heavy Cross\n3:00 on Clock",
                "Boxing Workout 3\n(0:00) Jab - L Hook Body - Cross\n(1:00) Jab - Jab - Heavy Cross\n(2:00) Rapid Fire Jab - Cross\n3:00 on Clock",
                "Muay Thai Workout 1\n(0:00) Rapid Fire L Hook - R Hook\n(1:00) Alternate Teeps\n(2:00) Rapid Fire Jab - Cross\n3:00 on Clock",
                "Muay Thai Workout 2\n(0:00) Jab - Cross - Block (L Kick) - L Kick\n(1:00) 2x R Kick - 2x L Kick\n(2:00) Rapid Fire Alternate Teeps\n3:00 on Clock",
                "Muay Thai Workout 3\n(0:00) R Teep - R Knee - R Elbow\n(1:00) L Teep - L Knee - L Elbow\n(2:00) Rapid Fire Jab - Cross\n3:00 on Clock",
                "Full Body Workout\n(0:00) Rapid Fire L Hook Body - R Hook Body\n(1:00) Crunches/Sit Ups\n{2:00) Burpees",
                "Core Strength Cardio\n(0:00) Sit Ups/Crunches\n(1:00) High Knees\n(2:00) Sit Ups/Crunches"};

        final ArrayList<String> list = new ArrayList<String>();
        for (int i = 0; i < values.length; i++)
            list.add(values[i]);

        final MartialActivity.StableArrayAdapter adapter = new MartialActivity.StableArrayAdapter(this,
                android.R.layout.simple_list_item_1, list);
        listViewMartial.setAdapter(adapter);
    }

    private class StableArrayAdapter extends ArrayAdapter<String> {
        HashMap<String, Integer> mIdMap = new HashMap<String, Integer>();

        public StableArrayAdapter(Context context, int textViewResourceId, List<String> objects) {
            super(context, textViewResourceId, objects);

            for (int i = 0; i < objects.size(); i++)
                mIdMap.put(objects.get(i), i);
        }

        @Override
        public long getItemId(int position) {
            String item = getItem(position);

            return mIdMap.get(item);
        }

        @Override
        public boolean hasStableIds() { return true; }
    }
}
